using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex OHLCV meta information
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexOhlcvMeta
    {
        /// <summary>
        /// ["<c>base</c>"] Base token meta
        /// </summary>
        [JsonPropertyName("base")]
        public CoinGeckoDexOhlcvTokenMeta? Base { get; set; }

        /// <summary>
        /// ["<c>quote</c>"] Quote token meta
        /// </summary>
        [JsonPropertyName("quote")]
        public CoinGeckoDexOhlcvTokenMeta? Quote { get; set; }
    }
}
