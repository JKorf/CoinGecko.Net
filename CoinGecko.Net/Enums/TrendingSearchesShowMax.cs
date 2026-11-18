using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Trending Searches Show Max
    /// </summary>
    public enum TrendingSearchesShowMax
    {
        /// <summary>
        /// <c>coins</c>
        /// </summary>
        [Map("coins")]
        Coins,
        /// <summary>
        /// <c>nfts</c>
        /// </summary>
        [Map("nfts")]
        Nfts,
        /// <summary>
        /// <c>categories</c>
        /// </summary>
        [Map("categories")]
        Categories
    }
}
