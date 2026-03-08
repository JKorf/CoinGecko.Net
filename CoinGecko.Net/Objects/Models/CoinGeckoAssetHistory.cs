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
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>localization</c>"] Localization
        /// </summary>
        [JsonPropertyName("localization")]
        public Dictionary<string, string> Localization { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// ["<c>image</c>"] Images
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoImages? Images { get; set; }
        /// <summary>
        /// ["<c>market_data</c>"] Market data
        /// </summary>
        [JsonPropertyName("market_data")]
        public CoinGeckoMarketDataBasic? MarketData { get; set; }
        /// <summary>
        /// ["<c>community_data</c>"] Community data
        /// </summary>
        [JsonPropertyName("community_data")]
        public CoinGeckoCommunityData? CommunityData { get; set; }
        /// <summary>
        /// ["<c>developer_data</c>"] Developer data
        /// </summary>
        [JsonPropertyName("developer_data")]
        public CoinGeckoDeveloperData? DeveloperData { get; set; }
        /// <summary>
        /// ["<c>public_interest_stats</c>"] Public interest stats
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
        /// ["<c>current_price</c>"] Current price
        /// </summary>
        [JsonPropertyName("current_price")]
        public Dictionary<string, decimal?> CurrentPrice { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>market_cap</c>"] Market caps
        /// </summary>
        [JsonPropertyName("market_cap")]
        public Dictionary<string, decimal?> MarketCaps { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>total_volume</c>"] Total volumes
        /// </summary>
        [JsonPropertyName("total_volume")]
        public Dictionary<string, decimal?> TotalVolumes { get; set; } = new Dictionary<string, decimal?>();
    }
}
