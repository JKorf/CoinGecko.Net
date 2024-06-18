using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Links
    /// </summary>
    public record CoinGeckoLinks
    {
        /// <summary>
        /// Homepage
        /// </summary>
        public IEnumerable<string> Homepage { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Blockchain explorer links
        /// </summary>
        [JsonProperty("blockchain_site")]
        public IEnumerable<string> BlockchainSites { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Official forum urls
        /// </summary>
        [JsonProperty("official_forum_url")]
        public IEnumerable<string> OfficialForumUrls { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Chat urls
        /// </summary>
        [JsonProperty("chat_url")]
        public IEnumerable<string> ChatUrls { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Announcement urls
        /// </summary>
        [JsonProperty("announcement_url")]
        public IEnumerable<string> AnnouncementUrls { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Twitter name
        /// </summary>
        [JsonProperty("twitter_screen_name")]
        public string TwitterScreenName { get; set; } = string.Empty;
        /// <summary>
        /// Facebook name
        /// </summary>
        [JsonProperty("facebook_username")]
        public string FacebookName { get; set; } = string.Empty;
        /// <summary>
        /// BitcoinTalk thread identifier
        /// </summary>
        [JsonProperty("bitcointalk_thread_identifier")]
        public string? BitcoinTalkThreadIdentifier { get; set; } = string.Empty;
        /// <summary>
        /// Telegram channel identifier
        /// </summary>
        [JsonProperty("telegram_channel_identifier")]
        public string? TelegramChannelIdentifier { get; set; } = string.Empty;
        /// <summary>
        /// Subreddit url
        /// </summary>
        [JsonProperty("subreddit_url")]
        public string? SubredditUrl { get; set; } = string.Empty;
        /// <summary>
        /// Git repository urls
        /// </summary>
        [JsonProperty("repos_url")]
        public Dictionary<string, IEnumerable<string>> RepoUrls { get; set; } = new Dictionary<string, IEnumerable<string>>();
    }
}
