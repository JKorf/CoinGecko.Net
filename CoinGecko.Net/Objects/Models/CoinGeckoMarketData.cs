using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Market data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMarketData
    {
        /// <summary>
        /// ["<c>current_price</c>"] Current price
        /// </summary>
        [JsonPropertyName("current_price")]
        public Dictionary<string, decimal> CurrentPrice { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// ["<c>total_value_locked</c>"] Total value locked
        /// </summary>
        [JsonPropertyName("total_value_locked")]
        public Dictionary<string, decimal>? TotalValueLocked { get; set; }
        /// <summary>
        /// ["<c>mcap_to_tvl_ratio</c>"] Market cap to total value locked ratio
        /// </summary>
        [JsonPropertyName("mcap_to_tvl_ratio")]
        public decimal? MarketCapToTotalValueLockedRatio { get; set; }
        /// <summary>
        /// ["<c>fdv_to_tvl_ratio</c>"] Fully diluted valuation to total value locked ratio
        /// </summary>
        [JsonPropertyName("fdv_to_tvl_ratio")]
        public decimal? FullyDilutedValuationToTotalValueLockedRatio { get; set; }
        /// <summary>
        /// ["<c>roi</c>"] Return on investment
        /// </summary>
        [JsonPropertyName("roi")]
        public CoinGeckoMarketRoi? Roi { get; set; }
        /// <summary>
        /// ["<c>ath</c>"] All time high prices
        /// </summary>
        [JsonPropertyName("ath")]
        public Dictionary<string, decimal?> AllTimeHighs { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>ath_change_percentage</c>"] Current price change vs all time high
        /// </summary>
        [JsonPropertyName("ath_change_percentage")]
        public Dictionary<string, decimal?> AllTimeHighChangePercentages { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>ath_date</c>"] All time high dates
        /// </summary>
        [JsonPropertyName("ath_date")]
        public Dictionary<string, DateTime?> AllTimeHighDates { get; set; } = new Dictionary<string, DateTime?>();
        /// <summary>
        /// ["<c>atl</c>"] All time low prices
        /// </summary>
        [JsonPropertyName("atl")]
        public Dictionary<string, decimal?> AllTimeLows { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>atl_change_percentage</c>"] Current price change vs all time low
        /// </summary>
        [JsonPropertyName("atl_change_percentage")]
        public Dictionary<string, decimal?> AllTimeLowChangePercentages { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>atl_date</c>"] All time low dates
        /// </summary>
        [JsonPropertyName("atl_date")]
        public Dictionary<string, DateTime?> AllTimeLowDates { get; set; } = new Dictionary<string, DateTime?>();
        /// <summary>
        /// ["<c>market_cap</c>"] Market caps
        /// </summary>
        [JsonPropertyName("market_cap")]
        public Dictionary<string, decimal?> MarketCaps { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>market_cap_rank</c>"] Market cap rank
        /// </summary>
        [JsonPropertyName("market_cap_rank")]
        public int? MarketCapRank { get; set; }
        /// <summary>
        /// ["<c>fully_diluted_valuation</c>"] Fully diluted valuation
        /// </summary>
        [JsonPropertyName("fully_diluted_valuation")]
        public Dictionary<string, decimal?> FullyDilutedValuations { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>market_cap_fdv_ratio</c>"] Market cap to fully diluted valuation ratio
        /// </summary>
        [JsonPropertyName("market_cap_fdv_ratio")]
        public decimal? MarketCapToFullyDilutedValuationRatio { get; set; }
        /// <summary>
        /// ["<c>total_volume</c>"] Total volumes
        /// </summary>
        [JsonPropertyName("total_volume")]
        public Dictionary<string, decimal?> TotalVolumes { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>high_24h</c>"] 24h high prices
        /// </summary>
        [JsonPropertyName("high_24h")]
        public Dictionary<string, decimal?> High24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>low_24h</c>"] 24h low prices
        /// </summary>
        [JsonPropertyName("low_24h")]
        public Dictionary<string, decimal?> Low24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>price_change_24h</c>"] 24h price change
        /// </summary>
        [JsonPropertyName("price_change_24h")]
        public decimal? PriceChange24h { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_24h</c>"] 24h price change percentage
        /// </summary>
        [JsonPropertyName("price_change_percentage_24h")]
        public decimal? PriceChangePercentage24h { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_7d</c>"] 7 day price change percentage
        /// </summary>
        [JsonPropertyName("price_change_percentage_7d")]
        public decimal? PriceChangePercentage7d { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_14d</c>"] 14 day price change percentage
        /// </summary>
        [JsonPropertyName("price_change_percentage_14d")]
        public decimal? PriceChangePercentage14d { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_30d</c>"] 30 day price change percentage
        /// </summary>
        [JsonPropertyName("price_change_percentage_30d")]
        public decimal? PriceChangePercentage30d { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_60d</c>"] 60 day price change percentage
        /// </summary>
        [JsonPropertyName("price_change_percentage_60d")]
        public decimal? PriceChangePercentage60d { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_200d</c>"] 200 day price change percentage
        /// </summary>
        [JsonPropertyName("price_change_percentage_200d")]
        public decimal? PriceChangePercentage200d { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_1y</c>"] 1 year price change percentage
        /// </summary>
        [JsonPropertyName("price_change_percentage_1y")]
        public decimal? PriceChangePercentage1y { get; set; }
        /// <summary>
        /// ["<c>market_cap_change_24h</c>"] 24 hour market cap change
        /// </summary>
        [JsonPropertyName("market_cap_change_24h")]
        public decimal? MarketCapChange24h { get; set; }
        /// <summary>
        /// ["<c>market_cap_change_percentage_24h</c>"] 24 hour market cap change
        /// </summary>
        [JsonPropertyName("market_cap_change_percentage_24h")]
        public decimal? MarketCapChangePercentage24h { get; set; }
        /// <summary>
        /// ["<c>price_change_24h_in_currency</c>"] 24h price changes
        /// </summary>
        [JsonPropertyName("price_change_24h_in_currency")]
        public Dictionary<string, decimal?> PriceChanges24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>price_change_percentage_1h_in_currency</c>"] 1h price changes percentages
        /// </summary>
        [JsonPropertyName("price_change_percentage_1h_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages1h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>price_change_percentage_24h_in_currency</c>"] 24h price changes percentages
        /// </summary>
        [JsonPropertyName("price_change_percentage_24h_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>price_change_percentage_7d_in_currency</c>"] 7d price change percentages
        /// </summary>
        [JsonPropertyName("price_change_percentage_7d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages7d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>price_change_percentage_14d_in_currency</c>"] 14d price change percentages
        /// </summary>
        [JsonPropertyName("price_change_percentage_14d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages14d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>price_change_percentage_30d_in_currency</c>"] 30d price change percentages
        /// </summary>
        [JsonPropertyName("price_change_percentage_30d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages30d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>price_change_percentage_60d_in_currency</c>"] 60d price change percentages
        /// </summary>
        [JsonPropertyName("price_change_percentage_60d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages60d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>price_change_percentage_200d_in_currency</c>"] 200d price change percentages
        /// </summary>
        [JsonPropertyName("price_change_percentage_200d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages200d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>price_change_percentage_1y_in_currency</c>"] 1y price change percentages
        /// </summary>
        [JsonPropertyName("price_change_percentage_1y_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages1y { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>market_cap_change_24h_in_currency</c>"] 24h market cap changes
        /// </summary>
        [JsonPropertyName("market_cap_change_24h_in_currency")]
        public Dictionary<string, decimal?> MarketCapChanges24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>market_cap_change_percentage_24h_in_currency</c>"] 24h market cap change percentages
        /// </summary>
        [JsonPropertyName("market_cap_change_percentage_24h_in_currency")]
        public Dictionary<string, decimal?> MarketCapChangePercentages24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>total_supply</c>"] Total supply
        /// </summary>
        [JsonPropertyName("total_supply")]
        public decimal? TotalSupply { get; set; }
        /// <summary>
        /// ["<c>max_supply</c>"] Max supply
        /// </summary>
        [JsonPropertyName("max_supply")]
        public decimal? MaxSupply { get; set; }
        /// <summary>
        /// ["<c>circulating_supply</c>"] Circulating supply
        /// </summary>
        [JsonPropertyName("circulating_supply")]
        public decimal? CirculatingSupply { get; set; }
        /// <summary>
        /// ["<c>last_updated</c>"] Last updated timestamp
        /// </summary>
        [JsonPropertyName("last_updated")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? LastUpdated { get; set; }
    }
}
