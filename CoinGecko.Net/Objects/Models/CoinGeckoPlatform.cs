using CryptoExchange.Net.Converters.SystemTextJson;
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
        /// Decimal places
        /// </summary>
        [JsonPropertyName("decimal_place")]
        public int? DecimalPlaces { get; set; }
        /// <summary>
        /// Address
        /// </summary>
        [JsonPropertyName("contract_address")]
        public string ContractAddress { get; set; } = string.Empty;
    }
}
