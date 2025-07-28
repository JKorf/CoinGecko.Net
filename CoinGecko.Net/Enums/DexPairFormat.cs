using CryptoExchange.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
