using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Ohlc Interval
    /// </summary>
    public enum OhlcInterval
    {
        /// <summary>
        /// <c>daily</c>
        /// </summary>
        [Map("daily")]
        Daily,
        /// <summary>
        /// <c>hourly</c>
        /// </summary>
        [Map("hourly")]
        Hourly
    }
}
