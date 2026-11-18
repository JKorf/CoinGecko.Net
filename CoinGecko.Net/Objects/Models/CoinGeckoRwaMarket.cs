using CoinGecko.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Rwa Market
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaMarket
    {
        /// <summary>
        /// ["<c>id</c>"] RWA ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] RWA symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] RWA name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>asset_type</c>"] RWA asset type
        /// </summary>
        [JsonPropertyName("asset_type")]
        public RwaAssetType AssetType { get; set; }
        /// <summary>
        /// ["<c>image</c>"] Large image URL of the token with the largest market cap
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>tokenized_market_data</c>"] Aggregated tokenized market data
        /// </summary>
        [JsonPropertyName("tokenized_market_data")]
        public CoinGeckoRwaMarketTokenizedMarketData? TokenizedMarketData { get; set; }
    }

    /// <summary>
    /// Rwa Market Tokenized Market Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaMarketTokenizedMarketData
    {
        /// <summary>
        /// ["<c>current_price</c>"] Current price in target currency
        /// </summary>
        [JsonPropertyName("current_price")]
        public decimal? CurrentPrice { get; set; }
        /// <summary>
        /// ["<c>market_cap</c>"] Market cap in target currency
        /// </summary>
        [JsonPropertyName("market_cap")]
        public decimal? MarketCap { get; set; }
        /// <summary>
        /// ["<c>total_volume</c>"] Total trading volume in target currency
        /// </summary>
        [JsonPropertyName("total_volume")]
        public decimal? TotalVolume { get; set; }
        /// <summary>
        /// ["<c>high_24h</c>"] 24-hour price high in target currency
        /// </summary>
        [JsonPropertyName("high_24h")]
        public decimal? High24h { get; set; }
        /// <summary>
        /// ["<c>low_24h</c>"] 24-hour price low in target currency
        /// </summary>
        [JsonPropertyName("low_24h")]
        public decimal? Low24h { get; set; }
        /// <summary>
        /// ["<c>price_change_24h</c>"] 24-hour price change in target currency
        /// </summary>
        [JsonPropertyName("price_change_24h")]
        public decimal? PriceChange24h { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_24h</c>"] 24-hour price change percentage
        /// </summary>
        [JsonPropertyName("price_change_percentage_24h")]
        public decimal? PriceChangePercentage24h { get; set; }
        /// <summary>
        /// ["<c>market_cap_change_24h</c>"] 24-hour market cap change in target currency
        /// </summary>
        [JsonPropertyName("market_cap_change_24h")]
        public decimal? MarketCapChange24h { get; set; }
        /// <summary>
        /// ["<c>market_cap_change_percentage_24h</c>"] 24-hour market cap change percentage
        /// </summary>
        [JsonPropertyName("market_cap_change_percentage_24h")]
        public decimal? MarketCapChangePercentage24h { get; set; }
        /// <summary>
        /// ["<c>last_updated</c>"] Last updated timestamp
        /// </summary>
        [JsonPropertyName("last_updated")]
        public DateTime? LastUpdated { get; set; }
        /// <summary>
        /// ["<c>sparkline_in_7d</c>"] Sparkline price data for the last 7 days
        /// </summary>
        [JsonPropertyName("sparkline_in_7d")]
        public CoinGeckoSparkline? SparklineIn7d { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_1h_in_currency</c>"] 1-hour price change percentage in target currency
        /// </summary>
        [JsonPropertyName("price_change_percentage_1h_in_currency")]
        public decimal? PriceChangePercentage1hInCurrency { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_24h_in_currency</c>"] 24-hour price change percentage in target currency
        /// </summary>
        [JsonPropertyName("price_change_percentage_24h_in_currency")]
        public decimal? PriceChangePercentage24hInCurrency { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_7d_in_currency</c>"] 7-day price change percentage in target currency
        /// </summary>
        [JsonPropertyName("price_change_percentage_7d_in_currency")]
        public decimal? PriceChangePercentage7dInCurrency { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_14d_in_currency</c>"] 14-day price change percentage in target currency
        /// </summary>
        [JsonPropertyName("price_change_percentage_14d_in_currency")]
        public decimal? PriceChangePercentage14dInCurrency { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_30d_in_currency</c>"] 30-day price change percentage in target currency
        /// </summary>
        [JsonPropertyName("price_change_percentage_30d_in_currency")]
        public decimal? PriceChangePercentage30dInCurrency { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_200d_in_currency</c>"] 200-day price change percentage in target currency
        /// </summary>
        [JsonPropertyName("price_change_percentage_200d_in_currency")]
        public decimal? PriceChangePercentage200dInCurrency { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_1y_in_currency</c>"] 1-year price change percentage in target currency
        /// </summary>
        [JsonPropertyName("price_change_percentage_1y_in_currency")]
        public decimal? PriceChangePercentage1yInCurrency { get; set; }
    }
}
