using CryptoExchange.Net.Objects.Options;

namespace CoinGecko.Net.Interfaces
{
    /// <summary>
    /// Client for accessing the CoinGecko Rest API. 
    /// </summary>
    public interface ICoinGeckoRestClient
    {
        /// <summary>
        /// Api endpoints
        /// </summary>
        ICoinGeckoRestClientApi Api { get; }

        /// <summary>
        /// Update specific options
        /// </summary>
        /// <param name="options">Options to update. Only specific options are changable after the client has been created</param>
        void SetOptions(UpdateOptions options);
    }
}
