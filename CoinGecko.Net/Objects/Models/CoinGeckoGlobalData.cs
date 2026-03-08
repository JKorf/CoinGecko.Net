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
        /// ["<c>active_cryptocurrencies</c>"] Active crypto currencies
        /// </summary>
        [JsonPropertyName("active_cryptocurrencies")]
        public int ActiveCryptoCurrencies { get; set; }
        /// <summary>
        /// ["<c>upcoming_icos</c>"] Upcoming icos
        /// </summary>
        [JsonPropertyName("upcoming_icos")]
        public int UpcomingIcos { get; set; }
        /// <summary>
        /// ["<c>ongoing_icos</c>"] Ongoing icos
        /// </summary>
        [JsonPropertyName("ongoing_icos")]
        public int OngoingIcos { get; set; }
        /// <summary>
        /// ["<c>ended_icos</c>"] Ended icos
        /// </summary>
        [JsonPropertyName("ended_icos")]
        public int EndedIcos { get; set; }
        /// <summary>
        /// ["<c>markets</c>"] Exchanges
        /// </summary>
        [JsonPropertyName("markets")]
        public int Exchanges { get; set; }
        /// <summary>
        /// ["<c>total_market_cap</c>"] Total crypto market cap
        /// </summary>
        [JsonPropertyName("total_market_cap")]
        public Dictionary<string, decimal?> TotalMarketCap { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>total_volume</c>"] Total trade volume
        /// </summary>
        [JsonPropertyName("total_volume")]
        public Dictionary<string, decimal?> TotalVolume { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>market_cap_percentage</c>"] Market cap percentages
        /// </summary>
        [JsonPropertyName("market_cap_percentage")]
        public Dictionary<string, decimal?> MarketCapPercentage { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// ["<c>market_cap_change_percentage_24h_usd</c>"] Market cap percentage change over last 24 hours
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
