using CryptoExchange.Net.Converters;
using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Open High Low Close data
    /// </summary>
    [JsonConverter(typeof(ArrayConverter<CoinGeckoOhlc>))]
    [SerializationModel]
    public record CoinGeckoOhlc
    {
        /// <summary>
        /// Timestamp
        /// </summary>
        [ArrayProperty(0)]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Open
        /// </summary>
        [ArrayProperty(1)]
        public decimal Open { get; set; }
        /// <summary>
        /// High
        /// </summary>
        [ArrayProperty(2)]
        public decimal High { get; set; }
        /// <summary>
        /// Low
        /// </summary>
        [ArrayProperty(3)]
        public decimal Low { get; set; }
        /// <summary>
        /// Close
        /// </summary>
        [ArrayProperty(4)]
        public decimal Close { get; set; }
    }
}
