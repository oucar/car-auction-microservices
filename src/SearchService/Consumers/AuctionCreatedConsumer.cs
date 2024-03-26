using AutoMapper;
using Contracts;
using MassTransit;
using MongoDB.Entities;

namespace SearchService;

// MassTransit is convention-based, so it will automatically find and register consumers in the assembly.
// Use word "Consumer" in the class name to be automatically registered as a consumer.
public class AuctionCreatedConsumer : IConsumer<AuctionCreated>
{
    private readonly IMapper _mapper;

    public AuctionCreatedConsumer(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task Consume(ConsumeContext<AuctionCreated> context)
    {
        // @@TODO: DEBUG ONLY
        Console.WriteLine("--> Consuming auction created: " + context.Message.Id);

        var item = _mapper.Map<Item>(context.Message);

        // @@TODO: DEBUG ONLY
        if (item.Model == "Foo")
        {
            Console.WriteLine("WARN: DEBUG ONLY - Cannot sell cars with name of Foo");
            throw new ArgumentException("Cannot sell cars with name of Foo");
        }

        await item.SaveAsync();
    }
}
