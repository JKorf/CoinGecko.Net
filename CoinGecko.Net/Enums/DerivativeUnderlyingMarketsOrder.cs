using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Derivative Underlying Markets Order
    /// </summary>
    public enum DerivativeUnderlyingMarketsOrder
    {
        /// <summary>
        /// <c>open_interest_desc</c>
        /// </summary>
        [Map("open_interest_desc")]
        OpenInterestDesc,
        /// <summary>
        /// <c>open_interest_asc</c>
        /// </summary>
        [Map("open_interest_asc")]
        OpenInterestAsc,
        /// <summary>
        /// <c>volume_desc</c>
        /// </summary>
        [Map("volume_desc")]
        VolumeDesc,
        /// <summary>
        /// <c>volume_asc</c>
        /// </summary>
        [Map("volume_asc")]
        VolumeAsc
    }
}
