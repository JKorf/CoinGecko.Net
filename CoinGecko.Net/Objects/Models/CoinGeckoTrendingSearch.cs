using CryptoExchange.Net.Converters.SystemTextJson;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Trending searches
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingSearch
    {
        /// <summary>
        /// Trending assets
        /// </summary>
        [JsonPropertyName("coins")]
        public ItemWrapper<CoinGeckoTrendingAsset>[] Assets { get; set; } = Array.Empty<ItemWrapper<CoinGeckoTrendingAsset>>();
        /// <summary>
        /// Trending NFTs
        /// </summary>
        [JsonPropertyName("nfts")]
        public CoinGeckoTrendingNft[] Nfts { get; set; } = Array.Empty<CoinGeckoTrendingNft>();
        /// <summary>
        /// Trending Categories
        /// </summary>
        [JsonPropertyName("categories")]
        public CoinGeckoTrendingCategory[] Categories { get; set; } = Array.Empty<CoinGeckoTrendingCategory>();
    }

    /// <summary>
    /// Trending asset
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingAsset
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Asset id
        /// </summary>
        [JsonPropertyName("coin_id")]
        public int AssetId { get; set; }
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
        /// Thumbnail image
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? ThumbnailImage { get; set; }
        /// <summary>
        /// Small image
        /// </summary>
        [JsonPropertyName("small")]
        public string? SmallImage { get; set; }
        /// <summary>
        /// Large image
        /// </summary>
        [JsonPropertyName("large")]
        public string? LargeImage { get; set; }
        /// <summary>
        /// Slug
        /// </summary>
        [JsonPropertyName("slug")]
        public string? Slug { get; set; }
        /// <summary>
        /// Btc price
        /// </summary>
        [JsonPropertyName("price_btc")]
        public decimal? PriceBtc { get; set; }
        /// <summary>
        /// Score
        /// </summary>
        [JsonPropertyName("score")]
        public int Score { get; set; }
    }

    /// <summary>
    /// Nft
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingNft
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
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
        /// Thumb image
        /// </summary>
        [JsonPropertyName("thumb")]
        public string Thumb { get; set; } = string.Empty;
        /// <summary>
        /// Nft contract id
        /// </summary>
        [JsonPropertyName("nft_contract_id")]
        public int NftContractId { get; set; }
        /// <summary>
        /// Native asset symbol
        /// </summary>
        [JsonPropertyName("native_currency_symbol")]
        public string NativeAssetSymbol { get; set; } = string.Empty;
        /// <summary>
        /// Floor price in native asset
        /// </summary>
        [JsonPropertyName("floor_price_in_native_currency")]
        public decimal FloorPriceInNativeAsset { get; set; }
        /// <summary>
        /// Floor price 24h percentage change
        /// </summary>
        [JsonPropertyName("floor_price_24h_percentage_change")]
        public decimal FloorPrice24hPercentageChange { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoTrendingNftData Data { get; set; } = null!;
    }

    /// <summary>
    /// Nft data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingNftData
    {
        /// <summary>
        /// Floor price
        /// </summary>
        [JsonPropertyName("floor_price")]
        public string FloorPrice { get; set; } = string.Empty;
        /// <summary>
        /// Floor price in usd 24h percentage change
        /// </summary>
        [JsonPropertyName("floor_price_in_usd_24h_percentage_change")]
        public decimal FloorPriceInUsd24hPercentageChange { get; set; }
        /// <summary>
        /// Volume 24h
        /// </summary>
        [JsonPropertyName("h24_volume")]
        public string H24Volume { get; set; } = string.Empty;
        /// <summary>
        /// Average sale price 24h
        /// </summary>
        [JsonPropertyName("h24_average_sale_price")]
        public string H24AverageSalePrice { get; set; } = string.Empty;
        /// <summary>
        /// Sparkline
        /// </summary>
        [JsonPropertyName("sparkline")]
        public string Sparkline { get; set; } = string.Empty;
    }

    /// <summary>
    /// Trending category
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingCategory
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Market cap 1 hour change
        /// </summary>
        [JsonPropertyName("market_cap_1h_change")]
        public decimal MarketCap1hChange { get; set; }
        /// <summary>
        /// Slug
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; set; } = string.Empty;
        /// <summary>
        /// Coins count
        /// </summary>
        [JsonPropertyName("coins_count")]
        public decimal CoinsCount { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoTrendingCategoryData Data { get; set; } = null!;
    }

    /// <summary>
    /// Category date
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingCategoryData
    {
        /// <summary>
        /// Market cap
        /// </summary>
        [JsonPropertyName("market_cap")]
        public decimal MarketCap { get; set; }
        /// <summary>
        /// Market cap btc
        /// </summary>
        [JsonPropertyName("market_cap_btc")]
        public decimal MarketCapBtc { get; set; }
        /// <summary>
        /// Total volume
        /// </summary>
        [JsonPropertyName("total_volume")]
        public decimal TotalVolume { get; set; }
        /// <summary>
        /// Total volume btc
        /// </summary>
        [JsonPropertyName("total_volume_btc")]
        public decimal TotalVolumeBtc { get; set; }
        /// <summary>
        /// Market cap change percentage24h
        /// </summary>
        [JsonPropertyName("market_cap_change_percentage_24h")]
        public Dictionary<string, decimal> MarketCapChangePercentage24h { get; set; } = null!;
        /// <summary>
        /// Sparkline
        /// </summary>
        [JsonPropertyName("sparkline")]
        public string Sparkline { get; set; } = string.Empty;
    }



    /// <summary>
    /// Item
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [SerializationModel]
    public record ItemWrapper<T>
    {
        /// <summary>
        /// Item info
        /// </summary>
        [JsonPropertyName("item")]
        public T Item { get; set; } = default!;
    }
}
