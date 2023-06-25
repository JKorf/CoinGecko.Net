using CryptoExchange.Net.Objects.Options;

namespace CoinGecko.Net.Objects.Options
{
    /// <summary>
    /// CoinGecko Rest API options
    /// </summary>
    public class CoinGeckoRestOptions : RestExchangeOptions<CoinGeckoEnvironment>
    {
        /// <summary>
        /// Default options for the CoinGecko client
        /// </summary>
        public static CoinGeckoRestOptions Default { get; set; } = new CoinGeckoRestOptions()
        {
            Environment = CoinGeckoEnvironment.Live
        };

        /// <summary>
        /// Api options
        /// </summary>
        public RestApiOptions ApiOptions { get; private set; } = new RestApiOptions();

        internal CoinGeckoRestOptions Copy()
        {
            var options = Copy<CoinGeckoRestOptions>();
            options.ApiOptions = ApiOptions.Copy<RestApiOptions>();
            return options;
        }
    }
}
