using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Exchange details
    /// </summary>
    public record CoinGeckoExchangeDetails
    {
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
        /// Facebook url
        /// </summary>
        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; } = string.Empty;
        /// <summary>
        /// Reddit url
        /// </summary>
        [JsonProperty("reddit_url")]
        public string RedditUrl { get; set; } = string.Empty;
        /// <summary>
        /// Telegram url
        /// </summary>
        [JsonProperty("telegram_url")]
        public string TelegramUrl { get; set; } = string.Empty;
        /// <summary>
        /// Slack url
        /// </summary>
        [JsonProperty("slack_url")]
        public string SlackUrl { get; set; } = string.Empty;
        /// <summary>
        /// Other url 1
        /// </summary>
        [JsonProperty("other_url_1")]
        public string OtherUrl1 { get; set; } = string.Empty;
        /// <summary>
        /// Other url 2
        /// </summary>
        [JsonProperty("other_url_2")]
        public string OtherUrl2 { get; set; } = string.Empty;
        /// <summary>
        /// Twitter handle
        /// </summary>
        [JsonProperty("twitter_handle")]
        public string TwitterHandle { get; set; } = string.Empty;
        /// <summary>
        /// Has trading incentive
        /// </summary>
        [JsonProperty("has_trading_incentive")]
        public bool HasTradingIncentive { get; set; }
        /// <summary>
        /// Centralized
        /// </summary>
        public bool Centralized { get; set; }
        /// <summary>
        /// Public notice
        /// </summary>
        [JsonProperty("public_notice")]
        public string PublicNotice { get; set; } = string.Empty;
        /// <summary>
        /// Alert notice
        /// </summary>
        [JsonProperty("alert_notice")]
        public string AlertNotice { get; set; } = string.Empty;
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
        /// Trade volume in btc last 24h
        /// </summary>
        [JsonProperty("trade_volume_24h_btc")]
        public decimal? TradeVolume24hBtc { get; set; }
        /// <summary>
        /// Normalized trade volume in btc last 24h
        /// </summary>
        [JsonProperty("trade_volume_24h_btc_normalized")]
        public decimal? TradeVolume24hBtcNormalized { get; set; }
        /// <summary>
        /// Tickers
        /// </summary>
        public IEnumerable<CoinGeckoTicker> Tickers { get; set; } = Array.Empty<CoinGeckoTicker>();
        /// <summary>
        /// Status updates
        /// </summary>
        [JsonProperty("status_updates")]
        public IEnumerable<CoinGeckoStatusUpdate> StatusUpdates { get; set; } = Array.Empty<CoinGeckoStatusUpdate>();
    }
}
