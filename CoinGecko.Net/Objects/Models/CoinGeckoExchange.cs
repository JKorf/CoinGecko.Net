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
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>year_established</c>"] Year established
        /// </summary>
        [JsonPropertyName("year_established")]
        public int? YearEstablished { get; set; }
        /// <summary>
        /// ["<c>country</c>"] Country
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>description</c>"] Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>url</c>"] Url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>image</c>"] Image
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>has_trading_incentive</c>"] Has a trading incentive
        /// </summary>
        [JsonPropertyName("has_trading_incentive")]
        public bool? HasTradingIncentive { get; set; }
        /// <summary>
        /// ["<c>trust_score</c>"] Trust score
        /// </summary>
        [JsonPropertyName("trust_score")]
        public int? TrustScore { get; set; }
        /// <summary>
        /// ["<c>trust_score_rank</c>"] Trust score rank
        /// </summary>
        [JsonPropertyName("trust_score_rank")]
        public int? TrustScoreRank { get; set; }
        /// <summary>
        /// ["<c>trade_volume_24h_btc</c>"] Trading volume in btc last 24h
        /// </summary>
        [JsonPropertyName("trade_volume_24h_btc")]
        public decimal? TradeVolume24hBtc { get; set; }
        /// <summary>
        /// ["<c>trade_volume_24h_btc_normalized</c>"] Normalized trading volume in btc last 24h
        /// </summary>
        [JsonPropertyName("trade_volume_24h_btc_normalized")]
        public decimal? TradeVolume24hBtcNormalized { get; set; }
    }
}
