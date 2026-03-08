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
        /// ["<c>name</c>"] Asset name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>tickers</c>"] Tickers
        /// </summary>
        [JsonPropertyName("tickers")]
        public CoinGeckoTicker[] Tickers { get; set; } = Array.Empty<CoinGeckoTicker>();
    }
}
