using System;
using System.Collections.Generic;
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
        /// ["<c>homepage</c>"] Homepage
        /// </summary>
        [JsonPropertyName("homepage")]
        public string[] Homepage { get; set; } = Array.Empty<string>();
        /// <summary>
        /// ["<c>whitepaper</c>"] White paper link
        /// </summary>
        [JsonPropertyName("whitepaper")]
        public string? WhitePaper { get; set; }
        /// <summary>
        /// ["<c>blockchain_site</c>"] Blockchain explorer links
        /// </summary>
        [JsonPropertyName("blockchain_site")]
        public string[] BlockchainSites { get; set; } = Array.Empty<string>();
        /// <summary>
        /// ["<c>official_forum_url</c>"] Official forum urls
        /// </summary>
        [JsonPropertyName("official_forum_url")]
        public string[] OfficialForumUrls { get; set; } = Array.Empty<string>();
        /// <summary>
        /// ["<c>chat_url</c>"] Chat urls
        /// </summary>
        [JsonPropertyName("chat_url")]
        public string[] ChatUrls { get; set; } = Array.Empty<string>();
        /// <summary>
        /// ["<c>announcement_url</c>"] Announcement urls
        /// </summary>
        [JsonPropertyName("announcement_url")]
        public string[] AnnouncementUrls { get; set; } = Array.Empty<string>();
        /// <summary>
        /// ["<c>twitter_screen_name</c>"] Twitter name
        /// </summary>
        [JsonPropertyName("twitter_screen_name")]
        public string TwitterScreenName { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>facebook_username</c>"] Facebook name
        /// </summary>
        [JsonPropertyName("facebook_username")]
        public string FacebookName { get; set; } = string.Empty;
        /// <summary>
        /// BitcoinTalk thread identifier
        /// </summary>
        [JsonPropertyName("bitcointalk_thread_identifier"), JsonConverter(typeof(NumberStringConverter))]
        public string? BitcoinTalkThreadIdentifier { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>telegram_channel_identifier</c>"] Telegram channel identifier
        /// </summary>
        [JsonPropertyName("telegram_channel_identifier")]
        public string? TelegramChannelIdentifier { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>subreddit_url</c>"] Subreddit url
        /// </summary>
        [JsonPropertyName("subreddit_url")]
        public string? SubredditUrl { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>snapshot_url</c>"] Snapshot url
        /// </summary>
        [JsonPropertyName("snapshot_url")]
        public string? SnapshotUrl { get; set; }
        /// <summary>
        /// ["<c>repos_url</c>"] Git repository urls
        /// </summary>
        [JsonPropertyName("repos_url")]
        public Dictionary<string, IEnumerable<string>> RepoUrls { get; set; } = new Dictionary<string, IEnumerable<string>>();
    }
}
