using Contracts;
using MassTransit;
using MongoDB.Entities;

namespace SearchService;

public class BidPlacedConsumer : IConsumer<BidPlaced>
{
    public async Task Consume(ConsumeContext<BidPlaced> context)
    {
        Console.WriteLine("--> Consuming bid placed");

        var auction = await DB.Find<Item>().OneAsync(context.Message.AuctionId);

        // If there is no current high bid or the bid status is accepted
        // and the amount is higher than the current high bid
        if (context.Message.BidStatus.Contains("Accepted") 
            && context.Message.Amount > auction.CurrentHighBid)
        {
            auction.CurrentHighBid = context.Message.Amount;
            await auction.SaveAsync();
        }
    }
}