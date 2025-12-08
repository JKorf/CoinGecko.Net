using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Company holdings
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCompanyHolding
    {
        /// <summary>
        /// Total holdings
        /// </summary>
        [JsonPropertyName("total_holdings")]
        public decimal TotalHoldings { get; set; }
        /// <summary>
        /// Total value in USD
        /// </summary>
        [JsonPropertyName("total_value_usd")]
        public decimal TotalValueUsd { get; set; }
        /// <summary>
        /// Market cap dominance
        /// </summary>
        [JsonPropertyName("market_cap_dominance")]
        public decimal MarketCapDominance { get; set; }
        /// <summary>
        /// Companies
        /// </summary>
        [JsonPropertyName("companies")]
        public CoinGeckoCompanyAsset[] Companies { get; set; } = Array.Empty<CoinGeckoCompanyAsset>();
    }

    /// <summary>
    /// Company holding
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCompanyAsset
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Country
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;
        /// <summary>
        /// Total holdings
        /// </summary>
        [JsonPropertyName("total_holdings")]
        public decimal TotalHoldings { get; set; }
        /// <summary>
        /// Total entry value USD
        /// </summary>
        [JsonPropertyName("total_entry_value_usd")]
        public decimal TotalEntryValueUsd { get; set; }
        /// <summary>
        /// Total current value USD
        /// </summary>
        [JsonPropertyName("total_current_value_usd")]
        public decimal TotalCurrentValueUsd { get; set; }
        /// <summary>
        /// Percentage of total supply
        /// </summary>
        [JsonPropertyName("percentage_of_total_supply")]
        public decimal PercentageOfTotalSupply { get; set; }
    }


}
