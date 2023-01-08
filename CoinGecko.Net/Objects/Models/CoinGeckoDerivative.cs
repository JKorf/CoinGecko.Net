using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Derivative info
    /// </summary>
    public class CoinGeckoDerivative
    {
        /// <summary>
        /// Market
        /// </summary>
        public string Market { get; set; } = string.Empty;
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Index id
        /// </summary>
        [JsonProperty("index_id")]
        public string IndexId { get; set; } = string.Empty;
        /// <summary>
        /// Price
        /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
        /// Price change percentage last 24h
        /// </summary>
        [JsonProperty("price_percentage_change_24h")]
        public decimal? PricePercentageChange24h { get; set; }
        /// <summary>
        /// Contract type
        /// </summary>
        [JsonProperty("contract_type")]
        public string ContractType { get; set; } = string.Empty;
        /// <summary>
        /// Index
        /// </summary>
        public decimal? Index { get; set; }
        /// <summary>
        /// Basis
        /// </summary>
        public decimal? Basis { get; set; }
        /// <summary>
        /// Spread
        /// </summary>
        public decimal? Spread { get; set; }
        /// <summary>
        /// Funding rate
        /// </summary>
        [JsonProperty("funding_rate")]
        public decimal? FundingRate { get; set; }
        /// <summary>
        /// Open interest
        /// </summary>
        [JsonProperty("open_interest")]
        public decimal? OpenInterest { get; set; }
        /// <summary>
        /// Volume last 24h
        /// </summary>
        [JsonProperty("volume_24h")]
        public decimal? Volume24h { get; set; }
        /// <summary>
        /// Last traded at
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("last_traded_at")]
        public DateTime? LastTradedAt { get; set; }
        /// <summary>
        /// Expired at
        /// </summary>
        [JsonProperty("expired_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ExpiredAt { get; set; }
    }
}
