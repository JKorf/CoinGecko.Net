using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Market info
    /// </summary>
    public record CoinGeckoMarket
    {
        /// <summary>
        /// Market id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Market symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Image
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// Current price
        /// </summary>
        [JsonPropertyName("current_price")]
        public decimal CurrentPrice { get; set; }
        /// <summary>
        /// Market cap
        /// </summary>
        [JsonPropertyName("market_cap")]
        public decimal MarketCap { get; set; }
        /// <summary>
        /// Market cap rank
        /// </summary>
        [JsonPropertyName("market_cap_rank")]
        public decimal? MarketCapRank { get; set; }
        /// <summary>
        /// Fully diluted valuation
        /// </summary>
        [JsonPropertyName("fully_diluted_valuation")]
        public decimal? FullyDilutedValuation { get; set; }
        /// <summary>
        /// Total trade volume
        /// </summary>
        [JsonPropertyName("total_volume")]
        public decimal TotalVolume { get; set; }
        /// <summary>
        /// 24 hour high price
        /// </summary>
        [JsonPropertyName("high_24h")]
        public decimal? High24h { get; set; }
        /// <summary>
        /// 24 hour low price
        /// </summary>
        [JsonPropertyName("low_24h")]
        public decimal? Low24h { get; set; }
        /// <summary>
        /// 24 hour price change
        /// </summary>
        [JsonPropertyName("price_change_24h")]
        public decimal? PriceChange24h { get; set; }
        /// <summary>
        /// 24 hour price change percentage
        /// </summary>
        [JsonPropertyName("price_change_percentage_24h")]
        public double? PriceChangePercentage24h { get; set; }
        /// <summary>
        /// 24 hour market cap change
        /// </summary>
        [JsonPropertyName("market_cap_change_24h")]
        public decimal? MarketCapChange24h { get; set; }
        /// <summary>
        /// 24 hour market cap change percentage
        /// </summary>
        [JsonPropertyName("market_cap_change_percentage_24h")]
        public double? MarketCapChangePercentage24h { get; set; }
        /// <summary>
        /// Circulating supply
        /// </summary>
        [JsonPropertyName("circulating_supply")]
        public decimal CiculationSupply { get; set; }
        /// <summary>
        /// Total supply
        /// </summary>
        [JsonPropertyName("total_supply")]
        public decimal? TotalSupply { get; set; }
        /// <summary>
        /// Max supply
        /// </summary>
        [JsonPropertyName("max_supply")]
        public decimal? MaxSupply { get; set; }
        /// <summary>
        /// All time high price
        /// </summary>
        [JsonPropertyName("ath")]
        public decimal AllTimeHigh { get; set; }
        /// <summary>
        /// All time high change percentage
        /// </summary>
        [JsonPropertyName("ath_change_percentage")]
        public double AllTimeHighChangePercentage { get; set; }
        /// <summary>
        /// All time high time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("ath_date")]
        public DateTime AllTimeHighTimestamp { get; set; }
        /// <summary>
        /// All time low price
        /// </summary>
        [JsonPropertyName("atl")]
        public decimal AllTimeLow { get; set; }
        /// <summary>
        /// All time low change percentage
        /// </summary>
        [JsonPropertyName("atl_change_percentage")]
        public double AllTimeLowChangePercentage { get; set; }
        /// <summary>
        /// All time low time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("atl_date")]
        public DateTime AllTimeLowTimestamp { get; set; }
        /// <summary>
        /// Return on investment
        /// </summary>
        [JsonPropertyName("roi")]
        public CoinGeckoMarketRoi? Roi { get; set; }
        /// <summary>
        /// Last updated timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("last_updated")]
        public DateTime LastUpdated { get; set; }
    }

    /// <summary>
    /// Market return on investment info
    /// </summary>
    public record CoinGeckoMarketRoi
    {
        /// <summary>
        /// Times
        /// </summary>
        [JsonPropertyName("times")]
        public decimal Times { get; set; }
        /// <summary>
        /// Investment asset
        /// </summary>
        [JsonPropertyName("currency")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// Profit percentage
        /// </summary>
        [JsonPropertyName("percentage")]
        public decimal Percentage { get; set; }
    }
}
