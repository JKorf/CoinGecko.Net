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
    }
}
