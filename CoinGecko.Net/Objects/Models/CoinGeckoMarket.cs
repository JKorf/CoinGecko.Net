using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Market info
    /// </summary>
    public class CoinGeckoMarket
    {
        /// <summary>
        /// Market id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Market symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Image
        /// </summary>
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// Current price
        /// </summary>
        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }
        /// <summary>
        /// Market cap
        /// </summary>
        [JsonProperty("market_cap")]
        public decimal MarketCap { get; set; }
        /// <summary>
        /// Market cap rank
        /// </summary>
        [JsonProperty("market_cap_rank")]
        public decimal MarketCapRank { get; set; }
        /// <summary>
        /// Fully diluted valuation
        /// </summary>
        [JsonProperty("fully_diluted_valuation")]
        public decimal? FullyDilutedValuation { get; set; }
        /// <summary>
        /// Total trade volume
        /// </summary>
        [JsonProperty("total_volume")]
        public decimal TotalVolume { get; set; }
        /// <summary>
        /// 24 hour high price
        /// </summary>
        [JsonProperty("high_24h")]
        public decimal High24h { get; set; }
        /// <summary>
        /// 24 hour low price
        /// </summary>
        [JsonProperty("low_24h")]
        public decimal Low24h { get; set; }
        /// <summary>
        /// 24 hour price change
        /// </summary>
        [JsonProperty("price_change_24h")]
        public decimal PriceChange24h { get; set; }
        /// <summary>
        /// 24 hour price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_24h")]
        public decimal PriceChangePercentage24h { get; set; }
        /// <summary>
        /// 24 hour market cap change
        /// </summary>
        [JsonProperty("market_cap_change_24h")]
        public decimal MarketCapChange24h { get; set; }
        /// <summary>
        /// 24 hour market cap change percentage
        /// </summary>
        [JsonProperty("market_cap_change_percentage_24h")]
        public decimal MarketCapChangePercentage24h { get; set; }
        /// <summary>
        /// Circulating supply
        /// </summary>
        [JsonProperty("circulating_supply")]
        public decimal CiculationSupply { get; set; }
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
        /// All time high price
        /// </summary>
        [JsonProperty("ath")]
        public decimal AllTimeHigh { get; set; }
        /// <summary>
        /// All time high change percentage
        /// </summary>
        [JsonProperty("ath_change_percentage")]
        public decimal AllTimeHighChangePercentage { get; set; }
        /// <summary>
        /// All time high time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("ath_date")]
        public DateTime AllTimeHighTimestamp { get; set; }
        /// <summary>
        /// All time low price
        /// </summary>
        [JsonProperty("atl")]
        public decimal AllTimeLow { get; set; }
        /// <summary>
        /// All time low change percentage
        /// </summary>
        [JsonProperty("atl_change_percentage")]
        public decimal AllTimeLowChangePercentage { get; set; }
        /// <summary>
        /// All time low time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("atl_date")]
        public DateTime AllTimeLowTimestamp { get; set; }
        /// <summary>
        /// Return on investment
        /// </summary>
        public CoinGeckoMarketRoi? Roi { get; set; }
        /// <summary>
        /// Last updated timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }
    }

    /// <summary>
    /// Market raturn on investment info
    /// </summary>
    public class CoinGeckoMarketRoi
    {
        /// <summary>
        /// Times
        /// </summary>
        public decimal Times { get; set; }
        /// <summary>
        /// Investment asset
        /// </summary>
        [JsonProperty("currency")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// Profit percentage
        /// </summary>
        public decimal Percentage { get; set; }
    }
}
