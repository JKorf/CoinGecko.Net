using CoinGecko.Net.Enums;
using CryptoExchange.Net.Converters;
using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Global Fear And Greed Chart
    /// </summary>
    [SerializationModel]
    public record CoinGeckoGlobalFearAndGreedChart
    {
        /// <summary>
        /// ["<c>fear_and_greed</c>"] Fear and greed data points as [timestamp, value, sentiment]
        /// </summary>
        [JsonPropertyName("fear_and_greed")]
        public CoinGeckoFearAndGreedPoint[] FearAndGreed { get; set; } = [];
    }

    /// <summary>
    /// Daily Fear and Greed Index reading
    /// </summary>
    [JsonConverter(typeof(ArrayConverter<CoinGeckoFearAndGreedPoint>))]
    [SerializationModel]
    public record CoinGeckoFearAndGreedPoint
    {
        /// <summary>
        /// Timestamp of the reading
        /// </summary>
        [ArrayProperty(0)]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Index value
        /// </summary>
        [ArrayProperty(1)]
        public int Value { get; set; }
        /// <summary>
        /// Sentiment classification
        /// </summary>
        [ArrayProperty(2)]
        public FearAndGreedSentiment Sentiment { get; set; }
    }
}
