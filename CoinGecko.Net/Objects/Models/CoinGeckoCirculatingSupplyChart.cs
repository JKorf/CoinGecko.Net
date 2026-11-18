using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Circulating Supply Chart
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCirculatingSupplyChart
    {
        /// <summary>
        /// ["<c>circulating_supply</c>"] Circulating supply data points as [timestamp, supply] pairs
        /// </summary>
        [JsonPropertyName("circulating_supply")]
        public CoinGeckoMarketChartValue[] CirculatingSupply { get; set; } = [];
    }
}
