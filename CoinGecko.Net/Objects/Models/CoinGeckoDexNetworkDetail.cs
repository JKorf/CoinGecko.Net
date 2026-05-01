using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex network details
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexNetworkDetail
    {
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// ["<c>coingecko_asset_platform_id</c>"] CoinGecko asset platform id
        /// </summary>
        [JsonPropertyName("coingecko_asset_platform_id")]
        public string? CoinGeckoAssetPlatformId { get; set; }
    }
}
