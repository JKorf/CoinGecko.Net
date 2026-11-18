using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Trending Search Pools
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingSearchPools
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoTrendingSearchPoolsData[] Data { get; set; } = [];
        /// <summary>
        /// ["<c>included</c>"] Included related resources, present when include parameter is specified
        /// </summary>
        [JsonPropertyName("included")]
        public CoinGeckoTrendingSearchPoolsIncludedItem[]? Included { get; set; }
    }

    /// <summary>
    /// Trending Search Pools Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingSearchPoolsData
    {
        /// <summary>
        /// ["<c>id</c>"] Pool identifier
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>type</c>"] Resource type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>attributes</c>"] Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public CoinGeckoTrendingSearchPoolsDataAttributes Attributes { get; set; } = new();
        /// <summary>
        /// ["<c>relationships</c>"] Related resources
        /// </summary>
        [JsonPropertyName("relationships")]
        public CoinGeckoTrendingSearchPoolsDataRelationships Relationships { get; set; } = new();
    }

    /// <summary>
    /// Trending Search Pools Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingSearchPoolsDataAttributes
    {
        /// <summary>
        /// ["<c>trending_rank</c>"] Trending search rank (0-based)
        /// </summary>
        [JsonPropertyName("trending_rank")]
        public long TrendingRank { get; set; }
        /// <summary>
        /// ["<c>address</c>"] Pool contract address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Pool name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>pool_created_at</c>"] Pool creation timestamp
        /// </summary>
        [JsonPropertyName("pool_created_at")]
        public DateTime PoolCreatedAt { get; set; }
        /// <summary>
        /// ["<c>fdv_usd</c>"] Fully diluted valuation in USD
        /// </summary>
        [JsonPropertyName("fdv_usd")]
        public decimal? FdvUsd { get; set; }
        /// <summary>
        /// ["<c>market_cap_usd</c>"] Market cap in USD
        /// </summary>
        [JsonPropertyName("market_cap_usd")]
        public string? MarketCapUsd { get; set; }
        /// <summary>
        /// ["<c>volume_usd</c>"] Volume in USD
        /// </summary>
        [JsonPropertyName("volume_usd")]
        public CoinGeckoTrendingSearchPoolsDataAttributesVolumeUsd VolumeUsd { get; set; } = new();
        /// <summary>
        /// ["<c>reserve_in_usd</c>"] Total reserve in USD
        /// </summary>
        [JsonPropertyName("reserve_in_usd")]
        public decimal? ReserveInUsd { get; set; }
    }

    /// <summary>
    /// Trending Search Pools Data Attributes Volume Usd
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingSearchPoolsDataAttributesVolumeUsd
    {
        /// <summary>
        /// ["<c>h24</c>"] H24
        /// </summary>
        [JsonPropertyName("h24")]
        public string? H24 { get; set; }
    }

    /// <summary>
    /// Trending Search Pools Data Relationships
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingSearchPoolsDataRelationships
    {
        /// <summary>
        /// ["<c>base_token</c>"] BaseToken
        /// </summary>
        [JsonPropertyName("base_token")]
        public CoinGeckoTrendingSearchPoolsDataRelationshipsBaseToken? BaseToken { get; set; }
        /// <summary>
        /// ["<c>quote_token</c>"] QuoteToken
        /// </summary>
        [JsonPropertyName("quote_token")]
        public CoinGeckoTrendingSearchPoolsDataRelationshipsBaseToken? QuoteToken { get; set; }
        /// <summary>
        /// ["<c>network</c>"] Network
        /// </summary>
        [JsonPropertyName("network")]
        public CoinGeckoTrendingSearchPoolsDataRelationshipsBaseToken? Network { get; set; }
        /// <summary>
        /// ["<c>dex</c>"] Dex
        /// </summary>
        [JsonPropertyName("dex")]
        public CoinGeckoTrendingSearchPoolsDataRelationshipsBaseToken? Dex { get; set; }
    }

    /// <summary>
    /// Trending Search Pools Data Relationships Base Token
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingSearchPoolsDataRelationshipsBaseToken
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoTrendingSearchPoolsDataRelationshipsBaseTokenData? Data { get; set; }
    }

    /// <summary>
    /// Trending Search Pools Data Relationships Base Token Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingSearchPoolsDataRelationshipsBaseTokenData
    {
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        /// <summary>
        /// ["<c>type</c>"] Type
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    /// <summary>
    /// Trending Search Pools Included Item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingSearchPoolsIncludedItem
    {
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        /// <summary>
        /// ["<c>type</c>"] Type
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// ["<c>attributes</c>"] Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public CoinGeckoTrendingSearchPoolsIncludedItemAttributes? Attributes { get; set; }
    }

    /// <summary>
    /// Trending Search Pools Included Item Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTrendingSearchPoolsIncludedItemAttributes
    {
        /// <summary>
        /// ["<c>address</c>"] Address
        /// </summary>
        [JsonPropertyName("address")]
        public string? Address { get; set; }
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
        /// <summary>
        /// ["<c>decimals</c>"] Decimals
        /// </summary>
        [JsonPropertyName("decimals")]
        public long? Decimals { get; set; }
        /// <summary>
        /// ["<c>image_url</c>"] ImageUrl
        /// </summary>
        [JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }
        /// <summary>
        /// ["<c>coingecko_coin_id</c>"] CoingeckoCoinId
        /// </summary>
        [JsonPropertyName("coingecko_coin_id")]
        public string? CoingeckoCoinId { get; set; }
        /// <summary>
        /// ["<c>coingecko_asset_platform_id</c>"] CoingeckoAssetPlatformId
        /// </summary>
        [JsonPropertyName("coingecko_asset_platform_id")]
        public string? CoingeckoAssetPlatformId { get; set; }
    }
}
