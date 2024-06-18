using Newtonsoft.Json;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Category
    /// </summary>
    public record CoinGeckoCategory
    {
        /// <summary>
        /// Category id
        /// </summary>
        [JsonProperty("category_id")]
        public string CategoryId { get; set; } = string.Empty;
        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; } = string.Empty;
    }
}
