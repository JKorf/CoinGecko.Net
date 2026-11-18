using CoinGecko.Net.Enums;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Search Result Rwa
    /// </summary>
    [SerializationModel]
    public record CoinGeckoSearchResultRwa
    {
        /// <summary>
        /// ["<c>id</c>"] RWA ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] RWA name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] RWA symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>asset_type</c>"] RWA asset type
        /// </summary>
        [JsonPropertyName("asset_type")]
        public RwaAssetType AssetType { get; set; }
    }
}
