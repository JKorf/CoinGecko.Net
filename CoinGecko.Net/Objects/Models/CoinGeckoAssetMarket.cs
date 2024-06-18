using Newtonsoft.Json;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Asset market info
    /// </summary>
    public record CoinGeckoAssetMarket
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Identifier
        /// </summary>
        public string Identifier { get; set; } = string.Empty;
        /// <summary>
        /// Has trading incentive
        /// </summary>
        [JsonProperty("has_trading_incentive")]
        public bool HasTradingIncentive { get; set; }
    }
}