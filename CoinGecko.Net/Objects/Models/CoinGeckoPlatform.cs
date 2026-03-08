using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Platform info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoPlatform
    {
        /// <summary>
        /// ["<c>decimal_place</c>"] Decimal places
        /// </summary>
        [JsonPropertyName("decimal_place")]
        public int? DecimalPlaces { get; set; }
        /// <summary>
        /// ["<c>contract_address</c>"] Address
        /// </summary>
        [JsonPropertyName("contract_address")]
        public string ContractAddress { get; set; } = string.Empty;
    }
}
