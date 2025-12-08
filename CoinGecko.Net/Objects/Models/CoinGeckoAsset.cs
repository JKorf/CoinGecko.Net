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
        /// Id of the asset
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Symbol of the asset
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Name of the asset
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Asset platform and contract address
        /// </summary>
        [JsonPropertyName("platforms")]
        public Dictionary<string, string>? Platforms { get; set; }
    }
}
