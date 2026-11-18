using CoinGecko.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex Pool Trades Response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolTradesResponse
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoDexPoolTradesResponseData[] Data { get; set; } = [];
        /// <summary>
        /// ["<c>meta</c>"] Meta
        /// </summary>
        [JsonPropertyName("meta")]
        public CoinGeckoDexPoolTradesResponseMeta? Meta { get; set; }
    }

    /// <summary>
    /// Dex Pool Trades Response Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolTradesResponseData
    {
        /// <summary>
        /// ["<c>id</c>"] Trade identifier
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
        public CoinGeckoDexPoolTradesResponseDataAttributes Attributes { get; set; } = new();
    }

    /// <summary>
    /// Dex Pool Trades Response Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolTradesResponseDataAttributes
    {
        /// <summary>
        /// ["<c>block_number</c>"] Block number of the trade
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
        /// ["<c>from_token_amount</c>"] Amount of token sent
        /// </summary>
        [JsonPropertyName("from_token_amount")]
        public decimal FromTokenAmount { get; set; }
        /// <summary>
        /// ["<c>to_token_amount</c>"] Amount of token received
        /// </summary>
        [JsonPropertyName("to_token_amount")]
        public decimal ToTokenAmount { get; set; }
        /// <summary>
        /// ["<c>price_from_in_currency_token</c>"] Price of from-token in currency token
        /// </summary>
        [JsonPropertyName("price_from_in_currency_token")]
        public decimal PriceFromInCurrencyToken { get; set; }
        /// <summary>
        /// ["<c>price_to_in_currency_token</c>"] Price of to-token in currency token
        /// </summary>
        [JsonPropertyName("price_to_in_currency_token")]
        public decimal PriceToInCurrencyToken { get; set; }
        /// <summary>
        /// ["<c>price_from_in_usd</c>"] Price of from-token in USD
        /// </summary>
        [JsonPropertyName("price_from_in_usd")]
        public decimal PriceFromInUsd { get; set; }
        /// <summary>
        /// ["<c>price_to_in_usd</c>"] Price of to-token in USD
        /// </summary>
        [JsonPropertyName("price_to_in_usd")]
        public decimal PriceToInUsd { get; set; }
        /// <summary>
        /// ["<c>block_timestamp</c>"] Block timestamp
        /// </summary>
        [JsonPropertyName("block_timestamp")]
        public DateTime BlockTimestamp { get; set; }
        /// <summary>
        /// ["<c>kind</c>"] Trade kind (buy or sell)
        /// </summary>
        [JsonPropertyName("kind")]
        public TradeSide Kind { get; set; }
        /// <summary>
        /// ["<c>volume_in_usd</c>"] Trade volume in USD
        /// </summary>
        [JsonPropertyName("volume_in_usd")]
        public decimal VolumeInUsd { get; set; }
        /// <summary>
        /// ["<c>from_token_address</c>"] From-token contract address
        /// </summary>
        [JsonPropertyName("from_token_address")]
        public string FromTokenAddress { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>to_token_address</c>"] To-token contract address
        /// </summary>
        [JsonPropertyName("to_token_address")]
        public string ToTokenAddress { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>is_anomalous</c>"] Whether the trade is flagged as anomalous
        /// </summary>
        [JsonPropertyName("is_anomalous")]
        public bool IsAnomalous { get; set; }
    }

    /// <summary>
    /// Dex Pool Trades Response Meta
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolTradesResponseMeta
    {
        /// <summary>
        /// ["<c>next_cursor</c>"] Cursor for the next page, null when there are no further pages
        /// </summary>
        [JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
