using CryptoExchange.Net.Converters.SystemTextJson;
using CryptoExchange.Net.Converters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using CoinGecko.Net.Converters;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Price history info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMarketChart
    {
        /// <summary>
        /// Price history
        /// </summary>
        [JsonPropertyName("prices")]
        public CoinGeckoMarketChartValue[] Prices { get; set; } = Array.Empty<CoinGeckoMarketChartValue>();
        /// <summary>
        /// Market cap history
        /// </summary>
        [JsonPropertyName("market_caps")]
        public CoinGeckoMarketChartValue[] MarketCaps { get; set; } = Array.Empty<CoinGeckoMarketChartValue>();
        /// <summary>
        /// Volume history
        /// </summary>
        [JsonPropertyName("total_volumes")]
        public CoinGeckoMarketChartValue[] TotalVolumes { get; set; } = Array.Empty<CoinGeckoMarketChartValue>();
    }

    /// <summary>
    /// Value at time info
    /// </summary>
    [JsonConverter(typeof(ArrayConverter<CoinGeckoMarketChartValue, CoinGeckoSourceGenerationContext>))]
    [SerializationModel]
    public record CoinGeckoMarketChartValue
    {
        /// <summary>
        /// Timestamp
        /// </summary>
        [ArrayProperty(0)]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Value
        /// </summary>
        [ArrayProperty(1)]
        public decimal Value { get; set; }
    }
}
