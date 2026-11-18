using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Crypto holdings of public companies or governments
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPublicTreasury : CoinGeckoCompanyHolding
    {
        /// <summary>
        /// ["<c>governments</c>"] Governments holding the asset
        /// </summary>
        [JsonPropertyName("governments")]
        public CoinGeckoCompanyAsset[]? Governments { get; set; }
    }
}
