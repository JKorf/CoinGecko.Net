using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Type of underlying asset for a derivative
    /// </summary>
    [JsonConverter(typeof(EnumConverter<DerivativeUnderlyingType>))]
    public enum DerivativeUnderlyingType
    {
        /// <summary>
        /// Coin
        /// </summary>
        [Map("coin")]
        Coin,
        /// <summary>
        /// Real-world asset
        /// </summary>
        [Map("rwa")]
        Rwa
    }
}
