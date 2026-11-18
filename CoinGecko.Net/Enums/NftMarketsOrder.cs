using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Nft Markets Order
    /// </summary>
    public enum NftMarketsOrder
    {
        /// <summary>
        /// <c>h24_volume_native_asc</c>
        /// </summary>
        [Map("h24_volume_native_asc")]
        Hours24VolumeNativeAsc,
        /// <summary>
        /// <c>h24_volume_native_desc</c>
        /// </summary>
        [Map("h24_volume_native_desc")]
        Hours24VolumeNativeDesc,
        /// <summary>
        /// <c>h24_volume_usd_asc</c>
        /// </summary>
        [Map("h24_volume_usd_asc")]
        Hours24VolumeUsdAsc,
        /// <summary>
        /// <c>h24_volume_usd_desc</c>
        /// </summary>
        [Map("h24_volume_usd_desc")]
        Hours24VolumeUsdDesc,
        /// <summary>
        /// <c>market_cap_usd_asc</c>
        /// </summary>
        [Map("market_cap_usd_asc")]
        MarketCapUsdAsc,
        /// <summary>
        /// <c>market_cap_usd_desc</c>
        /// </summary>
        [Map("market_cap_usd_desc")]
        MarketCapUsdDesc
    }
}
