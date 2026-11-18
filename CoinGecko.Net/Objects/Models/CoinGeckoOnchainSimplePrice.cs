using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Onchain Simple Price
    /// </summary>
    [SerializationModel]
    public record CoinGeckoOnchainSimplePrice
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoOnchainSimplePriceData Data { get; set; } = new();
    }

    /// <summary>
    /// Onchain Simple Price Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoOnchainSimplePriceData
    {
        /// <summary>
        /// ["<c>id</c>"] Request ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>type</c>"] Response type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>attributes</c>"] Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public CoinGeckoOnchainSimplePriceDataAttributes Attributes { get; set; } = new();
    }

    /// <summary>
    /// Onchain Simple Price Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoOnchainSimplePriceDataAttributes
    {
        /// <summary>
        /// ["<c>token_prices</c>"] Token prices keyed by contract address
        /// </summary>
        [JsonPropertyName("token_prices")]
        public Dictionary<string, decimal> TokenPrices { get; set; } = new();
        /// <summary>
        /// ["<c>market_cap_usd</c>"] Market cap in USD keyed by contract address
        /// </summary>
        [JsonPropertyName("market_cap_usd")]
        public Dictionary<string, decimal>? MarketCapUsd { get; set; }
        /// <summary>
        /// ["<c>h24_volume_usd</c>"] 24hr volume in USD keyed by contract address
        /// </summary>
        [JsonPropertyName("h24_volume_usd")]
        public Dictionary<string, decimal>? H24VolumeUsd { get; set; }
        /// <summary>
        /// ["<c>h24_price_change_percentage</c>"] 24hr price change percentage keyed by contract address
        /// </summary>
        [JsonPropertyName("h24_price_change_percentage")]
        public Dictionary<string, decimal>? H24PriceChangePercentage { get; set; }
        /// <summary>
        /// ["<c>total_reserve_in_usd</c>"] Total reserve in USD keyed by contract address
        /// </summary>
        [JsonPropertyName("total_reserve_in_usd")]
        public Dictionary<string, decimal>? TotalReserveInUsd { get; set; }
        /// <summary>
        /// ["<c>last_trade_timestamp</c>"] Last trade timestamp keyed by contract address
        /// </summary>
        [JsonPropertyName("last_trade_timestamp")]
        public Dictionary<string, string>? LastTradeTimestamp { get; set; }
    }
}
