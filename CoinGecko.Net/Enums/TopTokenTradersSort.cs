using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Top Token Traders Sort
    /// </summary>
    public enum TopTokenTradersSort
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
        TotalSellUsdDesc,
        /// <summary>
        /// <c>token_balance_desc</c>
        /// </summary>
        [Map("token_balance_desc")]
        TokenBalanceDesc
    }
}
