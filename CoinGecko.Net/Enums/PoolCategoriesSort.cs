using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Pool Categories Sort
    /// </summary>
    public enum PoolCategoriesSort
    {
        /// <summary>
        /// <c>h1_volume_percentage_desc</c>
        /// </summary>
        [Map("h1_volume_percentage_desc")]
        Hours1VolumePercentageDesc,
        /// <summary>
        /// <c>h6_volume_percentage_desc</c>
        /// </summary>
        [Map("h6_volume_percentage_desc")]
        Hours6VolumePercentageDesc,
        /// <summary>
        /// <c>h12_volume_percentage_desc</c>
        /// </summary>
        [Map("h12_volume_percentage_desc")]
        Hours12VolumePercentageDesc,
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
        /// <c>fdv_usd_desc</c>
        /// </summary>
        [Map("fdv_usd_desc")]
        FdvUsdDesc,
        /// <summary>
        /// <c>reserve_in_usd_desc</c>
        /// </summary>
        [Map("reserve_in_usd_desc")]
        ReserveInUsdDesc
    }
}
