using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Pools By Category Sort
    /// </summary>
    public enum PoolsByCategorySort
    {
        /// <summary>
        /// <c>m5_trending</c>
        /// </summary>
        [Map("m5_trending")]
        Minutes5Trending,
        /// <summary>
        /// <c>h1_trending</c>
        /// </summary>
        [Map("h1_trending")]
        Hours1Trending,
        /// <summary>
        /// <c>h6_trending</c>
        /// </summary>
        [Map("h6_trending")]
        Hours6Trending,
        /// <summary>
        /// <c>h24_trending</c>
        /// </summary>
        [Map("h24_trending")]
        Hours24Trending,
        /// <summary>
        /// <c>h24_tx_count_desc</c>
        /// </summary>
        [Map("h24_tx_count_desc")]
        Hours24TxCountDesc,
        /// <summary>
        /// <c>h24_volume_usd_desc</c>
        /// </summary>
        [Map("h24_volume_usd_desc")]
        Hours24VolumeUsdDesc,
        /// <summary>
        /// <c>pool_created_at_desc</c>
        /// </summary>
        [Map("pool_created_at_desc")]
        PoolCreatedAtDesc,
        /// <summary>
        /// <c>h24_price_change_percentage_desc</c>
        /// </summary>
        [Map("h24_price_change_percentage_desc")]
        Hours24PriceChangePercentageDesc
    }
}
