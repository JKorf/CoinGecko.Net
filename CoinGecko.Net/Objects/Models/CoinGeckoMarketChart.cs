﻿using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Price history info
    /// </summary>
    public record CoinGeckoMarketChart
    {
        /// <summary>
        /// Price history
        /// </summary>
        public IEnumerable<CoinGeckoMarketChartValue> Prices { get; set; } = Array.Empty<CoinGeckoMarketChartValue>();
        /// <summary>
        /// Market cap history
        /// </summary>
        [JsonProperty("market_caps")]
        public IEnumerable<CoinGeckoMarketChartValue> MarketCaps { get; set; } = Array.Empty<CoinGeckoMarketChartValue>();
        /// <summary>
        /// Volume history
        /// </summary>
        [JsonProperty("total_volumes")]
        public IEnumerable<CoinGeckoMarketChartValue> TotalVolumes { get; set; } = Array.Empty<CoinGeckoMarketChartValue>();
    }

    /// <summary>
    /// Value at time info
    /// </summary>
    [JsonConverter(typeof(ArrayConverter))]
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
