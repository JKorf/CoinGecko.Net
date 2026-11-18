using System;
using CoinGecko.Net.Enums;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Public Treasury Transaction History
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPublicTreasuryTransactionHistory
    {
        /// <summary>
        /// ["<c>transactions</c>"] Transactions
        /// </summary>
        [JsonPropertyName("transactions")]
        public CoinGeckoPublicTreasuryTransactionHistoryTransaction[] Transactions { get; set; } = [];
    }

    /// <summary>
    /// Public Treasury Transaction History Transaction
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPublicTreasuryTransactionHistoryTransaction
    {
        /// <summary>
        /// ["<c>date</c>"] Transaction date in UNIX timestamp
        /// </summary>
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        /// <summary>
        /// ["<c>source_url</c>"] Source document URL
        /// </summary>
        [JsonPropertyName("source_url")]
        public string SourceUrl { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>coin_id</c>"] Coin ID
        /// </summary>
        [JsonPropertyName("coin_id")]
        public string CoinId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>type</c>"] Transaction type
        /// </summary>
        [JsonPropertyName("type")]
        public TradeSide Type { get; set; }
        /// <summary>
        /// ["<c>holding_net_change</c>"] Net change in holdings after the transaction
        /// </summary>
        [JsonPropertyName("holding_net_change")]
        public decimal HoldingNetChange { get; set; }
        /// <summary>
        /// ["<c>transaction_value_usd</c>"] Transaction value in USD
        /// </summary>
        [JsonPropertyName("transaction_value_usd")]
        public decimal TransactionValueUsd { get; set; }
        /// <summary>
        /// ["<c>holding_balance</c>"] Total holding balance after the transaction
        /// </summary>
        [JsonPropertyName("holding_balance")]
        public decimal HoldingBalance { get; set; }
        /// <summary>
        /// ["<c>average_entry_value_usd</c>"] Average entry value in USD after the transaction
        /// </summary>
        [JsonPropertyName("average_entry_value_usd")]
        public decimal AverageEntryValueUsd { get; set; }
    }
}
