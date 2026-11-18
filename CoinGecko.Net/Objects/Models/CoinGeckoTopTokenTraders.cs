using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Top Token Traders
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTopTokenTraders
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoTopTokenTradersData Data { get; set; } = new();
    }

    /// <summary>
    /// Top Token Traders Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTopTokenTradersData
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
        public CoinGeckoTopTokenTradersDataAttributes Attributes { get; set; } = new();
    }

    /// <summary>
    /// Top Token Traders Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTopTokenTradersDataAttributes
    {
        /// <summary>
        /// ["<c>traders</c>"] Traders
        /// </summary>
        [JsonPropertyName("traders")]
        public CoinGeckoTopTokenTradersDataAttributesTrader[] Traders { get; set; } = [];
    }

    /// <summary>
    /// Top Token Traders Data Attributes Trader
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTopTokenTradersDataAttributesTrader
    {
        /// <summary>
        /// ["<c>address</c>"] Trader wallet address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Address label name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// ["<c>label</c>"] Address label
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        /// <summary>
        /// ["<c>type</c>"] Address type
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
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
        /// ["<c>token_balance</c>"] Current token balance
        /// </summary>
        [JsonPropertyName("token_balance")]
        public string? TokenBalance { get; set; }
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
        /// <summary>
        /// ["<c>explorer_url</c>"] Block explorer URL for the trader address
        /// </summary>
        [JsonPropertyName("explorer_url")]
        public string ExplorerUrl { get; set; } = string.Empty;
    }
}
