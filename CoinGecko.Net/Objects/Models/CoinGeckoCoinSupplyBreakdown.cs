using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Coin Supply Breakdown
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCoinSupplyBreakdown
    {
        /// <summary>
        /// ["<c>id</c>"] Coin ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Coin symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Coin name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>supply_data</c>"] Supply data
        /// </summary>
        [JsonPropertyName("supply_data")]
        public CoinGeckoCoinSupplyBreakdownSupplyData SupplyData { get; set; } = new();
        /// <summary>
        /// ["<c>non_circulating_wallets</c>"] List of non-circulating wallets
        /// </summary>
        [JsonPropertyName("non_circulating_wallets")]
        public CoinGeckoCoinSupplyBreakdownNonCirculatingWallet[] NonCirculatingWallets { get; set; } = [];
    }

    /// <summary>
    /// Coin Supply Breakdown Supply Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCoinSupplyBreakdownSupplyData
    {
        /// <summary>
        /// ["<c>total_supply</c>"] Total supply
        /// </summary>
        [JsonPropertyName("total_supply")]
        public decimal? TotalSupply { get; set; }
        /// <summary>
        /// ["<c>circulating_supply</c>"] Circulating supply
        /// </summary>
        [JsonPropertyName("circulating_supply")]
        public decimal? CirculatingSupply { get; set; }
        /// <summary>
        /// ["<c>outstanding_supply</c>"] Outstanding supply
        /// </summary>
        [JsonPropertyName("outstanding_supply")]
        public decimal? OutstandingSupply { get; set; }
        /// <summary>
        /// ["<c>non_circulating_supply</c>"] Non-circulating supply
        /// </summary>
        [JsonPropertyName("non_circulating_supply")]
        public decimal? NonCirculatingSupply { get; set; }
        /// <summary>
        /// ["<c>last_updated</c>"] Last updated timestamp in ISO 8601 format
        /// </summary>
        [JsonPropertyName("last_updated")]
        public DateTime? LastUpdated { get; set; }
    }

    /// <summary>
    /// Coin Supply Breakdown Non Circulating Wallet
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCoinSupplyBreakdownNonCirculatingWallet
    {
        /// <summary>
        /// ["<c>address</c>"] Wallet address
        /// </summary>
        [JsonPropertyName("address")]
        public string? Address { get; set; }
        /// <summary>
        /// ["<c>label</c>"] Wallet label
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        /// <summary>
        /// ["<c>balance</c>"] Wallet balance
        /// </summary>
        [JsonPropertyName("balance")]
        public decimal? Balance { get; set; }
        /// <summary>
        /// ["<c>percentage_of_total_supply</c>"] Percentage of total supply held by this wallet
        /// </summary>
        [JsonPropertyName("percentage_of_total_supply")]
        public decimal? PercentageOfTotalSupply { get; set; }
        /// <summary>
        /// ["<c>anomaly</c>"] Indicates an unreliable balance update; when true, circulating supply falls back to the last known-good balance
        /// </summary>
        [JsonPropertyName("anomaly")]
        public bool? Anomaly { get; set; }
        /// <summary>
        /// ["<c>last_updated</c>"] Last updated timestamp in ISO 8601 format
        /// </summary>
        [JsonPropertyName("last_updated")]
        public DateTime? LastUpdated { get; set; }
    }
}
