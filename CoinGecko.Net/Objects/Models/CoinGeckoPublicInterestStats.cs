using CryptoExchange.Net.Converters.SystemTextJson;
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
        /// Alexa rank
        /// </summary>
        [JsonPropertyName("alexa_rank")]
        public int? AlexaRank { get; set; }
        /// <summary>
        /// Bing matches
        /// </summary>
        [JsonPropertyName("bing_matches")]
        public int? BingMatches { get; set; }
    }
}
