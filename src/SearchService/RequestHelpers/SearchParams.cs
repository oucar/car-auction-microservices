namespace SearchService
{
    public class SearchParams
    {
        /// <summary>
        /// Gets or sets the search term to filter items.
        /// </summary>
        public string SearchTerm { get; set; }

        /// <summary>
        /// Gets or sets the page number for pagination.
        /// </summary>
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// Gets or sets the page size for pagination.
        /// </summary>
        public int PageSize { get; set; } = 4;

        /// <summary>
        /// Gets or sets the seller's name to filter items by seller.
        /// </summary>
        public string Seller { get; set; }

        /// <summary>
        /// Gets or sets the winner's name to filter items by winner.
        /// </summary>
        public string Winner { get; set; }

        /// <summary>
        /// Gets or sets the field to order the search results by.
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Gets or sets the criteria to filter the search results by.
        /// </summary>
        public string FilterBy { get; set; }
    }
}
