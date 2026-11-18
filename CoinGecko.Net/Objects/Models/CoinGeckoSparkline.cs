using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Seven-day price sparkline
    /// </summary>
    [SerializationModel]
    public record CoinGeckoSparkline
    {
        /// <summary>
        /// ["<c>price</c>"] Array of price values
        /// </summary>
        [JsonPropertyName("price")]
        public decimal[]? Price { get; set; }
    }
}
