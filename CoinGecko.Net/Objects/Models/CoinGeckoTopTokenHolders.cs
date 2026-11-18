using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Top Token Holders
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTopTokenHolders
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoTopTokenHoldersData Data { get; set; } = new();
    }

    /// <summary>
    /// Top Token Holders Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTopTokenHoldersData
    {
        /// <summary>
        /// ["<c>id</c>"] Token identifier
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
        public CoinGeckoTopTokenHoldersDataAttributes Attributes { get; set; } = new();
    }

    /// <summary>
    /// Top Token Holders Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTopTokenHoldersDataAttributes
    {
        /// <summary>
        /// ["<c>last_updated_at</c>"] Data last updated timestamp
        /// </summary>
        [JsonPropertyName("last_updated_at")]
        public DateTime LastUpdatedAt { get; set; }
        /// <summary>
        /// ["<c>holders</c>"] Holders
        /// </summary>
        [JsonPropertyName("holders")]
        public CoinGeckoTopTokenHoldersDataAttributesHolder[] Holders { get; set; } = [];
    }

    /// <summary>
    /// Top Token Holders Data Attributes Holder
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTopTokenHoldersDataAttributesHolder
    {
        /// <summary>
        /// ["<c>rank</c>"] Holder rank
        /// </summary>
        [JsonPropertyName("rank")]
        public long Rank { get; set; }
        /// <summary>
        /// ["<c>address</c>"] Holder wallet address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>label</c>"] Address label
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        /// <summary>
        /// ["<c>amount</c>"] Token amount held
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// ["<c>percentage</c>"] Percentage of total supply held
        /// </summary>
        [JsonPropertyName("percentage")]
        public decimal Percentage { get; set; }
        /// <summary>
        /// ["<c>value</c>"] Value of holdings in USD
        /// </summary>
        [JsonPropertyName("value")]
        public decimal Value { get; set; }
        /// <summary>
        /// ["<c>average_buy_price_usd</c>"] Average buy price in USD
        /// </summary>
        [JsonPropertyName("average_buy_price_usd")]
        public string? AverageBuyPriceUsd { get; set; }
        /// <summary>
        /// ["<c>total_buy_count</c>"] Total number of buy transactions
        /// </summary>
        [JsonPropertyName("total_buy_count")]
        public long? TotalBuyCount { get; set; }
        /// <summary>
        /// ["<c>total_sell_count</c>"] Total number of sell transactions
        /// </summary>
        [JsonPropertyName("total_sell_count")]
        public long? TotalSellCount { get; set; }
        /// <summary>
        /// ["<c>unrealized_pnl_usd</c>"] Unrealized PnL in USD
        /// </summary>
        [JsonPropertyName("unrealized_pnl_usd")]
        public string? UnrealizedPnlUsd { get; set; }
        /// <summary>
        /// ["<c>unrealized_pnl_percentage</c>"] Unrealized PnL percentage
        /// </summary>
        [JsonPropertyName("unrealized_pnl_percentage")]
        public string? UnrealizedPnlPercentage { get; set; }
        /// <summary>
        /// ["<c>realized_pnl_usd</c>"] Realized PnL in USD
        /// </summary>
        [JsonPropertyName("realized_pnl_usd")]
        public string? RealizedPnlUsd { get; set; }
        /// <summary>
        /// ["<c>realized_pnl_percentage</c>"] Realized PnL percentage
        /// </summary>
        [JsonPropertyName("realized_pnl_percentage")]
        public string? RealizedPnlPercentage { get; set; }
        /// <summary>
        /// ["<c>explorer_url</c>"] Block explorer URL for the holder address
        /// </summary>
        [JsonPropertyName("explorer_url")]
        public string? ExplorerUrl { get; set; }
    }
}
