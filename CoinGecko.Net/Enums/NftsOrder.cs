using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Nfts Order
    /// </summary>
    public enum NftsOrder
    {
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
        /// <c>floor_price_native_asc</c>
        /// </summary>
        [Map("floor_price_native_asc")]
        FloorPriceNativeAsc,
        /// <summary>
        /// <c>floor_price_native_desc</c>
        /// </summary>
        [Map("floor_price_native_desc")]
        FloorPriceNativeDesc,
        /// <summary>
        /// <c>market_cap_native_asc</c>
        /// </summary>
        [Map("market_cap_native_asc")]
        MarketCapNativeAsc,
        /// <summary>
        /// <c>market_cap_native_desc</c>
        /// </summary>
        [Map("market_cap_native_desc")]
        MarketCapNativeDesc,
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
