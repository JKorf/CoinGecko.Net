using Newtonsoft.Json;

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
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Open interest in btc
        /// </summary>
        [JsonProperty("open_interest_btc")]
        public decimal? OpenInterestBtc { get; set; }
        /// <summary>
        /// Trade volume in btc
        /// </summary>
        [JsonProperty("trade_volume_24h_btc")]
        public decimal? TradeVolume24hBtc { get; set; }
        /// <summary>
        /// Number of perpetual pairs
        /// </summary>
        [JsonProperty("number_of_perpetual_pairs")]
        public int NumberOfPerpetualPairs { get; set; }
        /// <summary>
        /// Number of futures pairs
        /// </summary>
        [JsonProperty("number_of_futures_pairs")]
        public int NumberOfFuturesPairs { get; set; }
        /// <summary>
        /// Image
        /// </summary>
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// Year established
        /// </summary>
        [JsonProperty("year_established")]
        public int? YearEstablished { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        public string? Country { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; } = string.Empty;
    }
}
