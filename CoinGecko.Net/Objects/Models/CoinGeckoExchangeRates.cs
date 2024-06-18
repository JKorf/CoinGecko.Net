using System.Collections.Generic;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Exchange rates
    /// </summary>
    public record CoinGeckoExchangeRates
    {
        /// <summary>
        /// Rates dictionary
        /// </summary>
        public Dictionary<string, CoinGeckoExchangeRate> Rates { get; set; } = new Dictionary<string, CoinGeckoExchangeRate>();
    }

    /// <summary>
    /// Exchange rate
    /// </summary>
    public record CoinGeckoExchangeRate
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Unit
        /// </summary>
        public string Unit { get; set; } = string.Empty;
        /// <summary>
        /// Value
        /// </summary>
        public decimal? Value { get; set; }
        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; } = string.Empty;
    }
}
