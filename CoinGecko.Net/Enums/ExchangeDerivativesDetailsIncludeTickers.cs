using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Exchange Derivatives Details Include Tickers
    /// </summary>
    public enum ExchangeDerivativesDetailsIncludeTickers
    {
        /// <summary>
        /// <c>all</c>
        /// </summary>
        [Map("all")]
        All,
        /// <summary>
        /// <c>unexpired</c>
        /// </summary>
        [Map("unexpired")]
        Unexpired
    }
}
