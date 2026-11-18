using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Public Treasury Entity Chart
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPublicTreasuryEntityChart
    {
        /// <summary>
        /// ["<c>holdings</c>"] Historical holdings data as [timestamp, amount] pairs
        /// </summary>
        [JsonPropertyName("holdings")]
        public CoinGeckoMarketChartValue[] Holdings { get; set; } = [];
        /// <summary>
        /// ["<c>holding_value_in_usd</c>"] Historical holdings value in USD as [timestamp, value_usd] pairs
        /// </summary>
        [JsonPropertyName("holding_value_in_usd")]
        public CoinGeckoMarketChartValue[] HoldingValueInUsd { get; set; } = [];
    }
}
