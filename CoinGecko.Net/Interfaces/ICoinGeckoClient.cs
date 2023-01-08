namespace CoinGecko.Net.Interfaces
{
    /// <summary>
    /// Client for accessing the CoinGecko Rest API. 
    /// </summary>
    public interface ICoinGeckoClient
    {
        /// <summary>
        /// Api endpoints
        /// </summary>
        ICoinGeckoClientApi Api { get; }
    }
}
