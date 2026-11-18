using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Wallet Token Balances Token Type
    /// </summary>
    public enum WalletTokenBalancesTokenType
    {
        /// <summary>
        /// <c>native</c>
        /// </summary>
        [Map("native")]
        Native,
        /// <summary>
        /// <c>non_native</c>
        /// </summary>
        [Map("non_native")]
        NonNative
    }
}
