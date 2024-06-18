namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// List item
    /// </summary>
    public record CoinGeckoListItem
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
    }
}
