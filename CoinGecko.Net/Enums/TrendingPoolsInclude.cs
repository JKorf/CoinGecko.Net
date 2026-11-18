using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Trending Pools Include
    /// </summary>
    public enum TrendingPoolsInclude
    {
        /// <summary>
        /// <c>base_token</c>
        /// </summary>
        [Map("base_token")]
        BaseToken,
        /// <summary>
        /// <c>quote_token</c>
        /// </summary>
        [Map("quote_token")]
        QuoteToken,
        /// <summary>
        /// <c>dex</c>
        /// </summary>
        [Map("dex")]
        Dex,
        /// <summary>
        /// <c>network</c>
        /// </summary>
        [Map("network")]
        Network
    }
}
