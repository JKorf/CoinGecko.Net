using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Public company or government tracked by CoinGecko
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTreasuryEntity
    {
        /// <summary>
        /// ["<c>id</c>"] Entity id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Ticker symbol, if applicable
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Entity name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>country</c>"] Country code
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>figi</c>"] Financial Instrument Global Identifier, when available in the Pro API
        /// </summary>
        [JsonPropertyName("figi")]
        public string? Figi { get; set; }
    }
}
