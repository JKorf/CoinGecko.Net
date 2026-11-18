using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Pool Include
    /// </summary>
    public enum PoolInclude
    {
        /// <summary>
        /// <c>base_token</c>
        /// </summary>
        [Map("base_token")]
        BaseToken,
        /// <summary>
        /// <c>quote_token</c>
        /// </summary>
        [Map("quote_token")]
        QuoteToken,
        /// <summary>
        /// <c>dex</c>
        /// </summary>
        [Map("dex")]
        Dex
    }
}
