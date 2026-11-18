using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Wallet Pnl
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletPnl
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoWalletPnlData Data { get; set; } = new();
    }

    /// <summary>
    /// Wallet Pnl Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletPnlData
    {
        /// <summary>
        /// ["<c>id</c>"] Wallet address
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>type</c>"] Response type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>attributes</c>"] Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public CoinGeckoWalletPnlDataAttributes Attributes { get; set; } = new();
    }

    /// <summary>
    /// Wallet Pnl Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletPnlDataAttributes
    {
        /// <summary>
        /// ["<c>wallet_address</c>"] Wallet address queried
        /// </summary>
        [JsonPropertyName("wallet_address")]
        public string WalletAddress { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>total_realized_pnl_usd</c>"] All-time realized PnL in USD, across the requested networks only
        /// </summary>
        [JsonPropertyName("total_realized_pnl_usd")]
        public decimal TotalRealizedPnlUsd { get; set; }
        /// <summary>
        /// ["<c>total_unrealized_pnl_usd</c>"] All-time unrealized PnL in USD, across the requested networks only
        /// </summary>
        [JsonPropertyName("total_unrealized_pnl_usd")]
        public decimal TotalUnrealizedPnlUsd { get; set; }
        /// <summary>
        /// ["<c>total_tokens</c>"] Number of tokens traded across the requested networks only
        /// </summary>
        [JsonPropertyName("total_tokens")]
        public long TotalTokens { get; set; }
        /// <summary>
        /// ["<c>networks</c>"] Realized PnL, unrealized PnL and token count per network, listing only networks where the wallet traded
        /// </summary>
        [JsonPropertyName("networks")]
        public CoinGeckoWalletPnlDataAttributesNetwork[] Networks { get; set; } = [];
        /// <summary>
        /// ["<c>token_stats</c>"] Trading stats and PnL, one entry per token
        /// </summary>
        [JsonPropertyName("token_stats")]
        public CoinGeckoWalletPnlDataAttributesTokenStat[] TokenStats { get; set; } = [];
    }

    /// <summary>
    /// Wallet Pnl Data Attributes Network
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletPnlDataAttributesNetwork
    {
        /// <summary>
        /// ["<c>network</c>"] Network ID
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>realized_pnl_usd</c>"] Realized PnL on this network in USD
        /// </summary>
        [JsonPropertyName("realized_pnl_usd")]
        public decimal RealizedPnlUsd { get; set; }
        /// <summary>
        /// ["<c>unrealized_pnl_usd</c>"] Unrealized PnL on this network in USD
        /// </summary>
        [JsonPropertyName("unrealized_pnl_usd")]
        public decimal UnrealizedPnlUsd { get; set; }
        /// <summary>
        /// ["<c>tokens</c>"] Number of tokens traded on this network
        /// </summary>
        [JsonPropertyName("tokens")]
        public long Tokens { get; set; }
    }

    /// <summary>
    /// Wallet Pnl Data Attributes Token Stat
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletPnlDataAttributesTokenStat
    {
        /// <summary>
        /// ["<c>network</c>"] Network ID
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>address</c>"] Token contract address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;
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
        /// <summary>
        /// ["<c>realized_pnl_usd</c>"] Realized PnL in USD
        /// </summary>
        [JsonPropertyName("realized_pnl_usd")]
        public decimal RealizedPnlUsd { get; set; }
        /// <summary>
        /// ["<c>unrealized_pnl_usd</c>"] Unrealized PnL in USD
        /// </summary>
        [JsonPropertyName("unrealized_pnl_usd")]
        public string? UnrealizedPnlUsd { get; set; }
        /// <summary>
        /// ["<c>average_buy_price_usd</c>"] Average buy price in USD
        /// </summary>
        [JsonPropertyName("average_buy_price_usd")]
        public decimal AverageBuyPriceUsd { get; set; }
        /// <summary>
        /// ["<c>average_sell_price_usd</c>"] Average sell price in USD
        /// </summary>
        [JsonPropertyName("average_sell_price_usd")]
        public decimal AverageSellPriceUsd { get; set; }
        /// <summary>
        /// ["<c>total_buy_count</c>"] Total number of buy transactions
        /// </summary>
        [JsonPropertyName("total_buy_count")]
        public long TotalBuyCount { get; set; }
        /// <summary>
        /// ["<c>total_sell_count</c>"] Total number of sell transactions
        /// </summary>
        [JsonPropertyName("total_sell_count")]
        public long TotalSellCount { get; set; }
        /// <summary>
        /// ["<c>total_buy_token_amount</c>"] Total buy token amount
        /// </summary>
        [JsonPropertyName("total_buy_token_amount")]
        public decimal TotalBuyTokenAmount { get; set; }
        /// <summary>
        /// ["<c>total_sell_token_amount</c>"] Total sell token amount
        /// </summary>
        [JsonPropertyName("total_sell_token_amount")]
        public decimal TotalSellTokenAmount { get; set; }
        /// <summary>
        /// ["<c>total_buy_usd</c>"] Total buy amount in USD
        /// </summary>
        [JsonPropertyName("total_buy_usd")]
        public decimal TotalBuyUsd { get; set; }
        /// <summary>
        /// ["<c>total_sell_usd</c>"] Total sell amount in USD
        /// </summary>
        [JsonPropertyName("total_sell_usd")]
        public decimal TotalSellUsd { get; set; }
    }
}
