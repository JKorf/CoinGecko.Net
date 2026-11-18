using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Price Change Period
    /// </summary>
    public enum PriceChangePeriod
    {
        /// <summary>
        /// <c>1h</c>
        /// </summary>
        [Map("1h")]
        Hours1,
        /// <summary>
        /// <c>24h</c>
        /// </summary>
        [Map("24h")]
        Hours24,
        /// <summary>
        /// <c>7d</c>
        /// </summary>
        [Map("7d")]
        Days7,
        /// <summary>
        /// <c>14d</c>
        /// </summary>
        [Map("14d")]
        Days14,
        /// <summary>
        /// <c>30d</c>
        /// </summary>
        [Map("30d")]
        Days30,
        /// <summary>
        /// <c>200d</c>
        /// </summary>
        [Map("200d")]
        Days200,
        /// <summary>
        /// <c>1y</c>
        /// </summary>
        [Map("1y")]
        Years1
    }
}
