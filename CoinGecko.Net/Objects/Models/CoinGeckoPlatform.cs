using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Platform info
    /// </summary>
    public class CoinGeckoPlatform
    {
        /// <summary>
        /// Decimal places
        /// </summary>
        [JsonProperty("decimail_places")]
        public int DecimalPlaces { get; set; }
        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("contract_address")]
        public string ContractAddress { get; set; } = string.Empty;
    }
}
