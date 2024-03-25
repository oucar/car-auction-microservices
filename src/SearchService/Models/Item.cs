using MongoDB.Entities;

namespace SearchService
{
    public class Item : Entity
    {
        /// <summary>
        /// Gets or sets the reserve price of the item.
        /// </summary>
        public int ReservePrice { get; set; }

        /// <summary>
        /// Gets or sets the seller of the item.
        /// </summary>
        public string Seller { get; set; }

        /// <summary>
        /// Gets or sets the winner of the item.
        /// </summary>
        public string Winner { get; set; }

        /// <summary>
        /// Gets or sets the amount for which the item was sold.
        /// </summary>
        public int SoldAmount { get; set; }

        /// <summary>
        /// Gets or sets the current highest bid for the item.
        /// </summary>
        public int CurrentHighBid { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the item was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the item was last updated.
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the auction for the item ends.
        /// </summary>
        public DateTime AuctionEnd { get; set; }

        /// <summary>
        /// Gets or sets the status of the item.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the make of the item.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the model of the item.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the year of the item.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the color of the item.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the mileage of the item.
        /// </summary>
        public int Mileage { get; set; }

        /// <summary>
        /// Gets or sets the URL of the image of the item.
        /// </summary>
        public string ImageUrl { get; set; }
    }
}