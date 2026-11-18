using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Dex Trading Period
    /// </summary>
    public enum DexTradingPeriod
    {
        /// <summary>
        /// <c>1d</c>
        /// </summary>
        [Map("1d")]
        Days1,
        /// <summary>
        /// <c>7d</c>
        /// </summary>
        [Map("7d")]
        Days7,
        /// <summary>
        /// <c>30d</c>
        /// </summary>
        [Map("30d")]
        Days30
    }
}
