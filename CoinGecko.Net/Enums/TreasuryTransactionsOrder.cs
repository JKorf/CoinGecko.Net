using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Treasury Transactions Order
    /// </summary>
    public enum TreasuryTransactionsOrder
    {
        /// <summary>
        /// <c>date_desc</c>
        /// </summary>
        [Map("date_desc")]
        DateDesc,
        /// <summary>
        /// <c>date_asc</c>
        /// </summary>
        [Map("date_asc")]
        DateAsc,
        /// <summary>
        /// <c>holding_net_change_desc</c>
        /// </summary>
        [Map("holding_net_change_desc")]
        HoldingNetChangeDesc,
        /// <summary>
        /// <c>holding_net_change_asc</c>
        /// </summary>
        [Map("holding_net_change_asc")]
        HoldingNetChangeAsc,
        /// <summary>
        /// <c>transaction_value_usd_desc</c>
        /// </summary>
        [Map("transaction_value_usd_desc")]
        TransactionValueUsdDesc,
        /// <summary>
        /// <c>transaction_value_usd_asc</c>
        /// </summary>
        [Map("transaction_value_usd_asc")]
        TransactionValueUsdAsc,
        /// <summary>
        /// <c>average_cost_desc</c>
        /// </summary>
        [Map("average_cost_desc")]
        AverageCostDesc,
        /// <summary>
        /// <c>average_cost_asc</c>
        /// </summary>
        [Map("average_cost_asc")]
        AverageCostAsc
    }
}
