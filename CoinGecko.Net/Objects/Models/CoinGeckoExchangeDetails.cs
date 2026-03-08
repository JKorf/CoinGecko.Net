using System.Text.Json.Serialization;
using System;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Exchange details
    /// </summary>
    [SerializationModel]
    public record CoinGeckoExchangeDetails
    {
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
        /// ["<c>facebook_url</c>"] Facebook url
        /// </summary>
        [JsonPropertyName("facebook_url")]
        public string FacebookUrl { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>reddit_url</c>"] Reddit url
        /// </summary>
        [JsonPropertyName("reddit_url")]
        public string RedditUrl { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>telegram_url</c>"] Telegram url
        /// </summary>
        [JsonPropertyName("telegram_url")]
        public string TelegramUrl { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>slack_url</c>"] Slack url
        /// </summary>
        [JsonPropertyName("slack_url")]
        public string SlackUrl { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>other_url_1</c>"] Other url 1
        /// </summary>
        [JsonPropertyName("other_url_1")]
        public string OtherUrl1 { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>other_url_2</c>"] Other url 2
        /// </summary>
        [JsonPropertyName("other_url_2")]
        public string OtherUrl2 { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>twitter_handle</c>"] Twitter handle
        /// </summary>
        [JsonPropertyName("twitter_handle")]
        public string TwitterHandle { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>has_trading_incentive</c>"] Has trading incentive
        /// </summary>
        [JsonPropertyName("has_trading_incentive")]
        public bool HasTradingIncentive { get; set; }
        /// <summary>
        /// ["<c>centralized</c>"] Centralized
        /// </summary>
        [JsonPropertyName("centralized")]
        public bool Centralized { get; set; }
        /// <summary>
        /// ["<c>public_notice</c>"] Public notice
        /// </summary>
        [JsonPropertyName("public_notice")]
        public string PublicNotice { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>alert_notice</c>"] Alert notice
        /// </summary>
        [JsonPropertyName("alert_notice")]
        public string AlertNotice { get; set; } = string.Empty;
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
        /// ["<c>trade_volume_24h_btc</c>"] Trade volume in btc last 24h
        /// </summary>
        [JsonPropertyName("trade_volume_24h_btc")]
        public decimal? TradeVolume24hBtc { get; set; }
        /// <summary>
        /// ["<c>trade_volume_24h_btc_normalized</c>"] Normalized trade volume in btc last 24h
        /// </summary>
        [JsonPropertyName("trade_volume_24h_btc_normalized")]
        public decimal? TradeVolume24hBtcNormalized { get; set; }
        /// <summary>
        /// ["<c>coins</c>"] Number of assets
        /// </summary>
        [JsonPropertyName("coins")]
        public int Assets { get; set; }
        /// <summary>
        /// ["<c>pairs</c>"] Number of symbols
        /// </summary>
        [JsonPropertyName("pairs")]
        public int Symbols { get; set; }
        /// <summary>
        /// ["<c>tickers</c>"] Tickers
        /// </summary>
        [JsonPropertyName("tickers")]
        public CoinGeckoTicker[] Tickers { get; set; } = Array.Empty<CoinGeckoTicker>();
    }
}
