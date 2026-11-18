using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Treasury Holding Entity Type
    /// </summary>
    public enum TreasuryHoldingEntityType
    {
        /// <summary>
        /// <c>companies</c>
        /// </summary>
        [Map("companies")]
        Companies,
        /// <summary>
        /// <c>governments</c>
        /// </summary>
        [Map("governments")]
        Governments
    }
}
