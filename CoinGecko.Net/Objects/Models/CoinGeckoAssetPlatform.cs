using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Platform info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoAssetPlatform
    {
        /// <summary>
        /// Platform id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Chain identifier
        /// </summary>
        [JsonPropertyName("chain_identifier")]
        public int? ChainIdentifier { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Short name
        /// </summary>
        [JsonPropertyName("shortname")]
        public string? ShortName { get; set; }
        /// <summary>
        /// Chain native coin id
        /// </summary>
        [JsonPropertyName("native_coin_id")]
        public string? NativeCoinId { get; set; }
        /// <summary>
        /// Platform image
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoImages? Image { get; set; }
    }
}
