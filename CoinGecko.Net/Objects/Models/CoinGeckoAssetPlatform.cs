using Newtonsoft.Json;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Platform info
    /// </summary>
    public class CoinGeckoAssetPlatform
    {
        /// <summary>
        /// Platform id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Chain identifier
        /// </summary>
        [JsonProperty("chain_identifier")]
        public string? ChainIdentifier { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Short name
        /// </summary>
        public string? ShortName { get; set; }
    }
}
