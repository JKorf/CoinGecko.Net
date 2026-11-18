using CoinGecko.Net.Enums;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Tokenized real-world asset
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwa
    {
        /// <summary>
        /// ["<c>id</c>"] Real-world asset id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Asset symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Asset name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>asset_type</c>"] Asset type, such as stock, commodity or ETF
        /// </summary>
        [JsonPropertyName("asset_type")]
        public RwaAssetType AssetType { get; set; }
    }
}
