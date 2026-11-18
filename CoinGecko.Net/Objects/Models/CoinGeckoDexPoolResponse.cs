using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex Pool Response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolResponse
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoPoolAddressItem Data { get; set; } = new();
        /// <summary>
        /// ["<c>included</c>"] Included related resources, present when include parameter is specified
        /// </summary>
        [JsonPropertyName("included")]
        public CoinGeckoDexPoolResponseIncludedItem[]? Included { get; set; }
    }

    /// <summary>
    /// Dex Pool Response Included Item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolResponseIncludedItem
    {
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        /// <summary>
        /// ["<c>type</c>"] Type
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// ["<c>attributes</c>"] Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public CoinGeckoDexPoolResponseIncludedItemAttributes? Attributes { get; set; }
    }

    /// <summary>
    /// Dex Pool Response Included Item Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolResponseIncludedItemAttributes
    {
        /// <summary>
        /// ["<c>address</c>"] Address
        /// </summary>
        [JsonPropertyName("address")]
        public string? Address { get; set; }
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
        /// <summary>
        /// ["<c>decimals</c>"] Decimals
        /// </summary>
        [JsonPropertyName("decimals")]
        public long? Decimals { get; set; }
        /// <summary>
        /// ["<c>image_url</c>"] ImageUrl
        /// </summary>
        [JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }
        /// <summary>
        /// ["<c>coingecko_coin_id</c>"] CoingeckoCoinId
        /// </summary>
        [JsonPropertyName("coingecko_coin_id")]
        public string? CoingeckoCoinId { get; set; }
    }
}
