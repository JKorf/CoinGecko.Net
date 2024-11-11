using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Tickers
    /// </summary>
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
        public IEnumerable<CoinGeckoTicker> Tickers { get; set; } = Array.Empty<CoinGeckoTicker>();
    }
}
