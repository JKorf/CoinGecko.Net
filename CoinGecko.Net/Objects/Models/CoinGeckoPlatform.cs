using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Platform info
    /// </summary>
    public record CoinGeckoPlatform
    {
        /// <summary>
        /// Decimal places
        /// </summary>
        [JsonPropertyName("decimail_places")]
        public int DecimalPlaces { get; set; }
        /// <summary>
        /// Address
        /// </summary>
        [JsonPropertyName("contract_address")]
        public string ContractAddress { get; set; } = string.Empty;
    }
}
