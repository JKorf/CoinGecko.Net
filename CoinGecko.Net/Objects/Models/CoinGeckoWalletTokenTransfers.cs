using CoinGecko.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Wallet Token Transfers
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletTokenTransfers
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoWalletTokenTransfersData[] Data { get; set; } = [];
        /// <summary>
        /// ["<c>meta</c>"] Meta
        /// </summary>
        [JsonPropertyName("meta")]
        public CoinGeckoWalletTokenTransfersMeta Meta { get; set; } = new();
    }

    /// <summary>
    /// Wallet Token Transfers Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletTokenTransfersData
    {
        /// <summary>
        /// ["<c>id</c>"] Transfer identifier
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
        public CoinGeckoWalletTokenTransfersDataAttributes Attributes { get; set; } = new();
    }

    /// <summary>
    /// Wallet Token Transfers Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletTokenTransfersDataAttributes
    {
        /// <summary>
        /// ["<c>block_number</c>"] Block number of the transfer
        /// </summary>
        [JsonPropertyName("block_number")]
        public long BlockNumber { get; set; }
        /// <summary>
        /// ["<c>tx_hash</c>"] Transaction hash
        /// </summary>
        [JsonPropertyName("tx_hash")]
        public string TxHash { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>direction</c>"] Transfer direction relative to the queried wallet, either in or out
        /// </summary>
        [JsonPropertyName("direction")]
        public WalletTokenTransfersDirection Direction { get; set; }
        /// <summary>
        /// ["<c>token_address</c>"] Token contract address
        /// </summary>
        [JsonPropertyName("token_address")]
        public string TokenAddress { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>amount_raw</c>"] Transfer amount in the smallest unit, before decimals are applied
        /// </summary>
        [JsonPropertyName("amount_raw")]
        public decimal AmountRaw { get; set; }
        /// <summary>
        /// ["<c>amount</c>"] Transfer amount at full precision
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }
        /// <summary>
        /// ["<c>block_timestamp</c>"] Block timestamp of the transfer
        /// </summary>
        [JsonPropertyName("block_timestamp")]
        public DateTime BlockTimestamp { get; set; }
        /// <summary>
        /// ["<c>from_address</c>"] Sender address
        /// </summary>
        [JsonPropertyName("from_address")]
        public string FromAddress { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>to_address</c>"] Recipient address
        /// </summary>
        [JsonPropertyName("to_address")]
        public string ToAddress { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Token name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Token symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>decimals</c>"] Token decimals
        /// </summary>
        [JsonPropertyName("decimals")]
        public long Decimals { get; set; }
    }

    /// <summary>
    /// Wallet Token Transfers Meta
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletTokenTransfersMeta
    {
        /// <summary>
        /// ["<c>next_cursor</c>"] Cursor for the next page, null when there are no further pages
        /// </summary>
        [JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
