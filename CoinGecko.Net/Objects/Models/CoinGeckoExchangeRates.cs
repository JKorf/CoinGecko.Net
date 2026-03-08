using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Exchange rates
    /// </summary>
    [SerializationModel]
    public record CoinGeckoExchangeRates
    {
        /// <summary>
        /// ["<c>rates</c>"] Rates dictionary
        /// </summary>
        [JsonPropertyName("rates")]
        public Dictionary<string, CoinGeckoExchangeRate> Rates { get; set; } = new Dictionary<string, CoinGeckoExchangeRate>();
    }

    /// <summary>
    /// Exchange rate
    /// </summary>
    [SerializationModel]
    public record CoinGeckoExchangeRate
    {
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>unit</c>"] Unit
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>value</c>"] Value
        /// </summary>
        [JsonPropertyName("value")]
        public decimal? Value { get; set; }
        /// <summary>
        /// ["<c>type</c>"] Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
    }
}
