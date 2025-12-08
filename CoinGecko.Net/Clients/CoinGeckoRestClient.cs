using CoinGecko.Net.Interfaces;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System;
using CoinGecko.Net.Objects.Options;
using CryptoExchange.Net.Clients;
using Microsoft.Extensions.Options;
using CryptoExchange.Net.Objects.Options;

namespace CoinGecko.Net.Clients
{
    /// <inheritdoc />
    public class CoinGeckoRestClient: BaseRestClient, ICoinGeckoRestClient
    {
        /// <inheritdoc />
        public ICoinGeckoRestClientApi Api { get; }

        #region constructor/destructor
        /// <summary>
        /// Create a new instance of the CoinGeckoClient using provided options
        /// </summary>
        /// <param name="optionsDelegate">Option configuration delegate</param>
        public CoinGeckoRestClient(Action<CoinGeckoRestOptions>? optionsDelegate = null)
            : this(null, null, Options.Create(ApplyOptionsDelegate(optionsDelegate)))
        {
        }

        /// <summary>
        /// Create a new instance of the CoinGeckoClient
        /// </summary>
        /// <param name="options">Option configuration</param>
        /// <param name="loggerFactory">The logger factory</param>
        /// <param name="httpClient">Http client for this client</param>
        public CoinGeckoRestClient(HttpClient? httpClient, ILoggerFactory? loggerFactory, IOptions<CoinGeckoRestOptions> options)
            : base(loggerFactory, "CoinGecko")
        {
            Initialize(options.Value);

            Api = AddApiClient(new CoinGeckoRestClientApi(this, _logger, httpClient, options.Value));
        }
        #endregion

        /// <inheritdoc />
        public void SetOptions(UpdateOptions options)
        {
            Api.SetOptions(options);
        }

        /// <summary>
        /// Set the default options to be used when creating new clients
        /// </summary>
        /// <param name="optionsDelegate">Option configuration delegate</param>
        public static void SetDefaultOptions(Action<CoinGeckoRestOptions> optionsDelegate)
        {
            CoinGeckoRestOptions.Default = ApplyOptionsDelegate(optionsDelegate);
        }
    }
}
