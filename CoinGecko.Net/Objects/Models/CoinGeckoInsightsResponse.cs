using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Insights Response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoInsightsResponse
    {
        /// <summary>
        /// ["<c>title</c>"] Insight title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>description</c>"] Insight description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>related_coin_ids</c>"] Related coin IDs
        /// </summary>
        [JsonPropertyName("related_coin_ids")]
        public string[] RelatedCoinIds { get; set; } = [];
        /// <summary>
        /// ["<c>posted_at</c>"] Insight posted timestamp in ISO 8601 format
        /// </summary>
        [JsonPropertyName("posted_at")]
        public DateTime PostedAt { get; set; }
    }
}
