using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Wallet Pnl Sort
    /// </summary>
    public enum WalletPnlSort
    {
        /// <summary>
        /// <c>realized_pnl_usd_desc</c>
        /// </summary>
        [Map("realized_pnl_usd_desc")]
        RealizedPnlUsdDesc,
        /// <summary>
        /// <c>unrealized_pnl_usd_desc</c>
        /// </summary>
        [Map("unrealized_pnl_usd_desc")]
        UnrealizedPnlUsdDesc,
        /// <summary>
        /// <c>total_buy_usd_desc</c>
        /// </summary>
        [Map("total_buy_usd_desc")]
        TotalBuyUsdDesc,
        /// <summary>
        /// <c>total_sell_usd_desc</c>
        /// </summary>
        [Map("total_sell_usd_desc")]
        TotalSellUsdDesc
    }
}
