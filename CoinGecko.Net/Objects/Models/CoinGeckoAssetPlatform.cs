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
        /// ["<c>id</c>"] Platform id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>chain_identifier</c>"] Chain identifier
        /// </summary>
        [JsonPropertyName("chain_identifier")]
        public int? ChainIdentifier { get; set; }
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>shortname</c>"] Short name
        /// </summary>
        [JsonPropertyName("shortname")]
        public string? ShortName { get; set; }
        /// <summary>
        /// ["<c>native_coin_id</c>"] Chain native coin id
        /// </summary>
        [JsonPropertyName("native_coin_id")]
        public string? NativeCoinId { get; set; }
        /// <summary>
        /// ["<c>image</c>"] Platform image
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoImages? Image { get; set; }
    }
}
