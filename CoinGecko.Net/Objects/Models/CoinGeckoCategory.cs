using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Category
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCategory
    {
        /// <summary>
        /// ["<c>category_id</c>"] Category id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Category name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
