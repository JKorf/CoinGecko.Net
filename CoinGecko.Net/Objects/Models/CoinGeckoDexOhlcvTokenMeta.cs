using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex OHLCV meta token info (base or quote token)
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexOhlcvTokenMeta
    {
        /// <summary>
        /// ["<c>address</c>"] Token contract address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;

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
        /// ["<c>coingecko_coin_id</c>"] The CoinGecko coin id, when known
        /// </summary>
        [JsonPropertyName("coingecko_coin_id")]
        public string? CoinGeckoCoinId { get; set; }
    }
}
