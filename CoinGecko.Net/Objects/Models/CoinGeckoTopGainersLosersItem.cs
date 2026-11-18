using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Top Gainers Losers Item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTopGainersLosersItem
    {
        /// <summary>
        /// ["<c>id</c>"] Coin ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Coin symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Coin name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>image</c>"] Coin image URL
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>market_cap_rank</c>"] Coin market cap rank
        /// </summary>
        [JsonPropertyName("market_cap_rank")]
        public long? MarketCapRank { get; set; }
        /// <summary>
        /// ["<c>usd</c>"] Coin price in the target currency
        /// </summary>
        [JsonPropertyName("usd")]
        public decimal Usd { get; set; }
        /// <summary>
        /// ["<c>usd_24h_vol</c>"] 24-hour trading volume in the target currency
        /// </summary>
        [JsonPropertyName("usd_24h_vol")]
        public decimal Usd24hVol { get; set; }
        /// <summary>
        /// ["<c>usd_24h_change</c>"] 24-hour price change percentage
        /// </summary>
        [JsonPropertyName("usd_24h_change")]
        public decimal? Usd24hChange { get; set; }
        /// <summary>
        /// ["<c>usd_1h_change</c>"] 1-hour price change percentage
        /// </summary>
        [JsonPropertyName("usd_1h_change")]
        public decimal? Usd1hChange { get; set; }
        /// <summary>
        /// ["<c>usd_7d_change</c>"] 7-day price change percentage
        /// </summary>
        [JsonPropertyName("usd_7d_change")]
        public decimal? Usd7dChange { get; set; }
        /// <summary>
        /// ["<c>usd_14d_change</c>"] 14-day price change percentage
        /// </summary>
        [JsonPropertyName("usd_14d_change")]
        public decimal? Usd14dChange { get; set; }
        /// <summary>
        /// ["<c>usd_30d_change</c>"] 30-day price change percentage
        /// </summary>
        [JsonPropertyName("usd_30d_change")]
        public decimal? Usd30dChange { get; set; }
        /// <summary>
        /// ["<c>usd_60d_change</c>"] 60-day price change percentage
        /// </summary>
        [JsonPropertyName("usd_60d_change")]
        public decimal? Usd60dChange { get; set; }
        /// <summary>
        /// ["<c>usd_200d_change</c>"] 200-day price change percentage
        /// </summary>
        [JsonPropertyName("usd_200d_change")]
        public decimal? Usd200dChange { get; set; }
        /// <summary>
        /// ["<c>usd_1y_change</c>"] 1-year price change percentage
        /// </summary>
        [JsonPropertyName("usd_1y_change")]
        public decimal? Usd1yChange { get; set; }
    }
}
