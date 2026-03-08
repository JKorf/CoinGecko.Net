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
        /// ["<c>name</c>"] Exchange name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>identifier</c>"] Identifier
        /// </summary>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>has_trading_incentive</c>"] Has trading incentive
        /// </summary>
        [JsonPropertyName("has_trading_incentive")]
        public bool HasTradingIncentive { get; set; }
        /// <summary>
        /// ["<c>logo</c>"] Logo
        /// </summary>
        [JsonPropertyName("logo")]
        public string? Logo { get; set; }
    }
}
