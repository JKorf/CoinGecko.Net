using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Pool Liquidity Events Kind
    /// </summary>
    [JsonConverter(typeof(EnumConverter<PoolLiquidityEventsKind>))]
    public enum PoolLiquidityEventsKind
    {
        /// <summary>
        /// <c>add</c>
        /// </summary>
        [Map("add")]
        Add,
        /// <summary>
        /// <c>remove</c>
        /// </summary>
        [Map("remove")]
        Remove
    }
}
