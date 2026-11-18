using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Global Market Cap Chart
    /// </summary>
    [SerializationModel]
    public record CoinGeckoGlobalMarketCapChart
    {
        /// <summary>
        /// ["<c>market_cap_chart</c>"] MarketCapChart
        /// </summary>
        [JsonPropertyName("market_cap_chart")]
        public CoinGeckoGlobalMarketCapChartMarketCapChart MarketCapChart { get; set; } = new();
    }

    /// <summary>
    /// Global Market Cap Chart Market Cap Chart
    /// </summary>
    [SerializationModel]
    public record CoinGeckoGlobalMarketCapChartMarketCapChart
    {
        /// <summary>
        /// ["<c>market_cap</c>"] Market cap data as [timestamp, market_cap] pairs
        /// </summary>
        [JsonPropertyName("market_cap")]
        public CoinGeckoMarketChartValue[] MarketCap { get; set; } = [];
        /// <summary>
        /// ["<c>volume</c>"] Volume data as [timestamp, volume] pairs
        /// </summary>
        [JsonPropertyName("volume")]
        public CoinGeckoMarketChartValue[] Volume { get; set; } = [];
    }
}
