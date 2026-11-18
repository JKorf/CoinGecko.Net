using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Top Gainers Losers
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTopGainersLosers
    {
        /// <summary>
        /// ["<c>top_gainers</c>"] TopGainers
        /// </summary>
        [JsonPropertyName("top_gainers")]
        public CoinGeckoTopGainersLosersItem[] TopGainers { get; set; } = [];
        /// <summary>
        /// ["<c>top_losers</c>"] TopLosers
        /// </summary>
        [JsonPropertyName("top_losers")]
        public CoinGeckoTopGainersLosersItem[] TopLosers { get; set; } = [];
    }
}
