using System.Text.Json.Serialization;
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
        /// Facebook url
        /// </summary>
        [JsonPropertyName("facebook_url")]
        public string FacebookUrl { get; set; } = string.Empty;
        /// <summary>
        /// Reddit url
        /// </summary>
        [JsonPropertyName("reddit_url")]
        public string RedditUrl { get; set; } = string.Empty;
        /// <summary>
        /// Telegram url
        /// </summary>
        [JsonPropertyName("telegram_url")]
        public string TelegramUrl { get; set; } = string.Empty;
        /// <summary>
        /// Slack url
        /// </summary>
        [JsonPropertyName("slack_url")]
        public string SlackUrl { get; set; } = string.Empty;
        /// <summary>
        /// Other url 1
        /// </summary>
        [JsonPropertyName("other_url_1")]
        public string OtherUrl1 { get; set; } = string.Empty;
        /// <summary>
        /// Other url 2
        /// </summary>
        [JsonPropertyName("other_url_2")]
        public string OtherUrl2 { get; set; } = string.Empty;
        /// <summary>
        /// Twitter handle
        /// </summary>
        [JsonPropertyName("twitter_handle")]
        public string TwitterHandle { get; set; } = string.Empty;
        /// <summary>
        /// Has trading incentive
        /// </summary>
        [JsonPropertyName("has_trading_incentive")]
        public bool HasTradingIncentive { get; set; }
        /// <summary>
        /// Centralized
        /// </summary>
        [JsonPropertyName("centralized")]
        public bool Centralized { get; set; }
        /// <summary>
        /// Public notice
        /// </summary>
        [JsonPropertyName("public_notice")]
        public string PublicNotice { get; set; } = string.Empty;
        /// <summary>
        /// Alert notice
        /// </summary>
        [JsonPropertyName("alert_notice")]
        public string AlertNotice { get; set; } = string.Empty;
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
        /// Trade volume in btc last 24h
        /// </summary>
        [JsonPropertyName("trade_volume_24h_btc")]
        public decimal? TradeVolume24hBtc { get; set; }
        /// <summary>
        /// Normalized trade volume in btc last 24h
        /// </summary>
        [JsonPropertyName("trade_volume_24h_btc_normalized")]
        public decimal? TradeVolume24hBtcNormalized { get; set; }
        /// <summary>
        /// Tickers
        /// </summary>
        [JsonPropertyName("tickers")]
        public IEnumerable<CoinGeckoTicker> Tickers { get; set; } = Array.Empty<CoinGeckoTicker>();
    }
}
