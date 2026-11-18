using CryptoExchange.Net.Converters;
using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Token Holders Chart
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenHoldersChart
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoTokenHoldersChartData Data { get; set; } = new();
        /// <summary>
        /// ["<c>meta</c>"] Meta
        /// </summary>
        [JsonPropertyName("meta")]
        public CoinGeckoTokenHoldersChartMeta Meta { get; set; } = new();
    }

    /// <summary>
    /// Token Holders Chart Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenHoldersChartData
    {
        /// <summary>
        /// ["<c>id</c>"] Request ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>type</c>"] Resource type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>attributes</c>"] Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public CoinGeckoTokenHoldersChartDataAttributes Attributes { get; set; } = new();
    }

    /// <summary>
    /// Token Holders Chart Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenHoldersChartDataAttributes
    {
        /// <summary>
        /// ["<c>token_holders_list</c>"] Historical token holders as [timestamp, holder_count] pairs
        /// </summary>
        [JsonPropertyName("token_holders_list")]
        public CoinGeckoTokenHolderCount[] TokenHoldersList { get; set; } = [];
    }

    /// <summary>
    /// Number of token holders at a point in time
    /// </summary>
    [JsonConverter(typeof(ArrayConverter<CoinGeckoTokenHolderCount>))]
    [SerializationModel]
    public record CoinGeckoTokenHolderCount
    {
        /// <summary>
        /// Timestamp of the holder count
        /// </summary>
        [ArrayProperty(0)]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Number of holders
        /// </summary>
        [ArrayProperty(1)]
        public long HolderCount { get; set; }
    }

    /// <summary>
    /// Token Holders Chart Meta
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenHoldersChartMeta
    {
        /// <summary>
        /// ["<c>token</c>"] Token
        /// </summary>
        [JsonPropertyName("token")]
        public CoinGeckoTokenHoldersChartMetaToken? Token { get; set; }
    }

    /// <summary>
    /// Token Holders Chart Meta Token
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenHoldersChartMetaToken
    {
        /// <summary>
        /// ["<c>name</c>"] Token name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// ["<c>symbol</c>"] Token symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
        /// <summary>
        /// ["<c>coingecko_coin_id</c>"] CoinGecko coin ID
        /// </summary>
        [JsonPropertyName("coingecko_coin_id")]
        public string? CoingeckoCoinId { get; set; }
        /// <summary>
        /// ["<c>address</c>"] Token contract address
        /// </summary>
        [JsonPropertyName("address")]
        public string? Address { get; set; }
    }
}
