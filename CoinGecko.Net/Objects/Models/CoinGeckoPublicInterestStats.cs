using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Public interest statistics
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPublicInterestStats
    {
        /// <summary>
        /// ["<c>alexa_rank</c>"] Alexa rank
        /// </summary>
        [JsonPropertyName("alexa_rank")]
        public int? AlexaRank { get; set; }
        /// <summary>
        /// ["<c>bing_matches</c>"] Bing matches
        /// </summary>
        [JsonPropertyName("bing_matches")]
        public int? BingMatches { get; set; }
    }
}
