using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Asset exchange info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoAssetExchange
    {
        /// <summary>
        /// Exchange name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Identifier
        /// </summary>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; } = string.Empty;
        /// <summary>
        /// Has trading incentive
        /// </summary>
        [JsonPropertyName("has_trading_incentive")]
        public bool HasTradingIncentive { get; set; }
        /// <summary>
        /// Logo
        /// </summary>
        [JsonPropertyName("logo")]
        public string? Logo { get; set; }
    }
}
