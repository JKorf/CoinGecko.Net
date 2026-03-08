using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// API usage info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoApiUsage
    {
        /// <summary>
        /// ["<c>plan</c>"] Plan
        /// </summary>
        [JsonPropertyName("plan")]
        public string Plan { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>rate_limit_request_per_minute</c>"] Rate limit request per minute
        /// </summary>
        [JsonPropertyName("rate_limit_request_per_minute")]
        public long RateLimitRequestPerMinute { get; set; }
        /// <summary>
        /// ["<c>monthly_call_credit</c>"] Monthly call credit
        /// </summary>
        [JsonPropertyName("monthly_call_credit")]
        public long MonthlyCallCredit { get; set; }
        /// <summary>
        /// ["<c>current_total_monthly_calls</c>"] Current total monthly calls
        /// </summary>
        [JsonPropertyName("current_total_monthly_calls")]
        public long CurrentTotalMonthlyCalls { get; set; }
        /// <summary>
        /// ["<c>current_remaining_monthly_calls</c>"] Current remaining monthly calls
        /// </summary>
        [JsonPropertyName("current_remaining_monthly_calls")]
        public long CurrentRemainingMonthlyCalls { get; set; }
    }


}
