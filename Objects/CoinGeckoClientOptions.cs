using CryptoExchange.Net.Objects;

namespace Bybit.Net.Objects
{
    /// <summary>
    /// Options for the Bybit client
    /// </summary>
    public class CoinGeckoClientOptions : ClientOptions
    {
        /// <summary>
        /// Default options for the Bybit client
        /// </summary>
        public static CoinGeckoClientOptions Default { get; set; } = new CoinGeckoClientOptions();

        private RestApiClientOptions _spotApiOptions = new RestApiClientOptions(CoinGeckoApiAddresses.Default.SpotRestClientAddress);
        /// <summary>
        /// Spot API options
        /// </summary>
        public RestApiClientOptions SpotApiOptions
        {
            get => _spotApiOptions;
            set => _spotApiOptions = new RestApiClientOptions(_spotApiOptions, value);
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

            SpotApiOptions = new RestApiClientOptions(baseOn.SpotApiOptions, null);
        }
    }
}
