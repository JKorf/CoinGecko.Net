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
        /// ["<c>forks</c>"] Forks
        /// </summary>
        [JsonPropertyName("forks")]
        public int? Forks { get; set; }
        /// <summary>
        /// ["<c>stars</c>"] Stars
        /// </summary>
        [JsonPropertyName("stars")]
        public int? Stars { get; set; }
        /// <summary>
        /// ["<c>subscribers</c>"] Subscribers
        /// </summary>
        [JsonPropertyName("subscribers")]
        public int? Subscribers { get; set; }
        /// <summary>
        /// ["<c>total_issues</c>"] Total issues
        /// </summary>
        [JsonPropertyName("total_issues")]
        public int? TotalIssues { get; set; }
        /// <summary>
        /// ["<c>closed_issues</c>"] Closed issues
        /// </summary>
        [JsonPropertyName("closed_issues")]
        public int? ClosedIssues { get; set; }
        /// <summary>
        /// ["<c>pull_requests_merged</c>"] Pull requests merged
        /// </summary>
        [JsonPropertyName("pull_requests_merged")]
        public int? PullRequestsMerged { get; set; }
        /// <summary>
        /// ["<c>pull_request_contributors</c>"] Pull request contributors
        /// </summary>
        [JsonPropertyName("pull_request_contributors")]
        public int? PullRequestContributors { get; set; }
        /// <summary>
        /// ["<c>code_additions_deletions_4_weeks</c>"] Code changes last 4 weeks
        /// </summary>
        [JsonPropertyName("code_additions_deletions_4_weeks")]
        public CoinGeckoCodeAddDel? CodeAdditionsDeletions4Weeks { get; set; }
        /// <summary>
        /// ["<c>commit_count_4_weeks</c>"] Amount of commits last 4 weeks
        /// </summary>
        [JsonPropertyName("commit_count_4_weeks")]
        public int? CommitCount4Weeks { get; set; }
        /// <summary>
        /// ["<c>last_4_weeks_commit_activity_series</c>"] Commits series last 4 weeks
        /// </summary>
        [JsonPropertyName("last_4_weeks_commit_activity_series")]
        public int[] Last4WeeksCommitActivitySeries { get; set; } = [];
    }
}
