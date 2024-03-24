namespace AuctionService.DTOs;

// Entities represent real-world objects in our application with both data and behavior,
// closely tied to our business logic. They are often used to interact with our database.
// 
// DTOs (Data Transfer Objects) are used solely for transferring data between different
// parts of our application. They contain only data and no behavior, making them lightweight
// and ideal for communication between different layers or components.
public class AuctionDto
{
    /// <summary>
    /// Unique identifier for the auction.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Minimum price at which the item can be sold.
    /// </summary>
    public int ReservePrice { get; set; }
    
    /// <summary>
    /// Name of the seller.
    /// </summary>
    public string Seller { get; set; }
    
    /// <summary>
    /// Name of the winner (if the auction is closed).
    /// </summary>
    public string Winner { get; set; }
    
    /// <summary>
    /// Amount for which the item was sold (if the auction is closed).
    /// </summary>
    public int SoldAmount { get; set; }
    
    /// <summary>
    /// Current highest bid amount.
    /// </summary>
    public int CurrentHighBid { get; set; }
    
    /// <summary>
    /// Date and time when the auction was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Date and time when the auction was last updated.
    /// </summary>
    public DateTime UpdatedAt { get; set; }
    
    /// <summary>
    /// Date and time when the auction will end.
    /// </summary>
    public DateTime AuctionEnd { get; set; }
    
    /// <summary>
    /// Status of the auction (e.g., Open, Closed).
    /// </summary>
    public string Status { get; set; }
    
    /// <summary>
    /// Details of the item being auctioned.
    /// </summary>
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Mileage { get; set; }
    public string ImageUrl { get; set; }
}