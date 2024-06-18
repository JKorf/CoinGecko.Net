using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Community data
    /// </summary>
    public record CoinGeckoCommunityData
    {
        /// <summary>
        /// Facebook likes
        /// </summary>
        [JsonProperty("facebook_likes")]
        public int? FacebookLikes { get; set; }
        /// <summary>
        /// Twitter followers
        /// </summary>
        [JsonProperty("twitter_followers")]
        public int? TwitterFollowers { get; set; }
        /// <summary>
        /// Average amount of reddit posts per 48 hours
        /// </summary>
        [JsonProperty("reddit_average_posts_48h")]
        public decimal? RedditAveragePostsPer48h { get; set; }
        /// <summary>
        /// Average amount of reddit comments per 48 hours
        /// </summary>
        [JsonProperty("reddit_average_comments_48h")]
        public decimal? RedditAverageCommentsPer48h { get; set; }
        /// <summary>
        /// Reddit subscribers
        /// </summary>
        [JsonProperty("reddit_subscribers")]
        public int? RedditSubscribers { get; set; }
        /// <summary>
        /// Active reddit subscribers last 48 hours
        /// </summary>
        [JsonProperty("reddit_accounts_active_48h")]
        public decimal? RedditActiveAccounts48h { get; set; }
        /// <summary>
        /// Telegram channel user count
        /// </summary>
        [JsonProperty("telegram_channel_user_count")]
        public int? TelegramChannelUserCount { get; set; }
    }
}
