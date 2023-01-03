using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Tickers
    /// </summary>
    public class CoinGeckoTickers
    {
        /// <summary>
        /// Coin name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Tickers
        /// </summary>
        public IEnumerable<CoinGeckoTicker> Tickers { get; set; } = Array.Empty<CoinGeckoTicker>();
    }
}
