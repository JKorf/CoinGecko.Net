using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Pool Address Item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolAddressItem
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
        public CoinGeckoPoolAddressItemAttributes Attributes { get; set; } = new();
        /// <summary>
        /// ["<c>relationships</c>"] Related resources
        /// </summary>
        [JsonPropertyName("relationships")]
        public CoinGeckoPoolAddressItemRelationships Relationships { get; set; } = new();
    }

    /// <summary>
    /// Pool Address Item Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolAddressItemAttributes
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
        public decimal BaseTokenPriceNativeCurrency { get; set; }
        /// <summary>
        /// ["<c>base_token_balance</c>"] Base token balance in pool
        /// </summary>
        [JsonPropertyName("base_token_balance")]
        public string? BaseTokenBalance { get; set; }
        /// <summary>
        /// ["<c>base_token_liquidity_usd</c>"] Base token liquidity in USD
        /// </summary>
        [JsonPropertyName("base_token_liquidity_usd")]
        public string? BaseTokenLiquidityUsd { get; set; }
        /// <summary>
        /// ["<c>quote_token_price_usd</c>"] Quote token price in USD
        /// </summary>
        [JsonPropertyName("quote_token_price_usd")]
        public decimal QuoteTokenPriceUsd { get; set; }
        /// <summary>
        /// ["<c>quote_token_price_native_currency</c>"] Quote token price in native currency
        /// </summary>
        [JsonPropertyName("quote_token_price_native_currency")]
        public decimal QuoteTokenPriceNativeCurrency { get; set; }
        /// <summary>
        /// ["<c>quote_token_balance</c>"] Quote token balance in pool
        /// </summary>
        [JsonPropertyName("quote_token_balance")]
        public string? QuoteTokenBalance { get; set; }
        /// <summary>
        /// ["<c>quote_token_liquidity_usd</c>"] Quote token liquidity in USD
        /// </summary>
        [JsonPropertyName("quote_token_liquidity_usd")]
        public string? QuoteTokenLiquidityUsd { get; set; }
        /// <summary>
        /// ["<c>base_token_price_quote_token</c>"] Base token price in quote token
        /// </summary>
        [JsonPropertyName("base_token_price_quote_token")]
        public decimal BaseTokenPriceQuoteToken { get; set; }
        /// <summary>
        /// ["<c>quote_token_price_base_token</c>"] Quote token price in base token
        /// </summary>
        [JsonPropertyName("quote_token_price_base_token")]
        public decimal QuoteTokenPriceBaseToken { get; set; }
        /// <summary>
        /// ["<c>address</c>"] Pool contract address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Pool name with fee tier
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>pool_name</c>"] Pool name without fee tier
        /// </summary>
        [JsonPropertyName("pool_name")]
        public string PoolName { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>pool_fee_percentage</c>"] Pool fee percentage
        /// </summary>
        [JsonPropertyName("pool_fee_percentage")]
        public string? PoolFeePercentage { get; set; }
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
        public CoinGeckoPoolAddressItemAttributesPriceChangePercentage PriceChangePercentage { get; set; } = new();
        /// <summary>
        /// ["<c>transactions</c>"] Transaction counts over various timeframes
        /// </summary>
        [JsonPropertyName("transactions")]
        public CoinGeckoPoolAddressItemAttributesTransactions Transactions { get; set; } = new();
        /// <summary>
        /// ["<c>volume_usd</c>"] Volume in USD over various timeframes
        /// </summary>
        [JsonPropertyName("volume_usd")]
        public CoinGeckoPoolAddressItemAttributesPriceChangePercentage VolumeUsd { get; set; } = new();
        /// <summary>
        /// ["<c>net_buy_volume_usd</c>"] Net buy volume in USD over various timeframes
        /// </summary>
        [JsonPropertyName("net_buy_volume_usd")]
        public CoinGeckoPoolAddressItemAttributesPriceChangePercentage? NetBuyVolumeUsd { get; set; }
        /// <summary>
        /// ["<c>buy_volume_usd</c>"] Buy volume in USD over various timeframes
        /// </summary>
        [JsonPropertyName("buy_volume_usd")]
        public CoinGeckoPoolAddressItemAttributesPriceChangePercentage? BuyVolumeUsd { get; set; }
        /// <summary>
        /// ["<c>sell_volume_usd</c>"] Sell volume in USD over various timeframes
        /// </summary>
        [JsonPropertyName("sell_volume_usd")]
        public CoinGeckoPoolAddressItemAttributesPriceChangePercentage? SellVolumeUsd { get; set; }
        /// <summary>
        /// ["<c>reserve_in_usd</c>"] Total reserve in USD
        /// </summary>
        [JsonPropertyName("reserve_in_usd")]
        public decimal ReserveInUsd { get; set; }
        /// <summary>
        /// ["<c>locked_liquidity_percentage</c>"] Locked liquidity percentage
        /// </summary>
        [JsonPropertyName("locked_liquidity_percentage")]
        public string? LockedLiquidityPercentage { get; set; }
        /// <summary>
        /// ["<c>launchpad_details</c>"] Launchpad details for bonding curve pools
        /// </summary>
        [JsonPropertyName("launchpad_details")]
        public CoinGeckoPoolAddressItemAttributesLaunchpadDetails? LaunchpadDetails { get; set; }
    }

    /// <summary>
    /// Pool Address Item Attributes Price Change Percentage
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolAddressItemAttributesPriceChangePercentage
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
    /// Pool Address Item Attributes Transactions
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolAddressItemAttributesTransactions
    {
        /// <summary>
        /// ["<c>m5</c>"] M5
        /// </summary>
        [JsonPropertyName("m5")]
        public CoinGeckoPoolAddressItemAttributesTransactionsM5? M5 { get; set; }
        /// <summary>
        /// ["<c>m15</c>"] M15
        /// </summary>
        [JsonPropertyName("m15")]
        public CoinGeckoPoolAddressItemAttributesTransactionsM5? M15 { get; set; }
        /// <summary>
        /// ["<c>m30</c>"] M30
        /// </summary>
        [JsonPropertyName("m30")]
        public CoinGeckoPoolAddressItemAttributesTransactionsM5? M30 { get; set; }
        /// <summary>
        /// ["<c>h1</c>"] H1
        /// </summary>
        [JsonPropertyName("h1")]
        public CoinGeckoPoolAddressItemAttributesTransactionsM5? H1 { get; set; }
        /// <summary>
        /// ["<c>h6</c>"] H6
        /// </summary>
        [JsonPropertyName("h6")]
        public CoinGeckoPoolAddressItemAttributesTransactionsM5? H6 { get; set; }
        /// <summary>
        /// ["<c>h24</c>"] H24
        /// </summary>
        [JsonPropertyName("h24")]
        public CoinGeckoPoolAddressItemAttributesTransactionsM5? H24 { get; set; }
    }

    /// <summary>
    /// Pool Address Item Attributes Transactions M5
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolAddressItemAttributesTransactionsM5
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
    /// Pool Address Item Attributes Launchpad Details
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolAddressItemAttributesLaunchpadDetails
    {
        /// <summary>
        /// ["<c>graduation_percentage</c>"] GraduationPercentage
        /// </summary>
        [JsonPropertyName("graduation_percentage")]
        public decimal? GraduationPercentage { get; set; }
        /// <summary>
        /// ["<c>completed</c>"] Completed
        /// </summary>
        [JsonPropertyName("completed")]
        public bool? Completed { get; set; }
        /// <summary>
        /// ["<c>completed_at</c>"] CompletedAt
        /// </summary>
        [JsonPropertyName("completed_at")]
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// ["<c>migrated_destination_pool_address</c>"] MigratedDestinationPoolAddress
        /// </summary>
        [JsonPropertyName("migrated_destination_pool_address")]
        public string? MigratedDestinationPoolAddress { get; set; }
    }

    /// <summary>
    /// Pool Address Item Relationships
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolAddressItemRelationships
    {
        /// <summary>
        /// ["<c>base_token</c>"] BaseToken
        /// </summary>
        [JsonPropertyName("base_token")]
        public CoinGeckoPoolAddressItemRelationshipsBaseToken? BaseToken { get; set; }
        /// <summary>
        /// ["<c>quote_token</c>"] QuoteToken
        /// </summary>
        [JsonPropertyName("quote_token")]
        public CoinGeckoPoolAddressItemRelationshipsBaseToken? QuoteToken { get; set; }
        /// <summary>
        /// ["<c>dex</c>"] Dex
        /// </summary>
        [JsonPropertyName("dex")]
        public CoinGeckoPoolAddressItemRelationshipsBaseToken? Dex { get; set; }
    }

    /// <summary>
    /// Pool Address Item Relationships Base Token
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolAddressItemRelationshipsBaseToken
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoPoolAddressItemRelationshipsBaseTokenData? Data { get; set; }
    }

    /// <summary>
    /// Pool Address Item Relationships Base Token Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolAddressItemRelationshipsBaseTokenData
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
