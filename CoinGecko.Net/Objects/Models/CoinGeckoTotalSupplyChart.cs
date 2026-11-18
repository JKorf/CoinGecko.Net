using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Total Supply Chart
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTotalSupplyChart
    {
        /// <summary>
        /// ["<c>total_supply</c>"] Total supply data points as [timestamp, supply] pairs
        /// </summary>
        [JsonPropertyName("total_supply")]
        public CoinGeckoMarketChartValue[] TotalSupply { get; set; } = [];
    }
}
