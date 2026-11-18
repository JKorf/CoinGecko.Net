using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Dex Ohlcv Currency
    /// </summary>
    public enum DexOhlcvCurrency
    {
        /// <summary>
        /// <c>usd</c>
        /// </summary>
        [Map("usd")]
        Usd,
        /// <summary>
        /// <c>token</c>
        /// </summary>
        [Map("token")]
        Token
    }
}
