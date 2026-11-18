using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// News Type
    /// </summary>
    public enum NewsType
    {
        /// <summary>
        /// <c>all</c>
        /// </summary>
        [Map("all")]
        All,
        /// <summary>
        /// <c>news</c>
        /// </summary>
        [Map("news")]
        News,
        /// <summary>
        /// <c>guides</c>
        /// </summary>
        [Map("guides")]
        Guides
    }
}
