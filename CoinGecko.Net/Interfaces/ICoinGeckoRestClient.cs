using CryptoExchange.Net.Interfaces.Clients;
using CryptoExchange.Net.Objects.Options;

namespace CoinGecko.Net.Interfaces
{
    /// <summary>
    /// Client for accessing the CoinGecko Rest API. 
    /// </summary>
    public interface ICoinGeckoRestClient : IRestClient<CoinGeckoCredentials>
    {
        /// <summary>
        /// Api endpoints
        /// </summary>
        /// <see cref="ICoinGeckoRestClientApi"/>
        ICoinGeckoRestClientApi Api { get; }
    }
}
