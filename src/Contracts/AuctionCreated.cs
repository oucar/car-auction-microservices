namespace Contracts;

public class AuctionCreated
{
    /// <summary>
    /// Gets or sets the unique identifier of the auction.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the reserve price of the auction.
    /// </summary>
    public int ReservePrice { get; set; }

    /// <summary>
    /// Gets or sets the seller of the item being auctioned.
    /// </summary>
    public string Seller { get; set; }

    /// <summary>
    /// Gets or sets the winner of the auction.
    /// </summary>
    public string Winner { get; set; }

    /// <summary>
    /// Gets or sets the amount for which the item was sold.
    /// </summary>
    public int SoldAmount { get; set; }

    /// <summary>
    /// Gets or sets the current highest bid in the auction.
    /// </summary>
    public int CurrentHighBid { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the auction was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the auction was last updated.
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the auction ends.
    /// </summary>
    public DateTime AuctionEnd { get; set; }

    /// <summary>
    /// Gets or sets the status of the auction.
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets the make of the item being auctioned.
    /// </summary>
    public string Make { get; set; }

    /// <summary>
    /// Gets or sets the model of the item being auctioned.
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Gets or sets the year of the item being auctioned.
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// Gets or sets the color of the item being auctioned.
    /// </summary>
    public string Color { get; set; }

    /// <summary>
    /// Gets or sets the mileage of the item being auctioned.
    /// </summary>
    public int Mileage { get; set; }

    /// <summary>
    /// Gets or sets the URL of the image representing the item being auctioned.
    /// </summary>
    public string ImageUrl { get; set; }
}
