using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// DEX pair formatting
    /// </summary>
    public enum DexPairFormat
    {
        /// <summary>
        /// As symbol, for example `USDC`
        /// </summary>
        [Map("symbol")]
        Symbol,
        /// <summary>
        /// As contract address
        /// </summary>
        [Map("contract_address")]
        ContractAddress
    }
}
