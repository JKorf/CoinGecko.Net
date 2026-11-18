using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Wallet Token Balances
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletTokenBalances
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoWalletTokenBalancesData Data { get; set; } = new();
    }

    /// <summary>
    /// Wallet Token Balances Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletTokenBalancesData
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
        public CoinGeckoWalletTokenBalancesDataAttributes Attributes { get; set; } = new();
    }

    /// <summary>
    /// Wallet Token Balances Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletTokenBalancesDataAttributes
    {
        /// <summary>
        /// ["<c>wallet_address</c>"] Wallet address queried
        /// </summary>
        [JsonPropertyName("wallet_address")]
        public string WalletAddress { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>total_value_usd</c>"] Total value of matching holdings in USD, across the requested networks only
        /// </summary>
        [JsonPropertyName("total_value_usd")]
        public decimal TotalValueUsd { get; set; }
        /// <summary>
        /// ["<c>total_holdings</c>"] Number of matching holdings across the requested networks only
        /// </summary>
        [JsonPropertyName("total_holdings")]
        public long TotalHoldings { get; set; }
        /// <summary>
        /// ["<c>networks</c>"] Value and holding count per network, listing only networks holding a matching balance
        /// </summary>
        [JsonPropertyName("networks")]
        public CoinGeckoWalletTokenBalancesDataAttributesNetwork[] Networks { get; set; } = [];
        /// <summary>
        /// ["<c>balances</c>"] Token holdings, one entry per token
        /// </summary>
        [JsonPropertyName("balances")]
        public CoinGeckoWalletTokenBalancesDataAttributesBalance[] Balances { get; set; } = [];
    }

    /// <summary>
    /// Wallet Token Balances Data Attributes Network
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletTokenBalancesDataAttributesNetwork
    {
        /// <summary>
        /// ["<c>network</c>"] Network ID
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>value_usd</c>"] Total value of matching holdings on this network in USD
        /// </summary>
        [JsonPropertyName("value_usd")]
        public decimal ValueUsd { get; set; }
        /// <summary>
        /// ["<c>holdings</c>"] Number of matching holdings on this network
        /// </summary>
        [JsonPropertyName("holdings")]
        public long Holdings { get; set; }
        /// <summary>
        /// ["<c>last_updated_at</c>"] Last updated timestamp
        /// </summary>
        [JsonPropertyName("last_updated_at")]
        public DateTime LastUpdatedAt { get; set; }
    }

    /// <summary>
    /// Wallet Token Balances Data Attributes Balance
    /// </summary>
    [SerializationModel]
    public record CoinGeckoWalletTokenBalancesDataAttributesBalance
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
        /// ["<c>token_type</c>"] Token type, such as native, erc20 or spl
        /// </summary>
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; } = string.Empty;
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
        /// ["<c>coingecko_coin_id</c>"] CoinGecko coin ID
        /// </summary>
        [JsonPropertyName("coingecko_coin_id")]
        public string? CoingeckoCoinId { get; set; }
        /// <summary>
        /// ["<c>balance_raw</c>"] Token balance in the smallest unit, before decimals are applied
        /// </summary>
        [JsonPropertyName("balance_raw")]
        public decimal BalanceRaw { get; set; }
        /// <summary>
        /// ["<c>balance</c>"] Token balance at full precision
        /// </summary>
        [JsonPropertyName("balance")]
        public decimal? Balance { get; set; }
        /// <summary>
        /// ["<c>price_usd</c>"] Token price in USD
        /// </summary>
        [JsonPropertyName("price_usd")]
        public decimal? PriceUsd { get; set; }
        /// <summary>
        /// ["<c>value_usd</c>"] Value of the holding in USD
        /// </summary>
        [JsonPropertyName("value_usd")]
        public decimal? ValueUsd { get; set; }
        /// <summary>
        /// ["<c>h24_price_change_percentage</c>"] 24hr price change percentage
        /// </summary>
        [JsonPropertyName("h24_price_change_percentage")]
        public decimal? H24PriceChangePercentage { get; set; }
        /// <summary>
        /// ["<c>total_reserve_in_usd</c>"] Total reserve in USD across all pools of the token
        /// </summary>
        [JsonPropertyName("total_reserve_in_usd")]
        public decimal? TotalReserveInUsd { get; set; }
    }
}
