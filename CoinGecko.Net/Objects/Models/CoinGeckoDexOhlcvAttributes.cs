using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex OHLCV attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexOhlcvAttributes
    {
        /// <summary>
        /// ["<c>ohlcv_list</c>"] List of OHLCV candles ordered newest-first.
        /// </summary>
        [JsonPropertyName("ohlcv_list")]
        public CoinGeckoDexOhlcv[] OhlcvList { get; set; } = [];
    }
}
