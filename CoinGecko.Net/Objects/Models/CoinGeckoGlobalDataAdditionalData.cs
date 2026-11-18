using CoinGecko.Net.Enums;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Global Data Fear And Greed Index
    /// </summary>
    [SerializationModel]
    public record CoinGeckoGlobalDataFearAndGreedIndex
    {
        /// <summary>
        /// ["<c>value</c>"] Crypto Fear &amp; Greed Index value
        /// </summary>
        [JsonPropertyName("value")]
        public int Value { get; set; }
        /// <summary>
        /// ["<c>sentiment</c>"] Sentiment label based on the index value
        /// </summary>
        [JsonPropertyName("sentiment")]
        public FearAndGreedSentiment Sentiment { get; set; }
    }
}
