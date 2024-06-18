using Newtonsoft.Json;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Exchange info
    /// </summary>
    public record CoinGeckoExchange
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Year established
        /// </summary>
        [JsonProperty("year_established")]
        public int? YearEstablished { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; } = string.Empty;
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// Image
        /// </summary>
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// Has a trading incentive
        /// </summary>
        [JsonProperty("has_trading_incentive")]
        public bool? HasTradingIncentive { get; set; }
        /// <summary>
        /// Trust score
        /// </summary>
        [JsonProperty("trust_score")]
        public string? TrustScore { get; set; }
        /// <summary>
        /// Trust score rank
        /// </summary>
        [JsonProperty("trust_score_rank")]
        public int? TrustScoreRank { get; set; }
        /// <summary>
        /// Trading volume in btc last 24h
        /// </summary>
        [JsonProperty("trade_volume_24h_btc")]
        public decimal? TradeVolume24hBtc { get; set; }
        /// <summary>
        /// Normalized trading volume in btc last 24h
        /// </summary>
        [JsonProperty("trade_volume_24h_btc_normalized")]
        public decimal? TradeVolume24hBtcNormalized { get; set; }
    }
}
