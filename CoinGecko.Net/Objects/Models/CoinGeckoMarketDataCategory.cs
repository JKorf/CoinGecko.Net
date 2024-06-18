using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Category info
    /// </summary>
    public record CoinGeckoMarketDataCategory
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Total market cap
        /// </summary>
        [JsonProperty("market_cap")]
        public decimal MarketCap { get; set; }
        /// <summary>
        /// Market cap change last 24h
        /// </summary>
        [JsonProperty("market_cap_change_24h")]
        public decimal MarketCapChange24h { get; set; }
        /// <summary>
        /// Content
        /// </summary>
        public string Content { get; set; } = string.Empty;
        /// <summary>
        /// Top 3 coins
        /// </summary>
        [JsonProperty("top_3_coins")]
        public IEnumerable<string> Top3Coins { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Volume last 24h
        /// </summary>
        [JsonProperty("volume_24h")]
        public decimal Volume24h { get; set; }
        /// <summary>
        /// Last updated
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime LastUpdated { get; set; }
    }
}
