using CryptoExchange.Net.Objects;

namespace CoinGecko.Net.Objects
{
    /// <summary>
    /// Options for the CoinGecko client
    /// </summary>
    public class CoinGeckoClientOptions : ClientOptions
    {
        /// <summary>
        /// Default options for the CoinGecko client
        /// </summary>
        public static CoinGeckoClientOptions Default { get; set; } = new CoinGeckoClientOptions();

        private RestApiClientOptions _apiOptions = new RestApiClientOptions(CoinGeckoApiAddresses.Default.RestClientAddress);
        /// <summary>
        /// API options
        /// </summary>
        public RestApiClientOptions ApiOptions
        {
            get => _apiOptions;
            set => _apiOptions = new RestApiClientOptions(_apiOptions, value);
        }

        /// <summary>
        /// ctor
        /// </summary>
        public CoinGeckoClientOptions() : this(Default)
        {
        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="baseOn">Base the new options on other options</param>
        internal CoinGeckoClientOptions(CoinGeckoClientOptions baseOn) : base(baseOn)
        {
            if (baseOn == null)
                return;

            ApiOptions = new RestApiClientOptions(baseOn.ApiOptions, null);
        }
    }
}
