using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Image links
    /// </summary>
    [SerializationModel]
    public record CoinGeckoImages
    {
        /// <summary>
        /// Thumbnail
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? Thumb { get; set; }
        /// <summary>
        /// Small image
        /// </summary>
        [JsonPropertyName("small")]
        public string? Small { get; set; }
        /// <summary>
        /// Small image 2
        /// </summary>
        [JsonPropertyName("small_2x")]
        public string? Small2 { get; set; }
        /// <summary>
        /// Large image
        /// </summary>
        [JsonPropertyName("large")]
        public string? Large { get; set; }
    }
}
