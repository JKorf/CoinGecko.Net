using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Type of tokenized real-world asset
    /// </summary>
    [JsonConverter(typeof(EnumConverter<RwaAssetType>))]
    public enum RwaAssetType
    {
        /// <summary>
        /// Stock
        /// </summary>
        [Map("stock")]
        Stock,
        /// <summary>
        /// Commodity
        /// </summary>
        [Map("commodity")]
        Commodity,
        /// <summary>
        /// Exchange-traded fund
        /// </summary>
        [Map("etf")]
        Etf
    }
}
