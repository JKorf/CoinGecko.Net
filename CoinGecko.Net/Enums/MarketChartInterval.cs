using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Market Chart Interval
    /// </summary>
    public enum MarketChartInterval
    {
        /// <summary>
        /// <c>1m</c>
        /// </summary>
        [Map("1m")]
        Minutes1,
        /// <summary>
        /// <c>5m</c>
        /// </summary>
        [Map("5m")]
        Minutes5,
        /// <summary>
        /// <c>hourly</c>
        /// </summary>
        [Map("hourly")]
        Hourly,
        /// <summary>
        /// <c>daily</c>
        /// </summary>
        [Map("daily")]
        Daily
    }
}
