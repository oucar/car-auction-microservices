namespace Contracts;

public class AuctionFinished
{
    /// <summary>
    /// Gets or sets a value indicating whether the auction item was sold.
    /// </summary>
    public bool ItemSold { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the auction.
    /// </summary>
    public string AuctionId { get; set; }

    /// <summary>
    /// Gets or sets the name of the winning bidder.
    /// </summary>
    public string Winner { get; set; }

    /// <summary>
    /// Gets or sets the name of the seller of the auction item.
    /// </summary>
    public string Seller { get; set; }

    /// <summary>
    /// Gets or sets the amount of money involved in the transaction. 
    /// </summary>
    /// <remarks>
    /// This property is nullable to accommodate auctions where no transaction amount is specified.
    /// </remarks>
    public int? Amount { get; set; }
}
