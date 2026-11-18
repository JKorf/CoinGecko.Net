using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex Token Info Response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTokenInfoResponse
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoTokenInfoItem Data { get; set; } = new();
    }
}
