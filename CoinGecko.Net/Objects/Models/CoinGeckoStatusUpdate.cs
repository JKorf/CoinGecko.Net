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
        /// ["<c>description</c>"] Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>category</c>"] Category
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
        /// ["<c>user</c>"] User name
        /// </summary>
        [JsonPropertyName("user")]
        public string User { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>user_title</c>"] User title
        /// </summary>
        [JsonPropertyName("user_title")]
        public string UserTitle { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>pin</c>"] Is pinned
        /// </summary>
        [JsonPropertyName("pin")]
        public bool Pin { get; set; }
        /// <summary>
        /// ["<c>project</c>"] Project info
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
        /// ["<c>type</c>"] Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>image</c>"] Images
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoImages? Image { get; set; }
    }
}
