using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Derivative info
    /// </summary>
    public record CoinGeckoDerivative
    {
        /// <summary>
        /// Market
        /// </summary>
        [JsonPropertyName("market")]
        public string Market { get; set; } = string.Empty;
        /// <summary>
        /// Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Index id
        /// </summary>
        [JsonPropertyName("index_id")]
        public string IndexId { get; set; } = string.Empty;
        /// <summary>
        /// Price
        /// </summary>
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }
        /// <summary>
        /// Price change percentage last 24h
        /// </summary>
        [JsonPropertyName("price_percentage_change_24h")]
        public decimal? PricePercentageChange24h { get; set; }
        /// <summary>
        /// Contract type
        /// </summary>
        [JsonPropertyName("contract_type")]
        public string ContractType { get; set; } = string.Empty;
        /// <summary>
        /// Index
        /// </summary>
        [JsonPropertyName("index")]
        public decimal? Index { get; set; }
        /// <summary>
        /// Basis
        /// </summary>
        [JsonPropertyName("basis")]
        public decimal? Basis { get; set; }
        /// <summary>
        /// Spread
        /// </summary>
        [JsonPropertyName("spread")]
        public decimal? Spread { get; set; }
        /// <summary>
        /// Funding rate
        /// </summary>
        [JsonPropertyName("funding_rate")]
        public decimal? FundingRate { get; set; }
        /// <summary>
        /// Open interest
        /// </summary>
        [JsonPropertyName("open_interest")]
        public decimal? OpenInterest { get; set; }
        /// <summary>
        /// Volume last 24h
        /// </summary>
        [JsonPropertyName("volume_24h")]
        public decimal? Volume24h { get; set; }
        /// <summary>
        /// Last traded at
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("last_traded_at")]
        public DateTime? LastTradedAt { get; set; }
        /// <summary>
        /// Expired at
        /// </summary>
        [JsonPropertyName("expired_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ExpiredAt { get; set; }
    }
}
