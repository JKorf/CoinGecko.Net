using CoinGecko.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Pool Liquidity Events
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolLiquidityEvents
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoPoolLiquidityEventsData[] Data { get; set; } = [];
        /// <summary>
        /// ["<c>meta</c>"] Meta
        /// </summary>
        [JsonPropertyName("meta")]
        public CoinGeckoPoolLiquidityEventsMeta? Meta { get; set; }
    }

    /// <summary>
    /// Pool Liquidity Events Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolLiquidityEventsData
    {
        /// <summary>
        /// ["<c>id</c>"] Liquidity event identifier
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
        public CoinGeckoPoolLiquidityEventsDataAttributes Attributes { get; set; } = new();
    }

    /// <summary>
    /// Pool Liquidity Events Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolLiquidityEventsDataAttributes
    {
        /// <summary>
        /// ["<c>block_number</c>"] Block number of the liquidity event
        /// </summary>
        [JsonPropertyName("block_number")]
        public long BlockNumber { get; set; }
        /// <summary>
        /// ["<c>tx_hash</c>"] Transaction hash
        /// </summary>
        [JsonPropertyName("tx_hash")]
        public string TxHash { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>tx_from_address</c>"] Transaction sender address
        /// </summary>
        [JsonPropertyName("tx_from_address")]
        public string TxFromAddress { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>block_timestamp</c>"] Block timestamp
        /// </summary>
        [JsonPropertyName("block_timestamp")]
        public DateTime BlockTimestamp { get; set; }
        /// <summary>
        /// ["<c>kind</c>"] Liquidity event kind (add or remove)
        /// </summary>
        [JsonPropertyName("kind")]
        public PoolLiquidityEventsKind Kind { get; set; }
        /// <summary>
        /// ["<c>base_token_address</c>"] Base token contract address
        /// </summary>
        [JsonPropertyName("base_token_address")]
        public string BaseTokenAddress { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>base_token_amount</c>"] Amount of base token added or removed
        /// </summary>
        [JsonPropertyName("base_token_amount")]
        public decimal BaseTokenAmount { get; set; }
        /// <summary>
        /// ["<c>quote_token_address</c>"] Quote token contract address
        /// </summary>
        [JsonPropertyName("quote_token_address")]
        public string QuoteTokenAddress { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>quote_token_amount</c>"] Amount of quote token added or removed
        /// </summary>
        [JsonPropertyName("quote_token_amount")]
        public decimal QuoteTokenAmount { get; set; }
        /// <summary>
        /// ["<c>base_token_price_in_usd</c>"] Price of base token in USD at the time of the event
        /// </summary>
        [JsonPropertyName("base_token_price_in_usd")]
        public decimal BaseTokenPriceInUsd { get; set; }
        /// <summary>
        /// ["<c>quote_token_price_in_usd</c>"] Price of quote token in USD at the time of the event
        /// </summary>
        [JsonPropertyName("quote_token_price_in_usd")]
        public decimal QuoteTokenPriceInUsd { get; set; }
        /// <summary>
        /// ["<c>volume_in_usd</c>"] Total value of the liquidity event in USD
        /// </summary>
        [JsonPropertyName("volume_in_usd")]
        public decimal VolumeInUsd { get; set; }
    }

    /// <summary>
    /// Pool Liquidity Events Meta
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPoolLiquidityEventsMeta
    {
        /// <summary>
        /// ["<c>next_cursor</c>"] Cursor for the next page, null when there are no further pages
        /// </summary>
        [JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
