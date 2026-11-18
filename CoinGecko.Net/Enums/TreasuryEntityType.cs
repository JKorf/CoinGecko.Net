using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Type of treasury entity
    /// </summary>
    [JsonConverter(typeof(EnumConverter<TreasuryEntityType>))]
    public enum TreasuryEntityType
    {
        /// <summary>
        /// Public company
        /// </summary>
        [Map("company")]
        Company,
        /// <summary>
        /// Government
        /// </summary>
        [Map("government")]
        Government
    }
}
