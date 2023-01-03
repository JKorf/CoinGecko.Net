using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Price history info
    /// </summary>
    public class CoinGeckoMarketChart
    {
        /// <summary>
        /// Price history
        /// </summary>
        public IEnumerable<CoinGeckoMarketChartPrice> Prices { get; set; } = Array.Empty<CoinGeckoMarketChartPrice>();
        /// <summary>
        /// Market cap history
        /// </summary>
        [JsonProperty("market_caps")]
        public IEnumerable<CoinGeckoMarketChartPrice> MarketCaps { get; set; } = Array.Empty<CoinGeckoMarketChartPrice>();
        /// <summary>
        /// Volume history
        /// </summary>
        [JsonProperty("total_volumes")]
        public IEnumerable<CoinGeckoMarketChartPrice> TotalVolumes { get; set; } = Array.Empty<CoinGeckoMarketChartPrice>();
    }

    /// <summary>
    /// Price at time info
    /// </summary>
    [JsonConverter(typeof(ArrayConverter))]
    public class CoinGeckoMarketChartPrice
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
