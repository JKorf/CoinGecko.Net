using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex OHLCV response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexOhlcvResponse
    {
        /// <summary>
        /// ["<c>data</c>"] OHLCV data wrapper
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoDexOhlcvData Data { get; set; } = new();

        /// <summary>
        /// ["<c>meta</c>"] Meta information about base/quote tokens
        /// </summary>
        [JsonPropertyName("meta")]
        public CoinGeckoDexOhlcvMeta? Meta { get; set; }
    }
}
