using CryptoExchange.Net.Converters.SystemTextJson;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    [SerializationModel]
    internal record CoinGeckoGlobalDataWrapper
    {
        [JsonPropertyName("data")]
        public CoinGeckoGlobalData? Data { get; set; }
    }

    /// <summary>
    /// Global crypto data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoGlobalData
    {
        /// <summary>
        /// Active crypto currencies
        /// </summary>
        [JsonPropertyName("active_cryptocurrencies")]
        public int ActiveCryptoCurrencies { get; set; }
        /// <summary>
        /// Upcoming icos
        /// </summary>
        [JsonPropertyName("upcoming_icos")]
        public int UpcomingIcos { get; set; }
        /// <summary>
        /// Ongoing icos
        /// </summary>
        [JsonPropertyName("ongoing_icos")]
        public int OngoingIcos { get; set; }
        /// <summary>
        /// Ended icos
        /// </summary>
        [JsonPropertyName("ended_icos")]
        public int EndedIcos { get; set; }
        /// <summary>
        /// Exchanges
        /// </summary>
        [JsonPropertyName("markets")]
        public int Exchanges { get; set; }
        /// <summary>
        /// Total crypto market cap
        /// </summary>
        [JsonPropertyName("total_market_cap")]
        public Dictionary<string, decimal?> TotalMarketCap { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// Total trade volume
        /// </summary>
        [JsonPropertyName("total_volume")]
        public Dictionary<string, decimal?> TotalVolume { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// Market cap percentages
        /// </summary>
        [JsonPropertyName("market_cap_percentage")]
        public Dictionary<string, decimal?> MarketCapPercentage { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// Market cap percentage change over last 24 hours
        /// </summary>
        [JsonPropertyName("market_cap_change_percentage_24h_usd")]
        public decimal? MarketCapChangePercentage24hUsd { get; set; }
        /// <summary>
        /// Updated at
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
