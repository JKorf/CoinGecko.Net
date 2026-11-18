using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Recent Asset
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRecentAsset
    {
        /// <summary>
        /// ["<c>id</c>"] Coin ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Coin symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Coin name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>activated_at</c>"] Timestamp when coin was activated on CoinGecko
        /// </summary>
        [JsonPropertyName("activated_at")]
        public DateTime ActivatedAt { get; set; }
    }
}
