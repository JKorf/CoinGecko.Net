using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Developer data
    /// </summary>
    public record CoinGeckoDeveloperData
    {
        /// <summary>
        /// Forks
        /// </summary>
        public int? Forks { get; set; }
        /// <summary>
        /// Stars
        /// </summary>
        public int? Stars { get; set; }
        /// <summary>
        /// Subscribers
        /// </summary>
        public int? Subscribers { get; set; }
        /// <summary>
        /// Total issues
        /// </summary>
        [JsonProperty("total_issues")]
        public int? TotalIssues { get; set; }
        /// <summary>
        /// Closed issues
        /// </summary>
        [JsonProperty("closed_issues")]
        public int? ClosedIssues { get; set; }
        /// <summary>
        /// Pull requests merged
        /// </summary>
        [JsonProperty("pull_requests_merged")]
        public int? PullRequestsMerged { get; set; }
        /// <summary>
        /// Pull request contributors
        /// </summary>
        [JsonProperty("pull_request_contributors")]
        public int? PullRequestContributors { get; set; }
        /// <summary>
        /// Code changes last 4 weeks
        /// </summary>
        [JsonProperty("code_additions_deletions_4_weeks")]
        public CoinGeckoCodeAddDel? CodeAdditionsDeletions4Weeks { get; set; }
        /// <summary>
        /// Amount of commits last 4 weeks
        /// </summary>
        [JsonProperty("commit_count_4_weeks")]
        public int? CommitCount4Weeks { get; set; }
        /// <summary>
        /// Commits series last 4 weeks
        /// </summary>
        [JsonProperty("last_4_weeks_commit_activity_series")]
        public IEnumerable<int> Last4WeeksCommitActivitySeries { get; set; } = new List<int>();
    }
}
