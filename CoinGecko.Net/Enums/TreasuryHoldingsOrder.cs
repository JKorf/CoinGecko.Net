using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Treasury Holdings Order
    /// </summary>
    public enum TreasuryHoldingsOrder
    {
        /// <summary>
        /// <c>total_holdings_usd_desc</c>
        /// </summary>
        [Map("total_holdings_usd_desc")]
        TotalHoldingsUsdDesc,
        /// <summary>
        /// <c>total_holdings_usd_asc</c>
        /// </summary>
        [Map("total_holdings_usd_asc")]
        TotalHoldingsUsdAsc
    }
}
