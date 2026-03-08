using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Derivative info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDerivative
    {
        /// <summary>
        /// ["<c>market</c>"] Market
        /// </summary>
        [JsonPropertyName("market")]
        public string Market { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>index_id</c>"] Index id
        /// </summary>
        [JsonPropertyName("index_id")]
        public string IndexId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>price</c>"] Price
        /// </summary>
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }
        /// <summary>
        /// ["<c>price_percentage_change_24h</c>"] Price change percentage last 24h
        /// </summary>
        [JsonPropertyName("price_percentage_change_24h")]
        public decimal? PricePercentageChange24h { get; set; }
        /// <summary>
        /// ["<c>contract_type</c>"] Contract type
        /// </summary>
        [JsonPropertyName("contract_type")]
        public string ContractType { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>index</c>"] Index
        /// </summary>
        [JsonPropertyName("index")]
        public decimal? Index { get; set; }
        /// <summary>
        /// ["<c>basis</c>"] Basis
        /// </summary>
        [JsonPropertyName("basis")]
        public decimal? Basis { get; set; }
        /// <summary>
        /// ["<c>spread</c>"] Spread
        /// </summary>
        [JsonPropertyName("spread")]
        public decimal? Spread { get; set; }
        /// <summary>
        /// ["<c>funding_rate</c>"] Funding rate
        /// </summary>
        [JsonPropertyName("funding_rate")]
        public decimal? FundingRate { get; set; }
        /// <summary>
        /// ["<c>open_interest</c>"] Open interest
        /// </summary>
        [JsonPropertyName("open_interest")]
        public decimal? OpenInterest { get; set; }
        /// <summary>
        /// ["<c>volume_24h</c>"] Volume last 24h
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
        /// ["<c>expired_at</c>"] Expired at
        /// </summary>
        [JsonPropertyName("expired_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ExpiredAt { get; set; }
    }
}
