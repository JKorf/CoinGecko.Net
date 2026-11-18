using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Supply Chart Interval
    /// </summary>
    public enum SupplyChartInterval
    {
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
