using System.Net;
using Polly;
using Polly.Extensions.Http;
using SearchService;
using MassTransit;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddHttpClient<AuctionSvcHttpClient>().AddPolicyHandler(GetPolicy());

// Register MassTransit
builder.Services.AddMassTransit(x => 
{
    x.AddConsumersFromNamespaceContaining<AuctionCreatedConsumer>();
    x.SetEndpointNameFormatter(new KebabCaseEndpointNameFormatter("search", false));
    x.UsingRabbitMq((context, cfg) => 
    {
        // Configure the RabbitMQ host
        cfg.ReceiveEndpoint("search-auction-created", e => 
        {
            // 5 retries, 5 seconds apart
            e.UseMessageRetry(r => r.Interval(5, 5));
            e.ConfigureConsumer<AuctionCreatedConsumer>(context);
        });
        cfg.ConfigureEndpoints(context);
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseAuthorization();

app.MapControllers();

// Initialize the database
app.Lifetime.ApplicationStarted.Register(async () =>
{
    try
    {
        await DbInitializer.InitDb(app);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
});

app.Run();

// Retry policy for handling transient errors - Polly library
// Defines a retry policy using the Polly library, which is commonly used for
// handling transient faults in distributed systems, such as temporary network issues or service failures.
// Example: Start SearchService without starting the AuctionService and it'll keep retrying every 3 seconds.
// Once you start the AuctionService, the SearchService will start receiving data.
static IAsyncPolicy<HttpResponseMessage> GetPolicy() => // Configure the policy to handle temporary network errors or server overload by retrying the HTTP request.
    HttpPolicyExtensions
        // Configure the policy to handle temporary network errors or server overload by retrying the HTTP request.
        .HandleTransientHttpError()
        // Add an extra condition to handle the case when the requested resource is not found (HTTP status code 404).
        .OrResult(msg => msg.StatusCode == HttpStatusCode.NotFound)
        // Set up the policy to retry the HTTP request indefinitely with a fixed delay of 3 seconds between each retry.
        // This strategy helps spread out retry attempts, preventing overwhelming the server with too many requests.
        // Will try every 3 seconds until the request succeeds - on Auction Service for example.
        .WaitAndRetryForeverAsync(_ => TimeSpan.FromSeconds(3));
