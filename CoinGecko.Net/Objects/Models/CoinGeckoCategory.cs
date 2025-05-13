using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Category
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCategory
    {
        /// <summary>
        /// Category id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; } = string.Empty;
        /// <summary>
        /// Category name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
