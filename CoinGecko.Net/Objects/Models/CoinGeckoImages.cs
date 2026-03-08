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
        /// ["<c>thumb</c>"] Thumbnail
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? Thumb { get; set; }
        /// <summary>
        /// ["<c>small</c>"] Small image
        /// </summary>
        [JsonPropertyName("small")]
        public string? Small { get; set; }
        /// <summary>
        /// ["<c>small_2x</c>"] Small image 2
        /// </summary>
        [JsonPropertyName("small_2x")]
        public string? Small2 { get; set; }
        /// <summary>
        /// ["<c>large</c>"] Large image
        /// </summary>
        [JsonPropertyName("large")]
        public string? Large { get; set; }
    }
}
