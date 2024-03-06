using CoinGecko.Net.Interfaces;
using CoinGecko.Net.Objects;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System;
using CoinGecko.Net.Objects.Options;
using CryptoExchange.Net.Clients;

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
        public CoinGeckoRestClient(Action<CoinGeckoRestOptions> optionsDelegate) : this(null, null, optionsDelegate)
        {
        }

        /// <summary>
        /// Create a new instance of the CoinGeckoClient using default options
        /// </summary>
        public CoinGeckoRestClient(ILoggerFactory? loggerFactory = null, HttpClient? httpClient = null) : this(httpClient, loggerFactory, null)
        {
        }

        /// <summary>
        /// Create a new instance of the CoinGeckoClient
        /// </summary>
        /// <param name="optionsDelegate">Option configuration delegate</param>
        /// <param name="loggerFactory">The logger factory</param>
        /// <param name="httpClient">Http client for this client</param>
        public CoinGeckoRestClient(HttpClient? httpClient, ILoggerFactory? loggerFactory, Action<CoinGeckoRestOptions>? optionsDelegate = null)
            : base(loggerFactory, "CoinGecko")
        {
            var options = CoinGeckoRestOptions.Default.Copy();
            if (optionsDelegate != null)
                optionsDelegate(options);
            Initialize(options);

            Api = AddApiClient(new CoinGeckoRestClientApi(_logger, httpClient, options));
        }
        #endregion

        /// <summary>
        /// Set the default options to be used when creating new clients
        /// </summary>
        /// <param name="optionsDelegate">Option configuration delegate</param>
        public static void SetDefaultOptions(Action<CoinGeckoRestOptions> optionsDelegate)
        {
            var options = CoinGeckoRestOptions.Default.Copy();
            optionsDelegate(options);
            CoinGeckoRestOptions.Default = options;
        }
    }
}
