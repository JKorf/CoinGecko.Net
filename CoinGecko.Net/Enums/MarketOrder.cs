using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Market Order
    /// </summary>
    public enum MarketOrder
    {
        /// <summary>
        /// <c>market_cap_asc</c>
        /// </summary>
        [Map("market_cap_asc")]
        MarketCapAsc,
        /// <summary>
        /// <c>market_cap_desc</c>
        /// </summary>
        [Map("market_cap_desc")]
        MarketCapDesc,
        /// <summary>
        /// <c>volume_asc</c>
        /// </summary>
        [Map("volume_asc")]
        VolumeAsc,
        /// <summary>
        /// <c>volume_desc</c>
        /// </summary>
        [Map("volume_desc")]
        VolumeDesc,
        /// <summary>
        /// <c>id_asc</c>
        /// </summary>
        [Map("id_asc")]
        IdAsc,
        /// <summary>
        /// <c>id_desc</c>
        /// </summary>
        [Map("id_desc")]
        IdDesc
    }
}
