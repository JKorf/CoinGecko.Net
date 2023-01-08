using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Ticker info
    /// </summary>
    public class CoinGeckoTicker
    {
        /// <summary>
        /// Base asset
        /// </summary>
        public string Base { get; set; } = string.Empty;
        /// <summary>
        /// Quote asset
        /// </summary>
        public string Target { get; set; } = string.Empty;
        /// <summary>
        /// Market info
        /// </summary>
        public CoinGeckoAssetMarket? Market { get; set; }
        /// <summary>
        /// Last price
        /// </summary>
        public decimal? Last { get; set; }
        /// <summary>
        /// Trade volume
        /// </summary>
        public decimal? Volume { get; set; }
        /// <summary>
        /// Converted last
        /// </summary>
        [JsonProperty("converted_last")]
        public Dictionary<string, decimal> ConvertedLast { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Converted volume
        /// </summary>
        [JsonProperty("converted_volume")]
        public Dictionary<string, decimal> ConvertedVolume { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Trust score
        /// </summary>
        [JsonProperty("trust_score")]
        public string? TrustScore { get; set; }
        /// <summary>
        /// Difference in percentage between best bid and ask
        /// </summary>
        [JsonProperty("bid_ask_spread_percentage")]
        public decimal? BidAskSpreadPercentage { get; set; }
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Last trade timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("last_traded_at")]
        public DateTime? LastTradedAt { get; set; }
        /// <summary>
        /// Last fetch timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("last_fetch_at")]
        public DateTime? LastFetchAt { get; set; }
        /// <summary>
        /// Is anomaly
        /// </summary>
        [JsonProperty("is_anomaly")]
        public bool IsAnomaly { get; set; }
        /// <summary>
        /// Is stale
        /// </summary>
        [JsonProperty("is_stale")]
        public bool IsStale { get; set; }
        /// <summary>
        /// Trade url
        /// </summary>
        [JsonProperty("trade_url")]
        public string? TradeUrl { get; set; }
        /// <summary>
        /// Token info url
        /// </summary>
        [JsonProperty("token_info_url")]
        public string? TokenInfoUrl { get; set; }
        /// <summary>
        /// Coin id
        /// </summary>
        [JsonProperty("coin_id")]
        public string? CoinId { get; set; }
        /// <summary>
        /// Target coin id
        /// </summary>
        [JsonProperty("target_coin_id")]
        public string? TargetCoinId { get; set; }
    }
}
