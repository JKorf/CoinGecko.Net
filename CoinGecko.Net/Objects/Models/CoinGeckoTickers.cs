using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Tickers
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTickers
    {
        /// <summary>
        /// Asset name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Tickers
        /// </summary>
        [JsonPropertyName("tickers")]
        public CoinGeckoTicker[] Tickers { get; set; } = Array.Empty<CoinGeckoTicker>();
    }
}
