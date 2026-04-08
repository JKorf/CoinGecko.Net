using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex token details
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexTokenDetail
    {
        /// <summary>
        /// ["<c>address</c>"] Address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// ["<c>icon_url</c>"] Icon URL
        /// </summary>
        [JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// ["<c>decimals</c>"] Decimals
        /// </summary>
        [JsonPropertyName("decimals")]
        public int Decimals { get; set; }

        /// <summary>
        /// ["<c>coingecko_coin_id</c>"] CoinGecko coin id
        /// </summary>
        [JsonPropertyName("coingecko_coin_id")]
        public string? CoinGeckoCoinId { get; set; }
    }
}
