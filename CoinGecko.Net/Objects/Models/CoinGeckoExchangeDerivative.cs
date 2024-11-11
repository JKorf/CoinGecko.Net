using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Exchange info
    /// </summary>
    public record CoinGeckoExchangeDerivative
    {
        /// <summary>
        /// Mame
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Open interest in btc
        /// </summary>
        [JsonPropertyName("open_interest_btc")]
        public decimal? OpenInterestBtc { get; set; }
        /// <summary>
        /// Trade volume in btc
        /// </summary>
        [JsonPropertyName("trade_volume_24h_btc")]
        public decimal? TradeVolume24hBtc { get; set; }
        /// <summary>
        /// Number of perpetual pairs
        /// </summary>
        [JsonPropertyName("number_of_perpetual_pairs")]
        public int NumberOfPerpetualPairs { get; set; }
        /// <summary>
        /// Number of futures pairs
        /// </summary>
        [JsonPropertyName("number_of_futures_pairs")]
        public int NumberOfFuturesPairs { get; set; }
        /// <summary>
        /// Image
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// Year established
        /// </summary>
        [JsonPropertyName("year_established")]
        public int? YearEstablished { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [JsonPropertyName("decription")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// Tickers
        /// </summary>
        [JsonPropertyName("tickers")]
        public IEnumerable<CoinGeckoDerivativeTicker>? Tickers { get; set; }
    }
}
