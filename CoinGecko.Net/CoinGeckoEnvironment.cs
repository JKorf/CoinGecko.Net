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
        /// Rest client address public API
        /// </summary>
        public string RestApiAddressPublic { get; }
        /// <summary>
        /// Rest client address pro API
        /// </summary>
        public string RestApiAddressPro { get; }

        internal CoinGeckoEnvironment(string name,
            string restBaseAddressPublic,
            string restBaseAddressPro) : base(name)
        {
            RestApiAddressPublic = restBaseAddressPublic;
            RestApiAddressPro = restBaseAddressPro;
        }

        /// <summary>
        /// ctor for DI, use <see cref="CreateCustom"/> for creating a custom environment
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public CoinGeckoEnvironment() : base(TradeEnvironmentNames.Live)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        { }

        /// <summary>
        /// Get the CoinGecko environment by name
        /// </summary>
        public static CoinGeckoEnvironment? GetEnvironmentByName(string? name)
         => name switch
         {
             TradeEnvironmentNames.Live => Live,
             "" => Live,
             null => Live,
             _ => default
         };

        /// <summary>
        /// Live environment
        /// </summary>
        public static CoinGeckoEnvironment Live { get; }
            = new CoinGeckoEnvironment(TradeEnvironmentNames.Live,
                                     CoinGeckoApiAddresses.Default.RestClientAddressPublic,
                                     CoinGeckoApiAddresses.Default.RestClientAddressPro);

        /// <summary>
        /// Create a custom environment
        /// </summary>
        /// <returns></returns>
        public static CoinGeckoEnvironment CreateCustom(
                        string name,
                        string restAddressPublic,
                        string restAddressPro)
            => new CoinGeckoEnvironment(name, restAddressPublic, restAddressPro);
    }
}
