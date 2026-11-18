using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Categories Pools
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCategoriesPools
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoCategoriesPoolsData[] Data { get; set; } = [];
        /// <summary>
        /// ["<c>included</c>"] Included related resources, present when include parameter is specified
        /// </summary>
        [JsonPropertyName("included")]
        public CoinGeckoCategoriesPoolsIncludedItem[]? Included { get; set; }
    }

    /// <summary>
    /// Categories Pools Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCategoriesPoolsData
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
        public CoinGeckoCategoriesPoolsDataAttributes Attributes { get; set; } = new();
        /// <summary>
        /// ["<c>relationships</c>"] Related resources
        /// </summary>
        [JsonPropertyName("relationships")]
        public CoinGeckoCategoriesPoolsDataRelationships Relationships { get; set; } = new();
    }

    /// <summary>
    /// Categories Pools Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCategoriesPoolsDataAttributes
    {
        /// <summary>
        /// ["<c>base_token_price_usd</c>"] Base token price in USD
        /// </summary>
        [JsonPropertyName("base_token_price_usd")]
        public decimal BaseTokenPriceUsd { get; set; }
        /// <summary>
        /// ["<c>base_token_price_native_currency</c>"] Base token price in native currency
        /// </summary>
        [JsonPropertyName("base_token_price_native_currency")]
        public decimal? BaseTokenPriceNativeCurrency { get; set; }
        /// <summary>
        /// ["<c>quote_token_price_usd</c>"] Quote token price in USD
        /// </summary>
        [JsonPropertyName("quote_token_price_usd")]
        public decimal QuoteTokenPriceUsd { get; set; }
        /// <summary>
        /// ["<c>quote_token_price_native_currency</c>"] Quote token price in native currency
        /// </summary>
        [JsonPropertyName("quote_token_price_native_currency")]
        public decimal? QuoteTokenPriceNativeCurrency { get; set; }
        /// <summary>
        /// ["<c>base_token_price_quote_token</c>"] Base token price in quote token
        /// </summary>
        [JsonPropertyName("base_token_price_quote_token")]
        public decimal? BaseTokenPriceQuoteToken { get; set; }
        /// <summary>
        /// ["<c>quote_token_price_base_token</c>"] Quote token price in base token
        /// </summary>
        [JsonPropertyName("quote_token_price_base_token")]
        public decimal? QuoteTokenPriceBaseToken { get; set; }
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
        /// ["<c>price_change_percentage</c>"] Price change percentage over various timeframes
        /// </summary>
        [JsonPropertyName("price_change_percentage")]
        public CoinGeckoCategoriesPoolsDataAttributesPriceChangePercentage PriceChangePercentage { get; set; } = new();
        /// <summary>
        /// ["<c>reserve_in_usd</c>"] Total reserve in USD
        /// </summary>
        [JsonPropertyName("reserve_in_usd")]
        public decimal? ReserveInUsd { get; set; }
        /// <summary>
        /// ["<c>h24_volume_usd</c>"] 24hr volume in USD
        /// </summary>
        [JsonPropertyName("h24_volume_usd")]
        public decimal H24VolumeUsd { get; set; }
        /// <summary>
        /// ["<c>h24_tx_count</c>"] 24hr transaction count
        /// </summary>
        [JsonPropertyName("h24_tx_count")]
        public long H24TxCount { get; set; }
    }

    /// <summary>
    /// Categories Pools Data Attributes Price Change Percentage
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCategoriesPoolsDataAttributesPriceChangePercentage
    {
        /// <summary>
        /// ["<c>m5</c>"] M5
        /// </summary>
        [JsonPropertyName("m5")]
        public string? M5 { get; set; }
        /// <summary>
        /// ["<c>m15</c>"] M15
        /// </summary>
        [JsonPropertyName("m15")]
        public string? M15 { get; set; }
        /// <summary>
        /// ["<c>m30</c>"] M30
        /// </summary>
        [JsonPropertyName("m30")]
        public string? M30 { get; set; }
        /// <summary>
        /// ["<c>h1</c>"] H1
        /// </summary>
        [JsonPropertyName("h1")]
        public string? H1 { get; set; }
        /// <summary>
        /// ["<c>h6</c>"] H6
        /// </summary>
        [JsonPropertyName("h6")]
        public string? H6 { get; set; }
        /// <summary>
        /// ["<c>h24</c>"] H24
        /// </summary>
        [JsonPropertyName("h24")]
        public string? H24 { get; set; }
    }

    /// <summary>
    /// Categories Pools Data Relationships
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCategoriesPoolsDataRelationships
    {
        /// <summary>
        /// ["<c>base_token</c>"] BaseToken
        /// </summary>
        [JsonPropertyName("base_token")]
        public CoinGeckoCategoriesPoolsDataRelationshipsBaseToken? BaseToken { get; set; }
        /// <summary>
        /// ["<c>quote_token</c>"] QuoteToken
        /// </summary>
        [JsonPropertyName("quote_token")]
        public CoinGeckoCategoriesPoolsDataRelationshipsBaseToken? QuoteToken { get; set; }
        /// <summary>
        /// ["<c>network</c>"] Network
        /// </summary>
        [JsonPropertyName("network")]
        public CoinGeckoCategoriesPoolsDataRelationshipsBaseToken? Network { get; set; }
        /// <summary>
        /// ["<c>dex</c>"] Dex
        /// </summary>
        [JsonPropertyName("dex")]
        public CoinGeckoCategoriesPoolsDataRelationshipsBaseToken? Dex { get; set; }
    }

    /// <summary>
    /// Categories Pools Data Relationships Base Token
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCategoriesPoolsDataRelationshipsBaseToken
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoCategoriesPoolsDataRelationshipsBaseTokenData? Data { get; set; }
    }

    /// <summary>
    /// Categories Pools Data Relationships Base Token Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCategoriesPoolsDataRelationshipsBaseTokenData
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
    /// Categories Pools Included Item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCategoriesPoolsIncludedItem
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
        public CoinGeckoCategoriesPoolsIncludedItemAttributes? Attributes { get; set; }
    }

    /// <summary>
    /// Categories Pools Included Item Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCategoriesPoolsIncludedItemAttributes
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
