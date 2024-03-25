using System.Text.Json;
using MongoDB.Driver;
using MongoDB.Entities;

namespace SearchService;

public class DbInitializer
{
    public static async Task InitDb(WebApplication app)
    {
            // Initialize MongoDB database connection
            await DB.InitAsync("SearchDb", MongoClientSettings
                .FromConnectionString(app.Configuration.GetConnectionString("MongoDbConnection")));

            // Create indexes for efficient searching
            await DB.Index<Item>()
                .Key(x => x.Make, KeyType.Text)
                .Key(x => x.Model, KeyType.Text)
                .Key(x => x.Color, KeyType.Text)
                .CreateAsync();


        // Check if the database is empty
        var count = await DB.CountAsync<Item>();

        using var scope = app.Services.CreateScope();

        var httpClient = scope.ServiceProvider.GetRequiredService<AuctionSvcHttpClient>();

        // If the database is empty, fetch items from the auction service
        var items = await httpClient.GetItemsForSearchDb();
        
        Console.WriteLine(items.Count + " items returned from the Action Service for search!");

        if (items.Count > 0) await DB.SaveAsync(items);
    }
}