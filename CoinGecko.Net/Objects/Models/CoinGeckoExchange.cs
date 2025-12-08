using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Exchange info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoExchange
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Year established
        /// </summary>
        [JsonPropertyName("year_established")]
        public int? YearEstablished { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;
        /// <summary>
        /// Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// Image
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// Has a trading incentive
        /// </summary>
        [JsonPropertyName("has_trading_incentive")]
        public bool? HasTradingIncentive { get; set; }
        /// <summary>
        /// Trust score
        /// </summary>
        [JsonPropertyName("trust_score")]
        public int? TrustScore { get; set; }
        /// <summary>
        /// Trust score rank
        /// </summary>
        [JsonPropertyName("trust_score_rank")]
        public int? TrustScoreRank { get; set; }
        /// <summary>
        /// Trading volume in btc last 24h
        /// </summary>
        [JsonPropertyName("trade_volume_24h_btc")]
        public decimal? TradeVolume24hBtc { get; set; }
        /// <summary>
        /// Normalized trading volume in btc last 24h
        /// </summary>
        [JsonPropertyName("trade_volume_24h_btc_normalized")]
        public decimal? TradeVolume24hBtcNormalized { get; set; }
    }
}
