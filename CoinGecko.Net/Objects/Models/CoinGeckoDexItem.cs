using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex item with attributes and relationships
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexItem<T, TRelationShip> : CoinGeckoDexItem<T>
    {
        /// <summary>
        /// ["<c>relationships</c>"] Relationships
        /// </summary>
        [JsonPropertyName("relationships")]
        public TRelationShip Details { get; set; }
    }

    /// <summary>
    /// Dex item with attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexItem<T> : CoinGeckoDexItem
    {
        /// <summary>
        /// ["<c>attributes</c>"] Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public T Details { get; set; }
    }

    /// <summary>
    /// Dex item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexItem
    {
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// ["<c>type</c>"] Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
    }
}
