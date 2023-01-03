using Bybit.Net.Objects;
using CoinGecko.Net.Clients.AssetApi;
using CryptoExchange.Net;
using System;

namespace CoinGecko.Net.Clients
{
    public class CoinGeckoClient: BaseRestClient
    {
        /// <inheritdoc />
        public CoinGeckoApi Api { get; }

        #region constructor/destructor
        /// <summary>
        /// Create a new instance of the BybitClient using the default options
        /// </summary>
        public CoinGeckoClient() : this(CoinGeckoClientOptions.Default)
        {
        }

        /// <summary>
        /// Create a new instance of the BybitClient using provided options
        /// </summary>
        /// <param name="options">The options to use for this client</param>
        public CoinGeckoClient(CoinGeckoClientOptions options) : base("CoinGecko", options)
        {
            Api = AddApiClient(new CoinGeckoApi(log, options));
        }
        #endregion
    }
}
