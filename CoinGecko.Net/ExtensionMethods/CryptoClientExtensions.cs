using CoinGecko.Net.Clients;
using CoinGecko.Net.Interfaces;
using CryptoExchange.Net.Interfaces.CommonClients;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoExchange.Net.Interfaces
{
    /// <summary>
    /// Extensions for the ICryptoRestClient and ICryptoSocketClient interfaces
    /// </summary>
    public static class CryptoClientExtensions
    {
        /// <summary>
        /// Get the CoinGecko REST Api client
        /// </summary>
        /// <param name="baseClient"></param>
        /// <returns></returns>
        public static ICoinGeckoRestClient CoinGecko(this ICryptoRestClient baseClient) => baseClient.TryGet<ICoinGeckoRestClient>(() => new CoinGeckoRestClient());
    }
}
