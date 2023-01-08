using Newtonsoft.Json;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Public interest statistics
    /// </summary>
    public class CoinGeckoPublicInterestStats
    {
        /// <summary>
        /// Alexa rank
        /// </summary>
        [JsonProperty("alexa_rank")]
        public int? AlexaRank { get; set; }
        /// <summary>
        /// Bing matches
        /// </summary>
        [JsonProperty("bing_matches")]
        public int? BingMatches { get; set; }
    }
}
