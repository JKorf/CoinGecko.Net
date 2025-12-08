using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Nft
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNft
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Contract address
        /// </summary>
        [JsonPropertyName("contract_address")]
        public string ContractAddress { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Asset platform id
        /// </summary>
        [JsonPropertyName("asset_platform_id")]
        public string AssetPlatformId { get; set; } = string.Empty;
        /// <summary>
        /// Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
    }
}
