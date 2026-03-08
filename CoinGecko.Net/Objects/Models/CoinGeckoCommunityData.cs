using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Community data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCommunityData
    {
        /// <summary>
        /// ["<c>facebook_likes</c>"] Facebook likes
        /// </summary>
        [JsonPropertyName("facebook_likes")]
        public int? FacebookLikes { get; set; }
        /// <summary>
        /// ["<c>reddit_average_posts_48h</c>"] Average amount of reddit posts per 48 hours
        /// </summary>
        [JsonPropertyName("reddit_average_posts_48h")]
        public decimal? RedditAveragePostsPer48h { get; set; }
        /// <summary>
        /// ["<c>reddit_average_comments_48h</c>"] Average amount of reddit comments per 48 hours
        /// </summary>
        [JsonPropertyName("reddit_average_comments_48h")]
        public decimal? RedditAverageCommentsPer48h { get; set; }
        /// <summary>
        /// ["<c>reddit_subscribers</c>"] Reddit subscribers
        /// </summary>
        [JsonPropertyName("reddit_subscribers")]
        public int? RedditSubscribers { get; set; }
        /// <summary>
        /// ["<c>reddit_accounts_active_48h</c>"] Active reddit subscribers last 48 hours
        /// </summary>
        [JsonPropertyName("reddit_accounts_active_48h")]
        public decimal? RedditActiveAccounts48h { get; set; }
        /// <summary>
        /// ["<c>telegram_channel_user_count</c>"] Telegram channel user count
        /// </summary>
        [JsonPropertyName("telegram_channel_user_count")]
        public int? TelegramChannelUserCount { get; set; }
    }
}
