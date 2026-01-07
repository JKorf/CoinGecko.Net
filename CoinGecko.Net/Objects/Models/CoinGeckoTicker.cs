using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Ticker info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTicker
    {
        /// <summary>
        /// Base asset
        /// </summary>
        [JsonPropertyName("base")]
        public string Base { get; set; } = string.Empty;
        /// <summary>
        /// Quote asset
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; } = string.Empty;
        /// <summary>
        /// Exchange info
        /// </summary>
        [JsonPropertyName("market")]
        public CoinGeckoAssetExchange? Exchange { get; set; }
        /// <summary>
        /// Last price
        /// </summary>
        [JsonPropertyName("last")]
        public decimal? Last { get; set; }
        /// <summary>
        /// Trade volume
        /// </summary>
        [JsonPropertyName("volume")]
        public decimal? Volume { get; set; }
        /// <summary>
        /// Cost to move up in usd
        /// </summary>
        [JsonPropertyName("cost_to_move_up_usd")]
        public decimal? CostToMoveUpUsd { get; set; }
        /// <summary>
        /// Cost to move down in usd
        /// </summary>
        [JsonPropertyName("cost_to_move_down_usd")]
        public decimal? CostToMoveDownUsd { get; set; }
        /// <summary>
        /// Converted last
        /// </summary>
        [JsonPropertyName("converted_last")]
        public Dictionary<string, decimal?> ConvertedLast { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// Converted volume
        /// </summary>
        [JsonPropertyName("converted_volume")]
        public Dictionary<string, decimal?> ConvertedVolume { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// Trust score
        /// </summary>
        [JsonPropertyName("trust_score")]
        public string? TrustScore { get; set; }
        /// <summary>
        /// Difference in percentage between best bid and ask
        /// </summary>
        [JsonPropertyName("bid_ask_spread_percentage")]
        public decimal? BidAskSpreadPercentage { get; set; }
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Last trade timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("last_traded_at")]
        public DateTime? LastTradedAt { get; set; }
        /// <summary>
        /// Last fetch timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("last_fetch_at")]
        public DateTime? LastFetchAt { get; set; }
        /// <summary>
        /// Is anomaly
        /// </summary>
        [JsonPropertyName("is_anomaly")]
        public bool IsAnomaly { get; set; }
        /// <summary>
        /// Is stale
        /// </summary>
        [JsonPropertyName("is_stale")]
        public bool IsStale { get; set; }
        /// <summary>
        /// Trade url
        /// </summary>
        [JsonPropertyName("trade_url")]
        public string? TradeUrl { get; set; }
        /// <summary>
        /// Token info url
        /// </summary>
        [JsonPropertyName("token_info_url")]
        public string? TokenInfoUrl { get; set; }
        /// <summary>
        /// Coin id
        /// </summary>
        [JsonPropertyName("coin_id")]
        public string? CoinId { get; set; }
        /// <summary>
        /// Target coin id
        /// </summary>
        [JsonPropertyName("target_coin_id")]
        public string? TargetCoinId { get; set; }
    }
}
