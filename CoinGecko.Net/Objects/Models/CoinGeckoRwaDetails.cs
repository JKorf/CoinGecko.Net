using CoinGecko.Net.Enums;
using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Rwa Details
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaDetails
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
        /// ["<c>image</c>"] Image URLs of one of the RWA's tokens
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoRwaDetailsImage Image { get; set; } = new();
        /// <summary>
        /// ["<c>web_slug</c>"] RWA web slug
        /// </summary>
        [JsonPropertyName("web_slug")]
        public string WebSlug { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>tokens</c>"] Tokens tracking this RWA
        /// </summary>
        [JsonPropertyName("tokens")]
        public CoinGeckoRwaDetailsToken[]? Tokens { get; set; }
        /// <summary>
        /// ["<c>tokenized_market_data</c>"] Aggregated tokenized market data
        /// </summary>
        [JsonPropertyName("tokenized_market_data")]
        public CoinGeckoRwaDetailsTokenizedMarketData? TokenizedMarketData { get; set; }
        /// <summary>
        /// ["<c>perps_market_data</c>"] Aggregated perpetuals market data
        /// </summary>
        [JsonPropertyName("perps_market_data")]
        public CoinGeckoRwaDetailsTokenPerpsMarketData? PerpsMarketData { get; set; }
        /// <summary>
        /// ["<c>last_updated</c>"] Last updated timestamp
        /// </summary>
        [JsonPropertyName("last_updated")]
        public DateTime LastUpdated { get; set; }
    }

    /// <summary>
    /// Rwa Details Image
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaDetailsImage
    {
        /// <summary>
        /// ["<c>thumb</c>"] Thumbnail image URL
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? Thumb { get; set; }
        /// <summary>
        /// ["<c>small</c>"] Small image URL
        /// </summary>
        [JsonPropertyName("small")]
        public string? Small { get; set; }
        /// <summary>
        /// ["<c>large</c>"] Large image URL
        /// </summary>
        [JsonPropertyName("large")]
        public string? Large { get; set; }
    }

    /// <summary>
    /// Rwa Details Token
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaDetailsToken
    {
        /// <summary>
        /// ["<c>id</c>"] Token ID
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        /// <summary>
        /// ["<c>symbol</c>"] Token symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
        /// <summary>
        /// ["<c>name</c>"] Token name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// ["<c>platforms</c>"] Token asset platform and contract address
        /// </summary>
        [JsonPropertyName("platforms")]
        public Dictionary<string, string>? Platforms { get; set; }
        /// <summary>
        /// ["<c>issuer_details</c>"] Token issuer details
        /// </summary>
        [JsonPropertyName("issuer_details")]
        public CoinGeckoRwaDetailsTokenIssuerDetails? IssuerDetails { get; set; }
        /// <summary>
        /// ["<c>perps_market_data</c>"] Perpetuals market data of the token
        /// </summary>
        [JsonPropertyName("perps_market_data")]
        public CoinGeckoRwaDetailsTokenPerpsMarketData? PerpsMarketData { get; set; }
    }

    /// <summary>
    /// Rwa Details Token Issuer Details
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaDetailsTokenIssuerDetails
    {
        /// <summary>
        /// ["<c>id</c>"] Issuer ID
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        /// <summary>
        /// ["<c>name</c>"] Issuer name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    /// <summary>
    /// Rwa Details Token Perps Market Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaDetailsTokenPerpsMarketData
    {
        /// <summary>
        /// ["<c>volume_24h</c>"] 24-hour perpetuals trading volume in target currency
        /// </summary>
        [JsonPropertyName("volume_24h")]
        public decimal? Volume24h { get; set; }
        /// <summary>
        /// ["<c>open_interest_24h</c>"] 24-hour perpetuals open interest in target currency
        /// </summary>
        [JsonPropertyName("open_interest_24h")]
        public decimal? OpenInterest24h { get; set; }
    }

    /// <summary>
    /// Rwa Details Tokenized Market Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaDetailsTokenizedMarketData
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
