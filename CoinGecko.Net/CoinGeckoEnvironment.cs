using CoinGecko.Net.Objects;
using CryptoExchange.Net.Objects;

namespace CoinGecko.Net
{
    /// <summary>
    /// CoinGecko Environments
    /// </summary>
    public class CoinGeckoEnvironment : TradeEnvironment
    {
        /// <summary>
        /// Rest client address
        /// </summary>
        public string RestApiAddress { get; }

        internal CoinGeckoEnvironment(string name,
            string restBaseAddress) : base(name)
        {
            RestApiAddress = restBaseAddress;
        }

        /// <summary>
        /// Live environment
        /// </summary>
        public static CoinGeckoEnvironment Live { get; }
            = new CoinGeckoEnvironment(TradeEnvironmentNames.Live,
                                     CoinGeckoApiAddresses.Default.RestClientAddress);

        /// <summary>
        /// Create a custom environment
        /// </summary>
        /// <param name="name"></param>
        /// <param name="restAddress"></param>
        /// <returns></returns>
        public static CoinGeckoEnvironment CreateCustom(
                        string name,
                        string restAddress)
            => new CoinGeckoEnvironment(name, restAddress);
    }
}
