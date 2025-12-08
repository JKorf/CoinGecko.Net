using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Nft info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNftDetails
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Contract address
        /// </summary>
        [JsonPropertyName("contract_address")]
        public string ContractAddress { get; set; } = string.Empty;
        /// <summary>
        /// Platform id
        /// </summary>
        [JsonPropertyName("asset_platform_id")]
        public string AssetPlatformId { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Market cap rank
        /// </summary>
        [JsonPropertyName("market_cap_rank")]
        public int? MarketCapRank { get; set; }
        /// <summary>
        /// Images
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoImages? Images { get; set; }
        /// <summary>
        /// Banner image
        /// </summary>
        [JsonPropertyName("banner_image")]
        public string? BannerImage { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Native currency
        /// </summary>
        [JsonPropertyName("native_currency")]
        public string NativeCurrency { get; set; } = string.Empty;
        /// <summary>
        /// Native currency symbol
        /// </summary>
        [JsonPropertyName("native_currency_symbol")]
        public string NativeCurrencySymbol { get; set; } = string.Empty;
        /// <summary>
        /// Floor price 24h change percentage in USD
        /// </summary>
        [JsonPropertyName("floor_price_in_usd_24h_percentage_change")]
        public decimal? FloorPriceInUsd24hPercentageChange { get; set; }
        /// <summary>
        /// Number of unique addresses
        /// </summary>
        [JsonPropertyName("number_of_unique_addresses")]
        public decimal? NumberOfUniqueAddresses { get; set; }
        /// <summary>
        /// Number of unique address 24h change percentage
        /// </summary>
        [JsonPropertyName("number_of_unique_addresses_24h_percentage_change")]
        public decimal? NumberOfUniqueAddresses24hChangePercentage { get; set; }
        /// <summary>
        /// Volume 24h change percentage in USD
        /// </summary>
        [JsonPropertyName("volume_in_usd_24h_percentage_change")]
        public decimal? VolumeInUsd24hPercentageChange { get; set; }
        /// <summary>
        /// Total supply
        /// </summary>
        [JsonPropertyName("total_supply")]
        public decimal TotalSupply { get; set; }
        /// <summary>
        /// Floor price
        /// </summary>
        [JsonPropertyName("floor_price")]
        public CoinGeckoNftValue? FloorPrice { get; set; }
        /// <summary>
        /// Floor price
        /// </summary>
        [JsonPropertyName("market_cap")]
        public CoinGeckoNftValue? MarketCap { get; set; }
        /// <summary>
        /// Floor price
        /// </summary>
        [JsonPropertyName("volume_24h")]
        public CoinGeckoNftValue? Volume24h { get; set; }
        /// <summary>
        /// Floor price 24h percentage change
        /// </summary>
        [JsonPropertyName("floor_price_24h_percentage_change")]
        public CoinGeckoNftValue? FloorPrice24hPercentageChange { get; set; }
        /// <summary>
        /// Market cap 24h percentage change
        /// </summary>
        [JsonPropertyName("market_cap_24h_percentage_change")]
        public CoinGeckoNftValue? MarketCap24hPercentageChange { get; set; }
        /// <summary>
        /// Volume 24h percentage change
        /// </summary>
        [JsonPropertyName("volume_24h_percentage_change")]
        public CoinGeckoNftValue? Volume24hPercentageChange { get; set; }
        /// <summary>
        /// One day sales
        /// </summary>
        [JsonPropertyName("one_day_sales")]
        public decimal OneDaySales { get; set; }
        /// <summary>
        /// One day sales percentage change
        /// </summary>
        [JsonPropertyName("one_day_sales_24h_percentage_change")]
        public decimal OneDaySales24hPercentageChange { get; set; }
        /// <summary>
        /// One day average sales price
        /// </summary>
        [JsonPropertyName("one_day_average_sale_price")]
        public decimal OneDayAverageSalesPrice { get; set; }
        /// <summary>
        /// One day sales percentage change
        /// </summary>
        [JsonPropertyName("one_day_average_sale_price_24h_percentage_change")]
        public decimal OneDayAverageSalesPrice24hPercentageChange { get; set; }
        /// <summary>
        /// Floor price 7 day percentage change
        /// </summary>
        [JsonPropertyName("floor_price_7d_percentage_change")]
        public CoinGeckoNftValue? FloorPrice7dPercentageChange { get; set; }
        /// <summary>
        /// Floor price 14 day percentage change
        /// </summary>
        [JsonPropertyName("floor_price_14d_percentage_change")]
        public CoinGeckoNftValue? FloorPrice14dPercentageChange { get; set; }
        /// <summary>
        /// Floor price 30 day percentage change
        /// </summary>
        [JsonPropertyName("floor_price_30d_percentage_change")]
        public CoinGeckoNftValue? FloorPrice30dPercentageChange { get; set; }
        /// <summary>
        /// Floor price 60 day percentage change
        /// </summary>
        [JsonPropertyName("floor_price_60d_percentage_change")]
        public CoinGeckoNftValue? FloorPrice60dPercentageChange { get; set; }
        /// <summary>
        /// Floor price 1 year percentage change
        /// </summary>
        [JsonPropertyName("floor_price_1y_percentage_change")]
        public CoinGeckoNftValue? FloorPrice1yPercentageChange { get; set; }
        /// <summary>
        /// Nft collection user favorites count
        /// </summary>
        [JsonPropertyName("user_favorites_count")]
        public int UserFavoritesCount { get; set; }
        /// <summary>
        /// All time high price
        /// </summary>
        [JsonPropertyName("ath")]
        public CoinGeckoNftValue? AllTimeHigh { get; set; }
        /// <summary>
        /// All time high price change percentage
        /// </summary>
        [JsonPropertyName("ath_change_percentage")]
        public CoinGeckoNftValue? AllTimeHighChangePercentage { get; set; }
        /// <summary>
        /// All time high price date
        /// </summary>
        [JsonPropertyName("ath_date")]
        public CoinGeckoNftDate? AllTimeHighDate { get; set; }
        /// <summary>
        /// Explorer links
        /// </summary>
        [JsonPropertyName("links")]
        public Dictionary<string, string> Links { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// Explorer links
        /// </summary>
        [JsonPropertyName("explorers")]
        public CoinGeckoNftLink[] Explorers { get; set; } = Array.Empty<CoinGeckoNftLink>();
    }

    /// <summary>
    /// Nft value info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNftValue
    {
        /// <summary>
        /// In native currency
        /// </summary>
        [JsonPropertyName("native_currency")]
        public decimal? NativeCurrency { get; set; }
        /// <summary>
        /// In usd
        /// </summary>
        [JsonPropertyName("usd")]
        public decimal? Usd { get; set; }
    }

    /// <summary>
    /// Nft value info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNftDate
    {
        /// <summary>
        /// In native currency
        /// </summary>
        [JsonPropertyName("native_currency")]
        public DateTime? NativeCurrency { get; set; }
        /// <summary>
        /// In usd
        /// </summary>
        [JsonPropertyName("usd")]
        public DateTime? Usd { get; set; }
    }

    /// <summary>
    /// Nft value info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNftLink
    {
        /// <summary>
        /// Link name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Link
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; set; } = string.Empty;
    }
}
