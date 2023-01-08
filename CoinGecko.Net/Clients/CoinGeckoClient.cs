using CoinGecko.Net.Interfaces;
using CoinGecko.Net.Objects;
using CryptoExchange.Net;

namespace CoinGecko.Net.Clients
{
    public class CoinGeckoClient: BaseRestClient, ICoinGeckoClient
    {
        /// <inheritdoc />
        public ICoinGeckoClientApi Api { get; }

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
            Api = AddApiClient(new CoinGeckoClientApi(log, options));
        }
        #endregion
    }
}
