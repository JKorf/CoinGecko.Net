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
        /// ["<c>base</c>"] Base asset
        /// </summary>
        [JsonPropertyName("base")]
        public string Base { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>target</c>"] Quote asset
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>market</c>"] Exchange info
        /// </summary>
        [JsonPropertyName("market")]
        public CoinGeckoAssetExchange? Exchange { get; set; }
        /// <summary>
        /// ["<c>last</c>"] Last price
        /// </summary>
        [JsonPropertyName("last")]
        public decimal? Last { get; set; }
        /// <summary>
        /// ["<c>volume</c>"] Trade volume
        /// </summary>
        [JsonPropertyName("volume")]
        public decimal? Volume { get; set; }
        /// <summary>
        /// ["<c>cost_to_move_up_usd</c>"] Cost to move up in usd
        /// </summary>
        [JsonPropertyName("cost_to_move_up_usd")]
        public decimal? CostToMoveUpUsd { get; set; }
        /// <summary>
        /// ["<c>cost_to_move_down_usd</c>"] Cost to move down in usd
        /// </summary>
        [JsonPropertyName("cost_to_move_down_usd")]
        public decimal? CostToMoveDownUsd { get; set; }
        /// <summary>
        /// ["<c>converted_last</c>"] Converted last
        /// </summary>
        [JsonPropertyName("converted_last")]
        public Dictionary<string, decimal?> ConvertedLast { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>converted_volume</c>"] Converted volume
        /// </summary>
        [JsonPropertyName("converted_volume")]
        public Dictionary<string, decimal?> ConvertedVolume { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>trust_score</c>"] Trust score
        /// </summary>
        [JsonPropertyName("trust_score")]
        public string? TrustScore { get; set; }
        /// <summary>
        /// ["<c>bid_ask_spread_percentage</c>"] Difference in percentage between best bid and ask
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
        /// ["<c>is_anomaly</c>"] Is anomaly
        /// </summary>
        [JsonPropertyName("is_anomaly")]
        public bool IsAnomaly { get; set; }
        /// <summary>
        /// ["<c>is_stale</c>"] Is stale
        /// </summary>
        [JsonPropertyName("is_stale")]
        public bool IsStale { get; set; }
        /// <summary>
        /// ["<c>trade_url</c>"] Trade url
        /// </summary>
        [JsonPropertyName("trade_url")]
        public string? TradeUrl { get; set; }
        /// <summary>
        /// ["<c>token_info_url</c>"] Token info url
        /// </summary>
        [JsonPropertyName("token_info_url")]
        public string? TokenInfoUrl { get; set; }
        /// <summary>
        /// ["<c>coin_id</c>"] Coin id
        /// </summary>
        [JsonPropertyName("coin_id")]
        public string? CoinId { get; set; }
        /// <summary>
        /// ["<c>target_coin_id</c>"] Target coin id
        /// </summary>
        [JsonPropertyName("target_coin_id")]
        public string? TargetCoinId { get; set; }
    }
}
