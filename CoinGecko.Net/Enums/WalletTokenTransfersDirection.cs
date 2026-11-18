using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Wallet Token Transfers Direction
    /// </summary>
    [JsonConverter(typeof(EnumConverter<WalletTokenTransfersDirection>))]
    public enum WalletTokenTransfersDirection
    {
        /// <summary>
        /// <c>in</c>
        /// </summary>
        [Map("in")]
        In,
        /// <summary>
        /// <c>out</c>
        /// </summary>
        [Map("out")]
        Out
    }
}
