using CoinGecko.Net.Enums;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Derivative Underlying Market
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDerivativeUnderlyingMarket
    {
        /// <summary>
        /// ["<c>id</c>"] Underlying asset ID (coin ID or RWA ID)
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Underlying asset symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Underlying asset name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>underlying_type</c>"] Underlying asset type
        /// </summary>
        [JsonPropertyName("underlying_type")]
        public DerivativeUnderlyingType UnderlyingType { get; set; }
        /// <summary>
        /// ["<c>current_price</c>"] Underlying asset price in USD
        /// </summary>
        [JsonPropertyName("current_price")]
        public decimal CurrentPrice { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_24h</c>"] Underlying asset 24-hour price change percentage
        /// </summary>
        [JsonPropertyName("price_change_percentage_24h")]
        public decimal PriceChangePercentage24h { get; set; }
        /// <summary>
        /// ["<c>open_interest</c>"] Derivative open interest in USD
        /// </summary>
        [JsonPropertyName("open_interest")]
        public decimal? OpenInterest { get; set; }
        /// <summary>
        /// ["<c>open_interest_change_percentage_1h</c>"] Derivative 1-hour open interest change percentage
        /// </summary>
        [JsonPropertyName("open_interest_change_percentage_1h")]
        public decimal OpenInterestChangePercentage1h { get; set; }
        /// <summary>
        /// ["<c>open_interest_change_percentage_24h</c>"] Derivative 24-hour open interest change percentage
        /// </summary>
        [JsonPropertyName("open_interest_change_percentage_24h")]
        public decimal OpenInterestChangePercentage24h { get; set; }
        /// <summary>
        /// ["<c>funding_rate</c>"] Derivative funding rate
        /// </summary>
        [JsonPropertyName("funding_rate")]
        public decimal FundingRate { get; set; }
        /// <summary>
        /// ["<c>total_volume</c>"] Derivative total trading volume in USD
        /// </summary>
        [JsonPropertyName("total_volume")]
        public decimal? TotalVolume { get; set; }
    }
}
