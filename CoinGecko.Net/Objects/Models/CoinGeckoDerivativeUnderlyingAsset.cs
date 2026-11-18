using CoinGecko.Net.Enums;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Underlying asset for a derivative
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDerivativeUnderlyingAsset
    {
        /// <summary>
        /// ["<c>id</c>"] Coin or real-world asset id
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
        /// ["<c>underlying_type</c>"] Underlying asset type
        /// </summary>
        [JsonPropertyName("underlying_type")]
        public DerivativeUnderlyingType UnderlyingType { get; set; }
    }
}
