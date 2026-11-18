using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Dex Pool Duration
    /// </summary>
    public enum DexPoolDuration
    {
        /// <summary>
        /// <c>5m</c>
        /// </summary>
        [Map("5m")]
        Minutes5,
        /// <summary>
        /// <c>1h</c>
        /// </summary>
        [Map("1h")]
        Hours1,
        /// <summary>
        /// <c>6h</c>
        /// </summary>
        [Map("6h")]
        Hours6,
        /// <summary>
        /// <c>24h</c>
        /// </summary>
        [Map("24h")]
        Hours24
    }
}
