using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Rwa Market Chart
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaMarketChart
    {
        /// <summary>
        /// ["<c>tokenized_prices</c>"] Tokenized price data points as [timestamp, price] pairs
        /// </summary>
        [JsonPropertyName("tokenized_prices")]
        public CoinGeckoMarketChartValue[] TokenizedPrices { get; set; } = [];
        /// <summary>
        /// ["<c>tokenized_market_caps</c>"] Tokenized market cap data points as [timestamp, market_cap] pairs
        /// </summary>
        [JsonPropertyName("tokenized_market_caps")]
        public CoinGeckoMarketChartValue[] TokenizedMarketCaps { get; set; } = [];
        /// <summary>
        /// ["<c>tokenized_total_volumes</c>"] Tokenized total volume data points as [timestamp, volume] pairs
        /// </summary>
        [JsonPropertyName("tokenized_total_volumes")]
        public CoinGeckoMarketChartValue[] TokenizedTotalVolumes { get; set; } = [];
    }
}
