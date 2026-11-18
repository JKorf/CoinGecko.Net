using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex Exchanges Response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexExchangesResponse
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoDexExchangesResponseData[] Data { get; set; } = [];
    }

    /// <summary>
    /// Dex Exchanges Response Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexExchangesResponseData
    {
        /// <summary>
        /// ["<c>id</c>"] DEX identifier
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>type</c>"] Resource type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>attributes</c>"] Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public CoinGeckoDexExchangesResponseDataAttributes Attributes { get; set; } = new();
    }

    /// <summary>
    /// Dex Exchanges Response Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexExchangesResponseDataAttributes
    {
        /// <summary>
        /// ["<c>name</c>"] DEX name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
