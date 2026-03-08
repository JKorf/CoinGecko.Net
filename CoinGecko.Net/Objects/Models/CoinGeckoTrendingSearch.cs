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
        /// ["<c>coins</c>"] Trending assets
        /// </summary>
        [JsonPropertyName("coins")]
        public ItemWrapper<CoinGeckoTrendingAsset>[] Assets { get; set; } = Array.Empty<ItemWrapper<CoinGeckoTrendingAsset>>();
        /// <summary>
        /// ["<c>nfts</c>"] Trending NFTs
        /// </summary>
        [JsonPropertyName("nfts")]
        public CoinGeckoTrendingNft[] Nfts { get; set; } = Array.Empty<CoinGeckoTrendingNft>();
        /// <summary>
        /// ["<c>categories</c>"] Trending Categories
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
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>coin_id</c>"] Asset id
        /// </summary>
        [JsonPropertyName("coin_id")]
        public int AssetId { get; set; }
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
        /// ["<c>thumb</c>"] Thumbnail image
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? ThumbnailImage { get; set; }
        /// <summary>
        /// ["<c>small</c>"] Small image
        /// </summary>
        [JsonPropertyName("small")]
        public string? SmallImage { get; set; }
        /// <summary>
        /// ["<c>large</c>"] Large image
        /// </summary>
        [JsonPropertyName("large")]
        public string? LargeImage { get; set; }
        /// <summary>
        /// ["<c>slug</c>"] Slug
        /// </summary>
        [JsonPropertyName("slug")]
        public string? Slug { get; set; }
        /// <summary>
        /// ["<c>price_btc</c>"] Btc price
        /// </summary>
        [JsonPropertyName("price_btc")]
        public decimal? PriceBtc { get; set; }
        /// <summary>
        /// ["<c>score</c>"] Score
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
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
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
        /// ["<c>thumb</c>"] Thumb image
        /// </summary>
        [JsonPropertyName("thumb")]
        public string Thumb { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>nft_contract_id</c>"] Nft contract id
        /// </summary>
        [JsonPropertyName("nft_contract_id")]
        public int? NftContractId { get; set; }
        /// <summary>
        /// ["<c>native_currency_symbol</c>"] Native asset symbol
        /// </summary>
        [JsonPropertyName("native_currency_symbol")]
        public string NativeAssetSymbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>floor_price_in_native_currency</c>"] Floor price in native asset
        /// </summary>
        [JsonPropertyName("floor_price_in_native_currency")]
        public decimal? FloorPriceInNativeAsset { get; set; }
        /// <summary>
        /// ["<c>floor_price_24h_percentage_change</c>"] Floor price 24h percentage change
        /// </summary>
        [JsonPropertyName("floor_price_24h_percentage_change")]
        public decimal? FloorPrice24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>data</c>"] Data
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
        /// ["<c>floor_price</c>"] Floor price
        /// </summary>
        [JsonPropertyName("floor_price")]
        public string FloorPrice { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>floor_price_in_usd_24h_percentage_change</c>"] Floor price in usd 24h percentage change
        /// </summary>
        [JsonPropertyName("floor_price_in_usd_24h_percentage_change")]
        public decimal? FloorPriceInUsd24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>h24_volume</c>"] Volume 24h
        /// </summary>
        [JsonPropertyName("h24_volume")]
        public string H24Volume { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>h24_average_sale_price</c>"] Average sale price 24h
        /// </summary>
        [JsonPropertyName("h24_average_sale_price")]
        public string H24AverageSalePrice { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>sparkline</c>"] Sparkline
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
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>market_cap_1h_change</c>"] Market cap 1 hour change
        /// </summary>
        [JsonPropertyName("market_cap_1h_change")]
        public decimal? MarketCap1hChange { get; set; }
        /// <summary>
        /// ["<c>slug</c>"] Slug
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>coins_count</c>"] Coins count
        /// </summary>
        [JsonPropertyName("coins_count")]
        public decimal? CoinsCount { get; set; }
        /// <summary>
        /// ["<c>data</c>"] Data
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
        /// ["<c>market_cap</c>"] Market cap
        /// </summary>
        [JsonPropertyName("market_cap")]
        public decimal? MarketCap { get; set; }
        /// <summary>
        /// ["<c>market_cap_btc</c>"] Market cap btc
        /// </summary>
        [JsonPropertyName("market_cap_btc")]
        public decimal? MarketCapBtc { get; set; }
        /// <summary>
        /// ["<c>total_volume</c>"] Total volume
        /// </summary>
        [JsonPropertyName("total_volume")]
        public decimal? TotalVolume { get; set; }
        /// <summary>
        /// ["<c>total_volume_btc</c>"] Total volume btc
        /// </summary>
        [JsonPropertyName("total_volume_btc")]
        public decimal? TotalVolumeBtc { get; set; }
        /// <summary>
        /// ["<c>market_cap_change_percentage_24h</c>"] Market cap change percentage24h
        /// </summary>
        [JsonPropertyName("market_cap_change_percentage_24h")]
        public Dictionary<string, decimal> MarketCapChangePercentage24h { get; set; } = null!;
        /// <summary>
        /// ["<c>sparkline</c>"] Sparkline
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
        /// ["<c>item</c>"] Item info
        /// </summary>
        [JsonPropertyName("item")]
        public T Item { get; set; } = default!;
    }
}
