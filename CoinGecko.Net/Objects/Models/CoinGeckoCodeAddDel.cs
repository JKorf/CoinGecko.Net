using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Code additions/deletions
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCodeAddDel
    {
        /// <summary>
        /// ["<c>additions</c>"] Lines added
        /// </summary>
        [JsonPropertyName("additions")]
        public int? Additions { get; set; }
        /// <summary>
        /// ["<c>deletions</c>"] Lines deleted
        /// </summary>
        [JsonPropertyName("deletions")]
        public int? Deletions { get; set; }
    }
}
