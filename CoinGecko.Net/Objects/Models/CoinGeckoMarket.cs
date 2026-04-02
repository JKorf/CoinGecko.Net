using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Market info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMarket
    {
        /// <summary>
        /// ["<c>id</c>"] Market id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Market symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>image</c>"] Image
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>current_price</c>"] Current price
        /// </summary>
        [JsonPropertyName("current_price")]
        public decimal? CurrentPrice { get; set; }
        /// <summary>
        /// ["<c>market_cap</c>"] Market cap
        /// </summary>
        [JsonPropertyName("market_cap")]
        public decimal? MarketCap { get; set; }
        /// <summary>
        /// ["<c>market_cap_rank</c>"] Market cap rank
        /// </summary>
        [JsonPropertyName("market_cap_rank")]
        public decimal? MarketCapRank { get; set; }
        /// <summary>
        /// ["<c>fully_diluted_valuation</c>"] Fully diluted valuation
        /// </summary>
        [JsonPropertyName("fully_diluted_valuation")]
        public decimal? FullyDilutedValuation { get; set; }
        /// <summary>
        /// ["<c>total_volume</c>"] Total trade volume
        /// </summary>
        [JsonPropertyName("total_volume")]
        public decimal? TotalVolume { get; set; }
        /// <summary>
        /// ["<c>high_24h</c>"] 24 hour high price
        /// </summary>
        [JsonPropertyName("high_24h")]
        public decimal? High24h { get; set; }
        /// <summary>
        /// ["<c>low_24h</c>"] 24 hour low price
        /// </summary>
        [JsonPropertyName("low_24h")]
        public decimal? Low24h { get; set; }
        /// <summary>
        /// ["<c>price_change_24h</c>"] 24 hour price change
        /// </summary>
        [JsonPropertyName("price_change_24h")]
        public decimal? PriceChange24h { get; set; }
        /// <summary>
        /// ["<c>price_change_percentage_24h</c>"] 24 hour price change percentage
        /// </summary>
        [JsonPropertyName("price_change_percentage_24h")]
        public double? PriceChangePercentage24h { get; set; }
        /// <summary>
        /// ["<c>market_cap_change_24h</c>"] 24 hour market cap change
        /// </summary>
        [JsonPropertyName("market_cap_change_24h")]
        public decimal? MarketCapChange24h { get; set; }
        /// <summary>
        /// ["<c>market_cap_change_percentage_24h</c>"] 24 hour market cap change percentage
        /// </summary>
        [JsonPropertyName("market_cap_change_percentage_24h")]
        public double? MarketCapChangePercentage24h { get; set; }
        /// <summary>
        /// ["<c>circulating_supply</c>"] Circulating supply
        /// </summary>
        [JsonPropertyName("circulating_supply")]
        public decimal? CirculatingSupply { get; set; }
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
        /// ["<c>ath</c>"] All time high price
        /// </summary>
        [JsonPropertyName("ath")]
        public decimal? AllTimeHigh { get; set; }
        /// <summary>
        /// ["<c>ath_change_percentage</c>"] All time high change percentage
        /// </summary>
        [JsonPropertyName("ath_change_percentage")]
        public double? AllTimeHighChangePercentage { get; set; }
        /// <summary>
        /// All time high time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("ath_date")]
        public DateTime? AllTimeHighTimestamp { get; set; }
        /// <summary>
        /// ["<c>atl</c>"] All time low price
        /// </summary>
        [JsonPropertyName("atl")]
        public decimal? AllTimeLow { get; set; }
        /// <summary>
        /// ["<c>atl_change_percentage</c>"] All time low change percentage
        /// </summary>
        [JsonPropertyName("atl_change_percentage")]
        public double? AllTimeLowChangePercentage { get; set; }
        /// <summary>
        /// All time low time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("atl_date")]
        public DateTime? AllTimeLowTimestamp { get; set; }
        /// <summary>
        /// ["<c>roi</c>"] Return on investment
        /// </summary>
        [JsonPropertyName("roi")]
        public CoinGeckoMarketRoi? Roi { get; set; }
        /// <summary>
        /// Last updated timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("last_updated")]
        public DateTime? LastUpdated { get; set; }
    }

    /// <summary>
    /// Market return on investment info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMarketRoi
    {
        /// <summary>
        /// ["<c>times</c>"] Times
        /// </summary>
        [JsonPropertyName("times")]
        public decimal? Times { get; set; }
        /// <summary>
        /// ["<c>currency</c>"] Investment asset
        /// </summary>
        [JsonPropertyName("currency")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>percentage</c>"] Profit percentage
        /// </summary>
        [JsonPropertyName("percentage")]
        public decimal? Percentage { get; set; }
    }
}
