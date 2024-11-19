using CryptoExchange.Net.Objects.Options;

namespace CoinGecko.Net.Objects.Options
{
    /// <summary>
    /// CoinGecko Rest API options
    /// </summary>
    public class CoinGeckoRestOptions : RestExchangeOptions<CoinGeckoEnvironment, CoinGeckoApiCredentials>
    {
        /// <summary>
        /// Default options for the CoinGecko client
        /// </summary>
        internal static CoinGeckoRestOptions Default { get; set; } = new CoinGeckoRestOptions()
        {
            Environment = CoinGeckoEnvironment.Live
        };

        /// <summary>
        /// ctor
        /// </summary>
        public CoinGeckoRestOptions()
        {
            Default?.Set(this);
        }

        /// <summary>
        /// Api options
        /// </summary>
        public RestApiOptions ApiOptions { get; private set; } = new RestApiOptions();

        internal CoinGeckoRestOptions Set(CoinGeckoRestOptions targetOptions)
        {
            targetOptions = base.Set<CoinGeckoRestOptions>(targetOptions);
            targetOptions.ApiOptions = ApiOptions.Set(targetOptions.ApiOptions);
            return targetOptions;
        }
    }
}
