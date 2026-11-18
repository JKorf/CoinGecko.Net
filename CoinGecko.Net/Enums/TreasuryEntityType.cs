using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Type of treasury entity
    /// </summary>
    public enum TreasuryEntityType
    {
        /// <summary>
        /// Public company
        /// </summary>
        [Map("company")]
        Company,
        /// <summary>
        /// Government
        /// </summary>
        [Map("government")]
        Government
    }
}
