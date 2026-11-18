using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Trending Asset Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingAssetData
    {
        /// <summary>
        /// ["<c>price</c>"] Coin price in USD
        /// </summary>
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        /// <summary>
        /// ["<c>price_btc</c>"] Coin price in BTC
        /// </summary>
        [JsonPropertyName("price_btc")]
        public decimal PriceBtc { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_24h</c>"] Coin price change percentage in 24 hours by currency
        /// </summary>
        [JsonPropertyName("price_change_percentage_24h")]
        public Dictionary<string, decimal> PriceChangePercentage24h { get; set; } = new();
        /// <summary>
        /// ["<c>market_cap</c>"] Coin market cap in USD
        /// </summary>
        [JsonPropertyName("market_cap")]
        public string MarketCap { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>market_cap_btc</c>"] Coin market cap in BTC
        /// </summary>
        [JsonPropertyName("market_cap_btc")]
        public decimal MarketCapBtc { get; set; }
        /// <summary>
        /// ["<c>total_volume</c>"] Coin total volume in USD
        /// </summary>
        [JsonPropertyName("total_volume")]
        public string TotalVolume { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>total_volume_btc</c>"] Coin total volume in BTC
        /// </summary>
        [JsonPropertyName("total_volume_btc")]
        public decimal TotalVolumeBtc { get; set; }
        /// <summary>
        /// ["<c>sparkline</c>"] Coin sparkline image URL
        /// </summary>
        [JsonPropertyName("sparkline")]
        public string Sparkline { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>content</c>"] Content
        /// </summary>
        [JsonPropertyName("content")]
        public CoinGeckoTrendingAssetDataContent? Content { get; set; }
    }

    /// <summary>
    /// Trending Asset Data Content
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingAssetDataContent
    {
        /// <summary>
        /// ["<c>title</c>"] Title
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        /// <summary>
        /// ["<c>description</c>"] Description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
