using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Top Pools By Network Sort
    /// </summary>
    public enum TopPoolsByNetworkSort
    {
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
