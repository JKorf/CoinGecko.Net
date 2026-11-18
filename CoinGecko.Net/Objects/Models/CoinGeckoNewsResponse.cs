using CoinGecko.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// News Response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNewsResponse
    {
        /// <summary>
        /// ["<c>title</c>"] News article title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>url</c>"] News article URL
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>image</c>"] News article image URL
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>author</c>"] News article author
        /// </summary>
        [JsonPropertyName("author")]
        public string Author { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>posted_at</c>"] News article published timestamp in ISO 8601 format
        /// </summary>
        [JsonPropertyName("posted_at")]
        public DateTime PostedAt { get; set; }
        /// <summary>
        /// ["<c>type</c>"] News article type
        /// </summary>
        [JsonPropertyName("type")]
        public NewsArticleType Type { get; set; }
        /// <summary>
        /// ["<c>source_name</c>"] News article source name
        /// </summary>
        [JsonPropertyName("source_name")]
        public string SourceName { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>related_coin_ids</c>"] Related coin IDs
        /// </summary>
        [JsonPropertyName("related_coin_ids")]
        public string[] RelatedCoinIds { get; set; } = [];
    }
}
