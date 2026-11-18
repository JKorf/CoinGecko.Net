using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex Token Response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTokenResponse
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoTokenItem Data { get; set; } = new();
        /// <summary>
        /// ["<c>included</c>"] Included top pool data, present when include=top_pools is specified
        /// </summary>
        [JsonPropertyName("included")]
        public CoinGeckoDexTokenResponseIncludedItem[]? Included { get; set; }
    }

    /// <summary>
    /// Dex Token Response Included Item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTokenResponseIncludedItem
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
        public CoinGeckoDexTokenResponseIncludedItemAttributes? Attributes { get; set; }
        /// <summary>
        /// ["<c>relationships</c>"] Relationships
        /// </summary>
        [JsonPropertyName("relationships")]
        public CoinGeckoDexTokenResponseIncludedItemRelationships? Relationships { get; set; }
    }

    /// <summary>
    /// Dex Token Response Included Item Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTokenResponseIncludedItemAttributes
    {
        /// <summary>
        /// ["<c>base_token_price_usd</c>"] BaseTokenPriceUsd
        /// </summary>
        [JsonPropertyName("base_token_price_usd")]
        public decimal? BaseTokenPriceUsd { get; set; }
        /// <summary>
        /// ["<c>base_token_price_native_currency</c>"] BaseTokenPriceNativeCurrency
        /// </summary>
        [JsonPropertyName("base_token_price_native_currency")]
        public decimal? BaseTokenPriceNativeCurrency { get; set; }
        /// <summary>
        /// ["<c>base_token_balance</c>"] Base token balance in pool
        /// </summary>
        [JsonPropertyName("base_token_balance")]
        public decimal? BaseTokenBalance { get; set; }
        /// <summary>
        /// ["<c>base_token_liquidity_usd</c>"] Base token liquidity in USD
        /// </summary>
        [JsonPropertyName("base_token_liquidity_usd")]
        public decimal? BaseTokenLiquidityUsd { get; set; }
        /// <summary>
        /// ["<c>quote_token_price_usd</c>"] QuoteTokenPriceUsd
        /// </summary>
        [JsonPropertyName("quote_token_price_usd")]
        public decimal? QuoteTokenPriceUsd { get; set; }
        /// <summary>
        /// ["<c>quote_token_price_native_currency</c>"] QuoteTokenPriceNativeCurrency
        /// </summary>
        [JsonPropertyName("quote_token_price_native_currency")]
        public decimal? QuoteTokenPriceNativeCurrency { get; set; }
        /// <summary>
        /// ["<c>quote_token_balance</c>"] Quote token balance in pool
        /// </summary>
        [JsonPropertyName("quote_token_balance")]
        public decimal? QuoteTokenBalance { get; set; }
        /// <summary>
        /// ["<c>quote_token_liquidity_usd</c>"] Quote token liquidity in USD
        /// </summary>
        [JsonPropertyName("quote_token_liquidity_usd")]
        public decimal? QuoteTokenLiquidityUsd { get; set; }
        /// <summary>
        /// ["<c>base_token_price_quote_token</c>"] BaseTokenPriceQuoteToken
        /// </summary>
        [JsonPropertyName("base_token_price_quote_token")]
        public decimal? BaseTokenPriceQuoteToken { get; set; }
        /// <summary>
        /// ["<c>quote_token_price_base_token</c>"] QuoteTokenPriceBaseToken
        /// </summary>
        [JsonPropertyName("quote_token_price_base_token")]
        public decimal? QuoteTokenPriceBaseToken { get; set; }
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
        /// ["<c>pool_created_at</c>"] PoolCreatedAt
        /// </summary>
        [JsonPropertyName("pool_created_at")]
        public DateTime? PoolCreatedAt { get; set; }
        /// <summary>
        /// ["<c>token_price_usd</c>"] TokenPriceUsd
        /// </summary>
        [JsonPropertyName("token_price_usd")]
        public decimal? TokenPriceUsd { get; set; }
        /// <summary>
        /// ["<c>fdv_usd</c>"] FdvUsd
        /// </summary>
        [JsonPropertyName("fdv_usd")]
        public decimal? FdvUsd { get; set; }
        /// <summary>
        /// ["<c>market_cap_usd</c>"] MarketCapUsd
        /// </summary>
        [JsonPropertyName("market_cap_usd")]
        public decimal? MarketCapUsd { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage</c>"] PriceChangePercentage
        /// </summary>
        [JsonPropertyName("price_change_percentage")]
        public CoinGeckoDexTokenResponseIncludedItemAttributesPriceChangePercentage? PriceChangePercentage { get; set; }
        /// <summary>
        /// ["<c>transactions</c>"] Transactions
        /// </summary>
        [JsonPropertyName("transactions")]
        public CoinGeckoDexTokenResponseIncludedItemAttributesTransactions? Transactions { get; set; }
        /// <summary>
        /// ["<c>volume_usd</c>"] VolumeUsd
        /// </summary>
        [JsonPropertyName("volume_usd")]
        public CoinGeckoDexTokenResponseIncludedItemAttributesPriceChangePercentage? VolumeUsd { get; set; }
        /// <summary>
        /// ["<c>reserve_in_usd</c>"] ReserveInUsd
        /// </summary>
        [JsonPropertyName("reserve_in_usd")]
        public decimal? ReserveInUsd { get; set; }
        /// <summary>
        /// ["<c>last_trade_timestamp</c>"] LastTradeTimestamp
        /// </summary>
        [JsonPropertyName("last_trade_timestamp")]
        public string? LastTradeTimestamp { get; set; }
    }

    /// <summary>
    /// Dex Token Response Included Item Attributes Price Change Percentage
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTokenResponseIncludedItemAttributesPriceChangePercentage
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
    /// Dex Token Response Included Item Attributes Transactions
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTokenResponseIncludedItemAttributesTransactions
    {
        /// <summary>
        /// ["<c>m5</c>"] M5
        /// </summary>
        [JsonPropertyName("m5")]
        public CoinGeckoDexTokenResponseIncludedItemAttributesTransactionsM5? M5 { get; set; }
        /// <summary>
        /// ["<c>m15</c>"] M15
        /// </summary>
        [JsonPropertyName("m15")]
        public CoinGeckoDexTokenResponseIncludedItemAttributesTransactionsM5? M15 { get; set; }
        /// <summary>
        /// ["<c>m30</c>"] M30
        /// </summary>
        [JsonPropertyName("m30")]
        public CoinGeckoDexTokenResponseIncludedItemAttributesTransactionsM5? M30 { get; set; }
        /// <summary>
        /// ["<c>h1</c>"] H1
        /// </summary>
        [JsonPropertyName("h1")]
        public CoinGeckoDexTokenResponseIncludedItemAttributesTransactionsM5? H1 { get; set; }
        /// <summary>
        /// ["<c>h6</c>"] H6
        /// </summary>
        [JsonPropertyName("h6")]
        public CoinGeckoDexTokenResponseIncludedItemAttributesTransactionsM5? H6 { get; set; }
        /// <summary>
        /// ["<c>h24</c>"] H24
        /// </summary>
        [JsonPropertyName("h24")]
        public CoinGeckoDexTokenResponseIncludedItemAttributesTransactionsM5? H24 { get; set; }
    }

    /// <summary>
    /// Dex Token Response Included Item Attributes Transactions M5
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTokenResponseIncludedItemAttributesTransactionsM5
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
    /// Dex Token Response Included Item Relationships
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTokenResponseIncludedItemRelationships
    {
        /// <summary>
        /// ["<c>base_token</c>"] BaseToken
        /// </summary>
        [JsonPropertyName("base_token")]
        public CoinGeckoDexTokenResponseIncludedItemRelationshipsBaseToken? BaseToken { get; set; }
        /// <summary>
        /// ["<c>quote_token</c>"] QuoteToken
        /// </summary>
        [JsonPropertyName("quote_token")]
        public CoinGeckoDexTokenResponseIncludedItemRelationshipsBaseToken? QuoteToken { get; set; }
        /// <summary>
        /// ["<c>dex</c>"] Dex
        /// </summary>
        [JsonPropertyName("dex")]
        public CoinGeckoDexTokenResponseIncludedItemRelationshipsBaseToken? Dex { get; set; }
    }

    /// <summary>
    /// Dex Token Response Included Item Relationships Base Token
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTokenResponseIncludedItemRelationshipsBaseToken
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoDexTokenResponseIncludedItemRelationshipsBaseTokenData? Data { get; set; }
    }

    /// <summary>
    /// Dex Token Response Included Item Relationships Base Token Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTokenResponseIncludedItemRelationshipsBaseTokenData
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
}
