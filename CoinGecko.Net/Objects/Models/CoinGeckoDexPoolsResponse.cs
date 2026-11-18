using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex Pools Response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolsResponse
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoDexPoolsResponseData[] Data { get; set; } = [];
        /// <summary>
        /// ["<c>included</c>"] Included related resources, present when include parameter is specified
        /// </summary>
        [JsonPropertyName("included")]
        public CoinGeckoDexPoolsResponseIncludedItem[]? Included { get; set; }
    }

    /// <summary>
    /// Dex Pools Response Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolsResponseData
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
        public CoinGeckoDexPoolsResponseDataAttributes Attributes { get; set; } = new();
        /// <summary>
        /// ["<c>relationships</c>"] Related resources
        /// </summary>
        [JsonPropertyName("relationships")]
        public CoinGeckoDexPoolsResponseDataRelationships Relationships { get; set; } = new();
    }

    /// <summary>
    /// Dex Pools Response Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolsResponseDataAttributes
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
        public decimal? MarketCapUsd { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage</c>"] Price change percentage over various timeframes
        /// </summary>
        [JsonPropertyName("price_change_percentage")]
        public CoinGeckoDexPoolsResponseDataAttributesPriceChangePercentage PriceChangePercentage { get; set; } = new();
        /// <summary>
        /// ["<c>transactions</c>"] Transaction counts over various timeframes
        /// </summary>
        [JsonPropertyName("transactions")]
        public CoinGeckoDexPoolsResponseDataAttributesTransactions Transactions { get; set; } = new();
        /// <summary>
        /// ["<c>volume_usd</c>"] Volume in USD over various timeframes
        /// </summary>
        [JsonPropertyName("volume_usd")]
        public CoinGeckoDexPoolsResponseDataAttributesPriceChangePercentage VolumeUsd { get; set; } = new();
        /// <summary>
        /// ["<c>reserve_in_usd</c>"] Total reserve in USD
        /// </summary>
        [JsonPropertyName("reserve_in_usd")]
        public decimal? ReserveInUsd { get; set; }
        /// <summary>
        /// ["<c>token_price_usd</c>"] Price of the queried token in USD, present when querying pools by token address
        /// </summary>
        [JsonPropertyName("token_price_usd")]
        public string? TokenPriceUsd { get; set; }
        /// <summary>
        /// ["<c>sentiment_vote_positive_percentage</c>"] GeckoTerminal community positive sentiment vote percentage
        /// </summary>
        [JsonPropertyName("sentiment_vote_positive_percentage")]
        public decimal? SentimentVotePositivePercentage { get; set; }
        /// <summary>
        /// ["<c>sentiment_vote_negative_percentage</c>"] GeckoTerminal community negative sentiment vote percentage
        /// </summary>
        [JsonPropertyName("sentiment_vote_negative_percentage")]
        public decimal? SentimentVoteNegativePercentage { get; set; }
        /// <summary>
        /// ["<c>community_sus_report</c>"] GeckoTerminal community suspicious reports count
        /// </summary>
        [JsonPropertyName("community_sus_report")]
        public long? CommunitySusReport { get; set; }
    }

    /// <summary>
    /// Dex Pools Response Data Attributes Price Change Percentage
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolsResponseDataAttributesPriceChangePercentage
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
    /// Dex Pools Response Data Attributes Transactions
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolsResponseDataAttributesTransactions
    {
        /// <summary>
        /// ["<c>m5</c>"] M5
        /// </summary>
        [JsonPropertyName("m5")]
        public CoinGeckoDexPoolsResponseDataAttributesTransactionsM5? M5 { get; set; }
        /// <summary>
        /// ["<c>m15</c>"] M15
        /// </summary>
        [JsonPropertyName("m15")]
        public CoinGeckoDexPoolsResponseDataAttributesTransactionsM5? M15 { get; set; }
        /// <summary>
        /// ["<c>m30</c>"] M30
        /// </summary>
        [JsonPropertyName("m30")]
        public CoinGeckoDexPoolsResponseDataAttributesTransactionsM5? M30 { get; set; }
        /// <summary>
        /// ["<c>h1</c>"] H1
        /// </summary>
        [JsonPropertyName("h1")]
        public CoinGeckoDexPoolsResponseDataAttributesTransactionsM5? H1 { get; set; }
        /// <summary>
        /// ["<c>h6</c>"] H6
        /// </summary>
        [JsonPropertyName("h6")]
        public CoinGeckoDexPoolsResponseDataAttributesTransactionsM5? H6 { get; set; }
        /// <summary>
        /// ["<c>h24</c>"] H24
        /// </summary>
        [JsonPropertyName("h24")]
        public CoinGeckoDexPoolsResponseDataAttributesTransactionsM5? H24 { get; set; }
    }

    /// <summary>
    /// Dex Pools Response Data Attributes Transactions M5
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolsResponseDataAttributesTransactionsM5
    {
        /// <summary>
        /// ["<c>buys</c>"] Buys
        /// </summary>
        [JsonPropertyName("buys")]
        public long? Buys { get; set; }
        /// <summary>
        /// ["<c>sells</c>"] Sells
        /// </summary>
        [JsonPropertyName("sells")]
        public long? Sells { get; set; }
        /// <summary>
        /// ["<c>buyers</c>"] Buyers
        /// </summary>
        [JsonPropertyName("buyers")]
        public long? Buyers { get; set; }
        /// <summary>
        /// ["<c>sellers</c>"] Sellers
        /// </summary>
        [JsonPropertyName("sellers")]
        public long? Sellers { get; set; }
    }

    /// <summary>
    /// Dex Pools Response Data Relationships
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolsResponseDataRelationships
    {
        /// <summary>
        /// ["<c>base_token</c>"] BaseToken
        /// </summary>
        [JsonPropertyName("base_token")]
        public CoinGeckoDexPoolsResponseDataRelationshipsBaseToken? BaseToken { get; set; }
        /// <summary>
        /// ["<c>quote_token</c>"] QuoteToken
        /// </summary>
        [JsonPropertyName("quote_token")]
        public CoinGeckoDexPoolsResponseDataRelationshipsBaseToken? QuoteToken { get; set; }
        /// <summary>
        /// ["<c>network</c>"] Network
        /// </summary>
        [JsonPropertyName("network")]
        public CoinGeckoDexPoolsResponseDataRelationshipsBaseToken? Network { get; set; }
        /// <summary>
        /// ["<c>dex</c>"] Dex
        /// </summary>
        [JsonPropertyName("dex")]
        public CoinGeckoDexPoolsResponseDataRelationshipsBaseToken? Dex { get; set; }
    }

    /// <summary>
    /// Dex Pools Response Data Relationships Base Token
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolsResponseDataRelationshipsBaseToken
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoDexPoolsResponseDataRelationshipsBaseTokenData? Data { get; set; }
    }

    /// <summary>
    /// Dex Pools Response Data Relationships Base Token Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolsResponseDataRelationshipsBaseTokenData
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
    /// Dex Pools Response Included Item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolsResponseIncludedItem
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
        public CoinGeckoDexPoolsResponseIncludedItemAttributes? Attributes { get; set; }
    }

    /// <summary>
    /// Dex Pools Response Included Item Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolsResponseIncludedItemAttributes
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
