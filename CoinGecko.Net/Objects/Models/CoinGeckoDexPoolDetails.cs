using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex pool details
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolDetails
    {
        /// <summary>
        /// ["<c>base_token_price_usd</c>"] Base token price in USD
        /// </summary>
        [JsonPropertyName("base_token_price_usd")]
        public decimal BaseTokenPriceUsd { get; set; }

        /// <summary>
        /// ["<c>base_token_price_native_currency</c>"] Base token price in native currency
        /// </summary>
        [JsonPropertyName("base_token_price_native_currency"), JsonConverter(typeof(DecimalConverter))]
        public decimal? BaseTokenPriceNativeCurrency { get; set; }

        /// <summary>
        /// ["<c>quote_token_price_usd</c>"] Quote token price in USD
        /// </summary>
        [JsonPropertyName("quote_token_price_usd"), JsonConverter(typeof(DecimalConverter))]
        public decimal? QuoteTokenPriceUsd { get; set; }

        /// <summary>
        /// ["<c>quote_token_price_native_currency</c>"] Quote token price in native currency
        /// </summary>
        [JsonPropertyName("quote_token_price_native_currency"), JsonConverter(typeof(DecimalConverter))]
        public decimal? QuoteTokenPriceNativeCurrency { get; set; }

        /// <summary>
        /// ["<c>base_token_price_quote_token</c>"] Base token price in quote token
        /// </summary>
        [JsonPropertyName("base_token_price_quote_token"), JsonConverter(typeof(DecimalConverter))]
        public decimal? BaseTokenPriceQuoteToken { get; set; }

        /// <summary>
        /// ["<c>quote_token_price_base_token</c>"] Quote token price in base token
        /// </summary>
        [JsonPropertyName("quote_token_price_base_token"), JsonConverter(typeof(DecimalConverter))]
        public decimal? QuoteTokenPriceBaseToken { get; set; }

        /// <summary>
        /// ["<c>address</c>"] Pool address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// ["<c>pool_created_at</c>"] Pool creation time
        /// </summary>
        [JsonPropertyName("pool_created_at")]
        public DateTime PoolCreatedAt { get; set; }

        /// <summary>
        /// ["<c>fdv_usd</c>"] Fully diluted valuation in USD
        /// </summary>
        [JsonPropertyName("fdv_usd")]
        public decimal? FullyDilutedValuationUsd { get; set; }

        /// <summary>
        /// ["<c>market_cap_usd</c>"] Market cap in USD
        /// </summary>
        [JsonPropertyName("market_cap_usd")]
        public decimal? MarketCapUsd { get; set; }

        /// <summary>
        /// ["<c>price_change_percentage</c>"] Price change percentage
        /// </summary>
        [JsonPropertyName("price_change_percentage")]
        public CoinGeckoDexTimeValues? PriceChangePercentage { get; set; }

        /// <summary>
        /// ["<c>transactions</c>"] Transactions
        /// </summary>
        [JsonPropertyName("transactions")]
        public CoinGeckoDexTransactions? Transactions { get; set; }

        /// <summary>
        /// ["<c>volume_usd</c>"] Volume in USD
        /// </summary>
        [JsonPropertyName("volume_usd")]
        public CoinGeckoDexTimeValues? VolumeUsd { get; set; }

        /// <summary>
        /// ["<c>reserve_in_usd</c>"] Reserve in USD
        /// </summary>
        [JsonPropertyName("reserve_in_usd")]
        public decimal? ReserveInUsd { get; set; }
    }

    /// <summary>
    /// Dex time interval values
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTimeValues
    {
        /// <summary>
        /// ["<c>m5</c>"] Five minutes
        /// </summary>
        [JsonPropertyName("m5")]
        public decimal FiveMinutes { get; set; }

        /// <summary>
        /// ["<c>m15</c>"] Fifteen minutes
        /// </summary>
        [JsonPropertyName("m15")]
        public decimal FifteenMinutes { get; set; }

        /// <summary>
        /// ["<c>m30</c>"] Thirty minutes
        /// </summary>
        [JsonPropertyName("m30")]
        public decimal ThirtyMinutes { get; set; }

        /// <summary>
        /// ["<c>h1</c>"] One hour
        /// </summary>
        [JsonPropertyName("h1")]
        public decimal OneHour { get; set; }

        /// <summary>
        /// ["<c>h6</c>"] Six hours
        /// </summary>
        [JsonPropertyName("h6")]
        public decimal SixHours { get; set; }

        /// <summary>
        /// ["<c>h24</c>"] Twenty four hours
        /// </summary>
        [JsonPropertyName("h24")]
        public decimal OneDay { get; set; }
    }

    /// <summary>
    /// Dex transaction counts per time interval
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTransactions
    {
        /// <summary>
        /// ["<c>m5</c>"] Five minutes
        /// </summary>
        [JsonPropertyName("m5")]
        public CoinGeckoDexTransactionCounts? FiveMinutes { get; set; }

        /// <summary>
        /// ["<c>m15</c>"] Fifteen minutes
        /// </summary>
        [JsonPropertyName("m15")]
        public CoinGeckoDexTransactionCounts? FifteenMinutes { get; set; }

        /// <summary>
        /// ["<c>m30</c>"] Thirty minutes
        /// </summary>
        [JsonPropertyName("m30")]
        public CoinGeckoDexTransactionCounts? ThirtyMinutes { get; set; }

        /// <summary>
        /// ["<c>h1</c>"] One hour
        /// </summary>
        [JsonPropertyName("h1")]
        public CoinGeckoDexTransactionCounts? OneHour { get; set; }

        /// <summary>
        /// ["<c>h6</c>"] Six hours
        /// </summary>
        [JsonPropertyName("h6")]
        public CoinGeckoDexTransactionCounts? SixHours { get; set; }

        /// <summary>
        /// ["<c>h24</c>"] Twenty four hours
        /// </summary>
        [JsonPropertyName("h24")]
        public CoinGeckoDexTransactionCounts? OneDay { get; set; }
    }

    /// <summary>
    /// Dex transaction counts
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTransactionCounts
    {
        /// <summary>
        /// ["<c>buys</c>"] Number of buys
        /// </summary>
        [JsonPropertyName("buys")]
        public int Buys { get; set; }

        /// <summary>
        /// ["<c>sells</c>"] Number of sells
        /// </summary>
        [JsonPropertyName("sells")]
        public int Sells { get; set; }

        /// <summary>
        /// ["<c>buyers</c>"] Number of buyers
        /// </summary>
        [JsonPropertyName("buyers")]
        public int? Buyers { get; set; }

        /// <summary>
        /// ["<c>sellers</c>"] Number of sellers
        /// </summary>
        [JsonPropertyName("sellers")]
        public int? Sellers { get; set; }
    }
}
