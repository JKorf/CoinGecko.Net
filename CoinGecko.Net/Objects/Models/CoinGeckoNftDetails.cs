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
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>contract_address</c>"] Contract address
        /// </summary>
        [JsonPropertyName("contract_address")]
        public string ContractAddress { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>asset_platform_id</c>"] Platform id
        /// </summary>
        [JsonPropertyName("asset_platform_id")]
        public string AssetPlatformId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>market_cap_rank</c>"] Market cap rank
        /// </summary>
        [JsonPropertyName("market_cap_rank")]
        public int? MarketCapRank { get; set; }
        /// <summary>
        /// ["<c>image</c>"] Images
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoImages? Images { get; set; }
        /// <summary>
        /// ["<c>banner_image</c>"] Banner image
        /// </summary>
        [JsonPropertyName("banner_image")]
        public string? BannerImage { get; set; }
        /// <summary>
        /// ["<c>description</c>"] Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>native_currency</c>"] Native currency
        /// </summary>
        [JsonPropertyName("native_currency")]
        public string NativeCurrency { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>native_currency_symbol</c>"] Native currency symbol
        /// </summary>
        [JsonPropertyName("native_currency_symbol")]
        public string NativeCurrencySymbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>floor_price_in_usd_24h_percentage_change</c>"] Floor price 24h change percentage in USD
        /// </summary>
        [JsonPropertyName("floor_price_in_usd_24h_percentage_change")]
        public decimal? FloorPriceInUsd24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>number_of_unique_addresses</c>"] Number of unique addresses
        /// </summary>
        [JsonPropertyName("number_of_unique_addresses")]
        public decimal? NumberOfUniqueAddresses { get; set; }
        /// <summary>
        /// ["<c>number_of_unique_addresses_24h_percentage_change</c>"] Number of unique address 24h change percentage
        /// </summary>
        [JsonPropertyName("number_of_unique_addresses_24h_percentage_change")]
        public decimal? NumberOfUniqueAddresses24hChangePercentage { get; set; }
        /// <summary>
        /// ["<c>volume_in_usd_24h_percentage_change</c>"] Volume 24h change percentage in USD
        /// </summary>
        [JsonPropertyName("volume_in_usd_24h_percentage_change")]
        public decimal? VolumeInUsd24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>total_supply</c>"] Total supply
        /// </summary>
        [JsonPropertyName("total_supply")]
        public decimal? TotalSupply { get; set; }
        /// <summary>
        /// ["<c>floor_price</c>"] Floor price
        /// </summary>
        [JsonPropertyName("floor_price")]
        public CoinGeckoNftValue? FloorPrice { get; set; }
        /// <summary>
        /// ["<c>market_cap</c>"] Floor price
        /// </summary>
        [JsonPropertyName("market_cap")]
        public CoinGeckoNftValue? MarketCap { get; set; }
        /// <summary>
        /// ["<c>volume_24h</c>"] Floor price
        /// </summary>
        [JsonPropertyName("volume_24h")]
        public CoinGeckoNftValue? Volume24h { get; set; }
        /// <summary>
        /// ["<c>floor_price_24h_percentage_change</c>"] Floor price 24h percentage change
        /// </summary>
        [JsonPropertyName("floor_price_24h_percentage_change")]
        public CoinGeckoNftValue? FloorPrice24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>market_cap_24h_percentage_change</c>"] Market cap 24h percentage change
        /// </summary>
        [JsonPropertyName("market_cap_24h_percentage_change")]
        public CoinGeckoNftValue? MarketCap24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>volume_24h_percentage_change</c>"] Volume 24h percentage change
        /// </summary>
        [JsonPropertyName("volume_24h_percentage_change")]
        public CoinGeckoNftValue? Volume24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>one_day_sales</c>"] One day sales
        /// </summary>
        [JsonPropertyName("one_day_sales")]
        public decimal? OneDaySales { get; set; }
        /// <summary>
        /// ["<c>one_day_sales_24h_percentage_change</c>"] One day sales percentage change
        /// </summary>
        [JsonPropertyName("one_day_sales_24h_percentage_change")]
        public decimal? OneDaySales24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>one_day_average_sale_price</c>"] One day average sales price
        /// </summary>
        [JsonPropertyName("one_day_average_sale_price")]
        public decimal? OneDayAverageSalesPrice { get; set; }
        /// <summary>
        /// ["<c>one_day_average_sale_price_24h_percentage_change</c>"] One day sales percentage change
        /// </summary>
        [JsonPropertyName("one_day_average_sale_price_24h_percentage_change")]
        public decimal? OneDayAverageSalesPrice24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>floor_price_7d_percentage_change</c>"] Floor price 7 day percentage change
        /// </summary>
        [JsonPropertyName("floor_price_7d_percentage_change")]
        public CoinGeckoNftValue? FloorPrice7dPercentageChange { get; set; }
        /// <summary>
        /// ["<c>floor_price_14d_percentage_change</c>"] Floor price 14 day percentage change
        /// </summary>
        [JsonPropertyName("floor_price_14d_percentage_change")]
        public CoinGeckoNftValue? FloorPrice14dPercentageChange { get; set; }
        /// <summary>
        /// ["<c>floor_price_30d_percentage_change</c>"] Floor price 30 day percentage change
        /// </summary>
        [JsonPropertyName("floor_price_30d_percentage_change")]
        public CoinGeckoNftValue? FloorPrice30dPercentageChange { get; set; }
        /// <summary>
        /// ["<c>floor_price_60d_percentage_change</c>"] Floor price 60 day percentage change
        /// </summary>
        [JsonPropertyName("floor_price_60d_percentage_change")]
        public CoinGeckoNftValue? FloorPrice60dPercentageChange { get; set; }
        /// <summary>
        /// ["<c>floor_price_1y_percentage_change</c>"] Floor price 1 year percentage change
        /// </summary>
        [JsonPropertyName("floor_price_1y_percentage_change")]
        public CoinGeckoNftValue? FloorPrice1yPercentageChange { get; set; }
        /// <summary>
        /// ["<c>user_favorites_count</c>"] Nft collection user favorites count
        /// </summary>
        [JsonPropertyName("user_favorites_count")]
        public int UserFavoritesCount { get; set; }
        /// <summary>
        /// ["<c>ath</c>"] All time high price
        /// </summary>
        [JsonPropertyName("ath")]
        public CoinGeckoNftValue? AllTimeHigh { get; set; }
        /// <summary>
        /// ["<c>ath_change_percentage</c>"] All time high price change percentage
        /// </summary>
        [JsonPropertyName("ath_change_percentage")]
        public CoinGeckoNftValue? AllTimeHighChangePercentage { get; set; }
        /// <summary>
        /// ["<c>ath_date</c>"] All time high price date
        /// </summary>
        [JsonPropertyName("ath_date")]
        public CoinGeckoNftDate? AllTimeHighDate { get; set; }
        /// <summary>
        /// ["<c>links</c>"] Explorer links
        /// </summary>
        [JsonPropertyName("links")]
        public Dictionary<string, string> Links { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// ["<c>explorers</c>"] Explorer links
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
        /// ["<c>native_currency</c>"] In native currency
        /// </summary>
        [JsonPropertyName("native_currency")]
        public decimal? NativeCurrency { get; set; }
        /// <summary>
        /// ["<c>usd</c>"] In usd
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
        /// ["<c>native_currency</c>"] In native currency
        /// </summary>
        [JsonPropertyName("native_currency")]
        public DateTime? NativeCurrency { get; set; }
        /// <summary>
        /// ["<c>usd</c>"] In usd
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
        /// ["<c>name</c>"] Link name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>link</c>"] Link
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; set; } = string.Empty;
    }
}
