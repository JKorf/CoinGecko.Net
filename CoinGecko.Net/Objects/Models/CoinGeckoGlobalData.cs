using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CoinGecko.Net.Objects.Models
{
    internal record CoinGeckoGlobalDataWrapper
    {
        public CoinGeckoGlobalData? Data { get; set; }
    }

    /// <summary>
    /// Global crypto data
    /// </summary>
    public record CoinGeckoGlobalData
    {
        /// <summary>
        /// Active crypto currencies
        /// </summary>
        [JsonProperty("active_cryptocurrencies")]
        public int ActiveCryptoCurrencies { get; set; }
        /// <summary>
        /// Upcoming icos
        /// </summary>
        [JsonProperty("upcoming_icos")]
        public int UpcomingIcos { get; set; }
        /// <summary>
        /// Ongoing icos
        /// </summary>
        [JsonProperty("ongoing_icos")]
        public int OngoingIcos { get; set; }
        /// <summary>
        /// Ended icos
        /// </summary>
        [JsonProperty("ended_icos")]
        public int EndedIcos { get; set; }
        /// <summary>
        /// Markets
        /// </summary>
        public int Markets { get; set; }
        /// <summary>
        /// Total crypto market cap
        /// </summary>
        [JsonProperty("total_market_cap")]
        public Dictionary<string, decimal?> TotalMarketCap { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// Total trade volume
        /// </summary>
        [JsonProperty("total_volume")]
        public Dictionary<string, decimal?> TotalVolume { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// Market cap percentages
        /// </summary>
        [JsonProperty("market_cap_percentage")]
        public Dictionary<string, decimal?> MarketCapPercentage { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// Market cap percentage change over last 24 hours
        /// </summary>
        [JsonProperty("market_cap_change_percentage_24h_usd")]
        public decimal? MarketCapChangePercentage24hUsd { get; set; }
        /// <summary>
        /// Updated at
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
