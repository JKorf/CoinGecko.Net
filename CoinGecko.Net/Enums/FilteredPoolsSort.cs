using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Filtered Pools Sort
    /// </summary>
    public enum FilteredPoolsSort
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
        /// <c>h24_tx_count_asc</c>
        /// </summary>
        [Map("h24_tx_count_asc")]
        Hours24TxCountAsc,
        /// <summary>
        /// <c>h24_volume_usd_desc</c>
        /// </summary>
        [Map("h24_volume_usd_desc")]
        Hours24VolumeUsdDesc,
        /// <summary>
        /// <c>h24_volume_usd_asc</c>
        /// </summary>
        [Map("h24_volume_usd_asc")]
        Hours24VolumeUsdAsc,
        /// <summary>
        /// <c>m5_price_change_percentage_asc</c>
        /// </summary>
        [Map("m5_price_change_percentage_asc")]
        Minutes5PriceChangePercentageAsc,
        /// <summary>
        /// <c>h1_price_change_percentage_asc</c>
        /// </summary>
        [Map("h1_price_change_percentage_asc")]
        Hours1PriceChangePercentageAsc,
        /// <summary>
        /// <c>h6_price_change_percentage_asc</c>
        /// </summary>
        [Map("h6_price_change_percentage_asc")]
        Hours6PriceChangePercentageAsc,
        /// <summary>
        /// <c>h24_price_change_percentage_asc</c>
        /// </summary>
        [Map("h24_price_change_percentage_asc")]
        Hours24PriceChangePercentageAsc,
        /// <summary>
        /// <c>m5_price_change_percentage_desc</c>
        /// </summary>
        [Map("m5_price_change_percentage_desc")]
        Minutes5PriceChangePercentageDesc,
        /// <summary>
        /// <c>h1_price_change_percentage_desc</c>
        /// </summary>
        [Map("h1_price_change_percentage_desc")]
        Hours1PriceChangePercentageDesc,
        /// <summary>
        /// <c>h6_price_change_percentage_desc</c>
        /// </summary>
        [Map("h6_price_change_percentage_desc")]
        Hours6PriceChangePercentageDesc,
        /// <summary>
        /// <c>h24_price_change_percentage_desc</c>
        /// </summary>
        [Map("h24_price_change_percentage_desc")]
        Hours24PriceChangePercentageDesc,
        /// <summary>
        /// <c>fdv_usd_asc</c>
        /// </summary>
        [Map("fdv_usd_asc")]
        FdvUsdAsc,
        /// <summary>
        /// <c>fdv_usd_desc</c>
        /// </summary>
        [Map("fdv_usd_desc")]
        FdvUsdDesc,
        /// <summary>
        /// <c>reserve_in_usd_asc</c>
        /// </summary>
        [Map("reserve_in_usd_asc")]
        ReserveInUsdAsc,
        /// <summary>
        /// <c>reserve_in_usd_desc</c>
        /// </summary>
        [Map("reserve_in_usd_desc")]
        ReserveInUsdDesc,
        /// <summary>
        /// <c>price_asc</c>
        /// </summary>
        [Map("price_asc")]
        PriceAsc,
        /// <summary>
        /// <c>price_desc</c>
        /// </summary>
        [Map("price_desc")]
        PriceDesc,
        /// <summary>
        /// <c>pool_created_at_desc</c>
        /// </summary>
        [Map("pool_created_at_desc")]
        PoolCreatedAtDesc
    }
}
