using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Wallet Token Balances Sort
    /// </summary>
    public enum WalletTokenBalancesSort
    {
        /// <summary>
        /// <c>value_usd_desc</c>
        /// </summary>
        [Map("value_usd_desc")]
        ValueUsdDesc,
        /// <summary>
        /// <c>value_usd_asc</c>
        /// </summary>
        [Map("value_usd_asc")]
        ValueUsdAsc
    }
}
