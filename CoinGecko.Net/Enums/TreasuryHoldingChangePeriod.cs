using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Period over which to report a change in treasury holdings
    /// </summary>
    public enum TreasuryHoldingChangePeriod
    {
        /// <summary>
        /// Seven days
        /// </summary>
        [Map("7d")]
        Days7,
        /// <summary>
        /// Fourteen days
        /// </summary>
        [Map("14d")]
        Days14,
        /// <summary>
        /// Thirty days
        /// </summary>
        [Map("30d")]
        Days30,
        /// <summary>
        /// Ninety days
        /// </summary>
        [Map("90d")]
        Days90,
        /// <summary>
        /// One year
        /// </summary>
        [Map("1y")]
        Year1,
        /// <summary>
        /// Year to date
        /// </summary>
        [Map("ytd")]
        YearToDate
    }
}
