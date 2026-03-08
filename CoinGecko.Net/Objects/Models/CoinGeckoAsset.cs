using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Asset info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoAsset
    {
        /// <summary>
        /// ["<c>id</c>"] Id of the asset
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Symbol of the asset
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Name of the asset
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>platforms</c>"] Asset platform and contract address
        /// </summary>
        [JsonPropertyName("platforms")]
        public Dictionary<string, string>? Platforms { get; set; }
    }
}
