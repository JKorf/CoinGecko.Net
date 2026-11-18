using CoinGecko.Net.Enums;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Public Treasury Entity
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPublicTreasuryEntity
    {
        /// <summary>
        /// ["<c>name</c>"] Entity name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>id</c>"] Entity ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>type</c>"] Entity type: company or government
        /// </summary>
        [JsonPropertyName("type")]
        public TreasuryEntityType Type { get; set; }
        /// <summary>
        /// ["<c>symbol</c>"] Stock market ticker symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
        /// <summary>
        /// ["<c>country</c>"] Country code
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>figi</c>"] Financial Instrument Global Identifier (FIGI) of the entity
        /// </summary>
        [JsonPropertyName("figi")]
        public string? Figi { get; set; }
        /// <summary>
        /// ["<c>website_url</c>"] Official website URL
        /// </summary>
        [JsonPropertyName("website_url")]
        public string WebsiteUrl { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>twitter_screen_name</c>"] Official Twitter handle
        /// </summary>
        [JsonPropertyName("twitter_screen_name")]
        public string TwitterScreenName { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>total_treasury_value_usd</c>"] Total current value of all holdings in USD
        /// </summary>
        [JsonPropertyName("total_treasury_value_usd")]
        public decimal TotalTreasuryValueUsd { get; set; }
        /// <summary>
        /// ["<c>unrealized_pnl</c>"] Unrealized profit and loss (current value minus total entry value)
        /// </summary>
        [JsonPropertyName("unrealized_pnl")]
        public decimal UnrealizedPnl { get; set; }
        /// <summary>
        /// ["<c>m_nav</c>"] Market to net asset value ratio
        /// </summary>
        [JsonPropertyName("m_nav")]
        public decimal MNav { get; set; }
        /// <summary>
        /// ["<c>total_asset_value_per_share_usd</c>"] Total asset value per share in USD
        /// </summary>
        [JsonPropertyName("total_asset_value_per_share_usd")]
        public decimal TotalAssetValuePerShareUsd { get; set; }
        /// <summary>
        /// ["<c>holdings</c>"] List of cryptocurrency assets held by the entity
        /// </summary>
        [JsonPropertyName("holdings")]
        public CoinGeckoPublicTreasuryEntityHolding[] Holdings { get; set; } = [];
    }

    /// <summary>
    /// Public Treasury Entity Holding
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPublicTreasuryEntityHolding
    {
        /// <summary>
        /// ["<c>coin_id</c>"] Coin ID
        /// </summary>
        [JsonPropertyName("coin_id")]
        public string CoinId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>amount</c>"] Amount of cryptocurrency held
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// ["<c>percentage_of_total_supply</c>"] Percentage of total crypto supply
        /// </summary>
        [JsonPropertyName("percentage_of_total_supply")]
        public decimal PercentageOfTotalSupply { get; set; }
        /// <summary>
        /// ["<c>amount_per_share</c>"] Amount of cryptocurrency per share
        /// </summary>
        [JsonPropertyName("amount_per_share")]
        public decimal AmountPerShare { get; set; }
        /// <summary>
        /// ["<c>entity_value_usd_percentage</c>"] Percentage of entity's total treasury value
        /// </summary>
        [JsonPropertyName("entity_value_usd_percentage")]
        public decimal EntityValueUsdPercentage { get; set; }
        /// <summary>
        /// ["<c>current_value_usd</c>"] Current value of holdings in USD
        /// </summary>
        [JsonPropertyName("current_value_usd")]
        public decimal CurrentValueUsd { get; set; }
        /// <summary>
        /// ["<c>total_entry_value_usd</c>"] Total entry cost in USD
        /// </summary>
        [JsonPropertyName("total_entry_value_usd")]
        public decimal TotalEntryValueUsd { get; set; }
        /// <summary>
        /// ["<c>average_entry_value_usd</c>"] Average entry cost per unit in USD
        /// </summary>
        [JsonPropertyName("average_entry_value_usd")]
        public decimal AverageEntryValueUsd { get; set; }
        /// <summary>
        /// ["<c>unrealized_pnl</c>"] Unrealized profit and loss for this holding
        /// </summary>
        [JsonPropertyName("unrealized_pnl")]
        public decimal UnrealizedPnl { get; set; }
        /// <summary>
        /// ["<c>holding_amount_change</c>"] Holding amount changes over different timeframes
        /// </summary>
        [JsonPropertyName("holding_amount_change")]
        public CoinGeckoPublicTreasuryEntityHoldingHoldingAmountChange? HoldingAmountChange { get; set; }
        /// <summary>
        /// ["<c>holding_change_percentage</c>"] Holding change percentages over different timeframes
        /// </summary>
        [JsonPropertyName("holding_change_percentage")]
        public CoinGeckoPublicTreasuryEntityHoldingHoldingAmountChange? HoldingChangePercentage { get; set; }
    }

    /// <summary>
    /// Public Treasury Entity Holding Holding Amount Change
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPublicTreasuryEntityHoldingHoldingAmountChange
    {
        /// <summary>
        /// ["<c>7d</c>"] 7d
        /// </summary>
        [JsonPropertyName("7d")]
        public decimal? Days7 { get; set; }
        /// <summary>
        /// ["<c>14d</c>"] 14d
        /// </summary>
        [JsonPropertyName("14d")]
        public decimal? Days14 { get; set; }
        /// <summary>
        /// ["<c>30d</c>"] 30d
        /// </summary>
        [JsonPropertyName("30d")]
        public decimal? Days30 { get; set; }
        /// <summary>
        /// ["<c>90d</c>"] 90d
        /// </summary>
        [JsonPropertyName("90d")]
        public decimal? Days90 { get; set; }
        /// <summary>
        /// ["<c>1y</c>"] 1y
        /// </summary>
        [JsonPropertyName("1y")]
        public decimal? Years1 { get; set; }
        /// <summary>
        /// ["<c>ytd</c>"] Ytd
        /// </summary>
        [JsonPropertyName("ytd")]
        public decimal? Ytd { get; set; }
    }
}
