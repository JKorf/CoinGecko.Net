using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Top Pools By Token Address Sort
    /// </summary>
    public enum TopPoolsByTokenAddressSort
    {
        /// <summary>
        /// <c>h24_volume_usd_liquidity_desc</c>
        /// </summary>
        [Map("h24_volume_usd_liquidity_desc")]
        Hours24VolumeUsdLiquidityDesc,
        /// <summary>
        /// <c>h24_tx_count_desc</c>
        /// </summary>
        [Map("h24_tx_count_desc")]
        Hours24TxCountDesc,
        /// <summary>
        /// <c>h24_volume_usd_desc</c>
        /// </summary>
        [Map("h24_volume_usd_desc")]
        Hours24VolumeUsdDesc
    }
}
