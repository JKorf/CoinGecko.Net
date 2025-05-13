using CryptoExchange.Net.Converters.SystemTextJson;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// History info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoAssetHistory
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Localization
        /// </summary>
        [JsonPropertyName("localization")]
        public Dictionary<string, string> Localization { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// Images
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoImages? Images { get; set; }
        /// <summary>
        /// Market data
        /// </summary>
        [JsonPropertyName("market_data")]
        public CoinGeckoMarketDataBasic? MarketData { get; set; }
        /// <summary>
        /// Community data
        /// </summary>
        [JsonPropertyName("community_data")]
        public CoinGeckoCommunityData? CommunityData { get; set; }
        /// <summary>
        /// Developer data
        /// </summary>
        [JsonPropertyName("developer_data")]
        public CoinGeckoDeveloperData? DeveloperData { get; set; }
        /// <summary>
        /// Public interest stats
        /// </summary>
        [JsonPropertyName("public_interest_stats")]
        public CoinGeckoPublicInterestStats? PublicInterestStats { get; set; }
    }

    /// <summary>
    /// Basic market data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMarketDataBasic
    {
        /// <summary>
        /// Current price
        /// </summary>
        [JsonPropertyName("current_price")]
        public Dictionary<string, decimal> CurrentPrice { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Market caps
        /// </summary>
        [JsonPropertyName("market_cap")]
        public Dictionary<string, decimal> MarketCaps { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Total volumes
        /// </summary>
        [JsonPropertyName("total_volume")]
        public Dictionary<string, decimal> TotalVolumes { get; set; } = new Dictionary<string, decimal>();
    }
}
