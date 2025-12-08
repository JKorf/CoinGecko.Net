using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Status update
    /// </summary>
    [SerializationModel]
    public record CoinGeckoStatusUpdate
    {
        /// <summary>
        /// Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Category
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; } = string.Empty;
        /// <summary>
        /// Created time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// User name
        /// </summary>
        [JsonPropertyName("user")]
        public string User { get; set; } = string.Empty;
        /// <summary>
        /// User title
        /// </summary>
        [JsonPropertyName("user_title")]
        public string UserTitle { get; set; } = string.Empty;
        /// <summary>
        /// Is pinned
        /// </summary>
        [JsonPropertyName("pin")]
        public bool Pin { get; set; }
        /// <summary>
        /// Project info
        /// </summary>
        [JsonPropertyName("project")]
        public CoinGeckoProject? Project { get; set; }
    }

    /// <summary>
    /// Project info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoProject
    {
        /// <summary>
        /// Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Images
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoImages? Image { get; set; }
    }
}
