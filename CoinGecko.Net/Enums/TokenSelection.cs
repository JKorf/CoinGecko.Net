using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Token Selection
    /// </summary>
    public enum TokenSelection
    {
        /// <summary>
        /// <c>top</c>
        /// </summary>
        [Map("top")]
        Top,
        /// <summary>
        /// <c>all</c>
        /// </summary>
        [Map("all")]
        All
    }
}
