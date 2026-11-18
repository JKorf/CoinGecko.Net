using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Dex Ohlcv Timeframe
    /// </summary>
    public enum DexOhlcvTimeframe
    {
        /// <summary>
        /// <c>day</c>
        /// </summary>
        [Map("day")]
        Day,
        /// <summary>
        /// <c>hour</c>
        /// </summary>
        [Map("hour")]
        Hour,
        /// <summary>
        /// <c>minute</c>
        /// </summary>
        [Map("minute")]
        Minute,
        /// <summary>
        /// <c>second</c>
        /// </summary>
        [Map("second")]
        Second
    }
}
