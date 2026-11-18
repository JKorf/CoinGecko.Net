using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Listing Status
    /// </summary>
    public enum ListingStatus
    {
        /// <summary>
        /// <c>active</c>
        /// </summary>
        [Map("active")]
        Active,
        /// <summary>
        /// <c>inactive</c>
        /// </summary>
        [Map("inactive")]
        Inactive
    }
}
