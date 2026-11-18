using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Filtered Pools Check
    /// </summary>
    public enum FilteredPoolsCheck
    {
        /// <summary>
        /// <c>no_honeypot</c>
        /// </summary>
        [Map("no_honeypot")]
        NoHoneypot,
        /// <summary>
        /// <c>good_gt_score</c>
        /// </summary>
        [Map("good_gt_score")]
        GoodGtScore,
        /// <summary>
        /// <c>on_coingecko</c>
        /// </summary>
        [Map("on_coingecko")]
        OnCoingecko,
        /// <summary>
        /// <c>has_social</c>
        /// </summary>
        [Map("has_social")]
        HasSocial
    }
}
