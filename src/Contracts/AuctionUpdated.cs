namespace Contracts;

public class AuctionUpdated
{
    /// <summary>
    /// Gets or sets the identifier of the auction that was updated.
    /// </summary>
    public string Id { get; set; }

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
}
