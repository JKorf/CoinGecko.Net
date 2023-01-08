using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// History info
    /// </summary>
    public class CoinGeckoAssetHistory
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Localization
        /// </summary>
        public Dictionary<string, string> Localization { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// Images
        /// </summary>
        [JsonProperty("image")]
        public CoinGeckoImages? Images { get; set; }
        /// <summary>
        /// Market data
        /// </summary>
        [JsonProperty("market_data")]
        public CoinGeckoMarketData? MarketData { get; set; }
        /// <summary>
        /// Community data
        /// </summary>
        [JsonProperty("community_data")]
        public CoinGeckoCommunityData? CommunityData { get; set; }
        /// <summary>
        /// Developer data
        /// </summary>
        [JsonProperty("developer_data")]
        public CoinGeckoDeveloperData? DeveloperData { get; set; }
        /// <summary>
        /// Public interest stats
        /// </summary>
        [JsonProperty("public_interest_stats")]
        public CoinGeckoPublicInterestStats? PublicInterestStats { get; set; }
    }
}
