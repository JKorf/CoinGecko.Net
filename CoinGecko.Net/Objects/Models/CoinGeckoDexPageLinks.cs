using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex pagination links
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPageLinks
    {
        /// <summary>
        /// ["<c>first</c>"] First page link
        /// </summary>
        [JsonPropertyName("first")]
        public string First { get; set; } = string.Empty;

        /// <summary>
        /// ["<c>last</c>"] Last page link
        /// </summary>
        [JsonPropertyName("last")]
        public string Last { get; set; } = string.Empty;

        /// <summary>
        /// ["<c>prev</c>"] Previous page link
        /// </summary>
        [JsonPropertyName("prev")]
        public string? Prev { get; set; }

        /// <summary>
        /// ["<c>next</c>"] Next page link
        /// </summary>
        [JsonPropertyName("next")]
        public string? Next { get; set; }
    }
}
