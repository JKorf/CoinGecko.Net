using CryptoExchange.Net.Converters.SystemTextJson;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Developer data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDeveloperData
    {
        /// <summary>
        /// Forks
        /// </summary>
        [JsonPropertyName("forks")]
        public int? Forks { get; set; }
        /// <summary>
        /// Stars
        /// </summary>
        [JsonPropertyName("stars")]
        public int? Stars { get; set; }
        /// <summary>
        /// Subscribers
        /// </summary>
        [JsonPropertyName("subscribers")]
        public int? Subscribers { get; set; }
        /// <summary>
        /// Total issues
        /// </summary>
        [JsonPropertyName("total_issues")]
        public int? TotalIssues { get; set; }
        /// <summary>
        /// Closed issues
        /// </summary>
        [JsonPropertyName("closed_issues")]
        public int? ClosedIssues { get; set; }
        /// <summary>
        /// Pull requests merged
        /// </summary>
        [JsonPropertyName("pull_requests_merged")]
        public int? PullRequestsMerged { get; set; }
        /// <summary>
        /// Pull request contributors
        /// </summary>
        [JsonPropertyName("pull_request_contributors")]
        public int? PullRequestContributors { get; set; }
        /// <summary>
        /// Code changes last 4 weeks
        /// </summary>
        [JsonPropertyName("code_additions_deletions_4_weeks")]
        public CoinGeckoCodeAddDel? CodeAdditionsDeletions4Weeks { get; set; }
        /// <summary>
        /// Amount of commits last 4 weeks
        /// </summary>
        [JsonPropertyName("commit_count_4_weeks")]
        public int? CommitCount4Weeks { get; set; }
        /// <summary>
        /// Commits series last 4 weeks
        /// </summary>
        [JsonPropertyName("last_4_weeks_commit_activity_series")]
        public int[] Last4WeeksCommitActivitySeries { get; set; } = [];
    }
}
