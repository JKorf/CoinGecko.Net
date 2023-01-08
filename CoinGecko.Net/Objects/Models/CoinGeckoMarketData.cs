using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Market data
    /// </summary>
    public class CoinGeckoMarketData
    {
        /// <summary>
        /// Current price
        /// </summary>
        [JsonProperty("current_price")]
        public Dictionary<string, decimal> CurrentPrice { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Total value locked
        /// </summary>
        [JsonProperty("total_value_locked")]
        public decimal? TotalValueLocked { get; set; }
        /// <summary>
        /// Market cap to total value locked ratio
        /// </summary>
        [JsonProperty("mcap_to_tvl_ratio")]
        public decimal? MarketCapToTotalValueLockedRatio { get; set; }
        /// <summary>
        /// Fully diluted valuation to total value locked ratio
        /// </summary>
        [JsonProperty("fdv_to_tvl_ratio")]
        public decimal? FullyDilutedValuationToTotalValueLockedRatio { get; set; }
        /// <summary>
        /// Return on investment
        /// </summary>
        public CoinGeckoMarketRoi? Roi { get; set; }
        /// <summary>
        /// All time high prices
        /// </summary>
        [JsonProperty("ath")]
        public Dictionary<string, decimal> AllTimeHighs { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Current price change vs all time high
        /// </summary>
        [JsonProperty("ath_change_percentage")]
        public Dictionary<string, decimal> AllTimeHighChangePercentages { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// All time high dates
        /// </summary>
        [JsonProperty("ath_date")]
        public Dictionary<string, DateTime> AllTimeHighDates { get; set; } = new Dictionary<string, DateTime>();
        /// <summary>
        /// All time low prices
        /// </summary>
        [JsonProperty("atl")]
        public Dictionary<string, decimal> AllTimeLows { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Current price change vs all time low
        /// </summary>
        [JsonProperty("atl_change_percentage")]
        public Dictionary<string, decimal> AllTimeLowChangePercentages { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// All time low dates
        /// </summary>
        [JsonProperty("atl_date")]
        public Dictionary<string, DateTime> AllTimeLowDates { get; set; } = new Dictionary<string, DateTime>();
        /// <summary>
        /// Market caps
        /// </summary>
        [JsonProperty("market_cap")]
        public Dictionary<string, decimal> MarketCaps { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Market cap rank
        /// </summary>
        [JsonProperty("market_cap_rank")]
        public int? MarketCapRank { get; set; }
        /// <summary>
        /// Fully diluted valuation
        /// </summary>
        [JsonProperty("fully_diluted_valuation")]
        public Dictionary<string, decimal> FullyDilutedValuations { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Total volumes
        /// </summary>
        [JsonProperty("total_volume")]
        public Dictionary<string, decimal> TotalVolumes { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// 24h high prices
        /// </summary>
        [JsonProperty("high_24h")]
        public Dictionary<string, decimal?> High24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 24h low prices
        /// </summary>
        [JsonProperty("low_24h")]
        public Dictionary<string, decimal?> Low24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 24h price change
        /// </summary>
        [JsonProperty("price_change_24h")]
        public decimal? PriceChange24h { get; set; }
        /// <summary>
        /// 24h price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_24h")]
        public decimal? PriceChangePercentage24h { get; set; }
        /// <summary>
        /// 7 day price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_7d")]
        public decimal PriceChangePercentage7d { get; set; }
        /// <summary>
        /// 14 day price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_14d")]
        public decimal PriceChangePercentage14d { get; set; }
        /// <summary>
        /// 30 day price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_30d")]
        public decimal PriceChangePercentage30d { get; set; }
        /// <summary>
        /// 60 day price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_60d")]
        public decimal PriceChangePercentage60d { get; set; }
        /// <summary>
        /// 200 day price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_200d")]
        public decimal PriceChangePercentage200d { get; set; }
        /// <summary>
        /// 1 year price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_1y")]
        public decimal PriceChangePercentage1y { get; set; }
        /// <summary>
        /// 24 hour market cap change
        /// </summary>
        [JsonProperty("market_cap_change_24h")]
        public decimal? MarketCapChange24h { get; set; }
        /// <summary>
        /// 24 hour market cap change
        /// </summary>
        [JsonProperty("market_cap_change_percentage_24h")]
        public decimal? MarketCapChangePercentage24h { get; set; }
        /// <summary>
        /// 24h price changes
        /// </summary>
        [JsonProperty("price_change_24h_in_currency")]
        public Dictionary<string, decimal?> PriceChanges24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 1h price changes percentages
        /// </summary>
        [JsonProperty("price_change_percentage_1h_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages1h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 24h price changes percentages
        /// </summary>
        [JsonProperty("price_change_percentage_24h_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 7d price change percentages
        /// </summary>
        [JsonProperty("price_change_percentage_7d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages7d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 14d price change percentages
        /// </summary>
        [JsonProperty("price_change_percentage_14d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages14d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 30d price change percentages
        /// </summary>
        [JsonProperty("price_change_percentage_30d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages30d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 60d price change percentages
        /// </summary>
        [JsonProperty("price_change_percentage_60d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages60d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 200d price change percentages
        /// </summary>
        [JsonProperty("price_change_percentage_200d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages200d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 1y price change percentages
        /// </summary>
        [JsonProperty("price_change_percentage_1y_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages1y { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 24h market cap changes
        /// </summary>
        [JsonProperty("market_cap_change_24h_in_currency")]
        public Dictionary<string, decimal?> MarketCapChanges24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 24h market cap change percentages
        /// </summary>
        [JsonProperty("market_cap_change_percentage_24h_in_currency")]
        public Dictionary<string, decimal?> MarketCapChangePercentages24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// Total supply
        /// </summary>
        [JsonProperty("total_supply")]
        public decimal? TotalSupply { get; set; }
        /// <summary>
        /// Max supply
        /// </summary>
        [JsonProperty("max_supply")]
        public decimal? MaxSupply { get; set; }
        /// <summary>
        /// Circulating supply
        /// </summary>
        [JsonProperty("circulating_supply")]
        public decimal? CirculatingSupply { get; set; }
        /// <summary>
        /// Last updated timestamp
        /// </summary>
        [JsonProperty("last_updated")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? LastUpdated { get; set; }
    }
}
