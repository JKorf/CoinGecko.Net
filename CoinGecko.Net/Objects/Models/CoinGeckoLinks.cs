using CryptoExchange.Net.Converters.SystemTextJson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Links
    /// </summary>
    [SerializationModel]
    public record CoinGeckoLinks
    {
        /// <summary>
        /// Homepage
        /// </summary>
        [JsonPropertyName("homepage")]
        public string[] Homepage { get; set; } = Array.Empty<string>();
        /// <summary>
        /// White paper link
        /// </summary>
        [JsonPropertyName("whitepaper")]
        public string? WhitePaper { get; set; }
        /// <summary>
        /// Blockchain explorer links
        /// </summary>
        [JsonPropertyName("blockchain_site")]
        public string[] BlockchainSites { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Official forum urls
        /// </summary>
        [JsonPropertyName("official_forum_url")]
        public string[] OfficialForumUrls { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Chat urls
        /// </summary>
        [JsonPropertyName("chat_url")]
        public string[] ChatUrls { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Announcement urls
        /// </summary>
        [JsonPropertyName("announcement_url")]
        public string[] AnnouncementUrls { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Twitter name
        /// </summary>
        [JsonPropertyName("twitter_screen_name")]
        public string TwitterScreenName { get; set; } = string.Empty;
        /// <summary>
        /// Facebook name
        /// </summary>
        [JsonPropertyName("facebook_username")]
        public string FacebookName { get; set; } = string.Empty;
        /// <summary>
        /// BitcoinTalk thread identifier
        /// </summary>
        [JsonPropertyName("bitcointalk_thread_identifier")]
        public string? BitcoinTalkThreadIdentifier { get; set; } = string.Empty;
        /// <summary>
        /// Telegram channel identifier
        /// </summary>
        [JsonPropertyName("telegram_channel_identifier")]
        public string? TelegramChannelIdentifier { get; set; } = string.Empty;
        /// <summary>
        /// Subreddit url
        /// </summary>
        [JsonPropertyName("subreddit_url")]
        public string? SubredditUrl { get; set; } = string.Empty;
        /// <summary>
        /// Git repository urls
        /// </summary>
        [JsonPropertyName("repos_url")]
        public Dictionary<string, IEnumerable<string>> RepoUrls { get; set; } = new Dictionary<string, IEnumerable<string>>();
    }
}
