using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoinGecko.Net.Objects.Models;
using CryptoExchange.Net.Interfaces.Clients;
using CryptoExchange.Net.Objects;

namespace CoinGecko.Net.Interfaces
{
    /// <summary>
    /// CoinGecko API endpoints
    /// </summary>
    public interface ICoinGeckoRestClientDexApi : IRestApiClient<CoinGeckoCredentials>
    {
        /// <summary>
        /// Get dex networks
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/networks-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks
        /// </para>
        /// </summary>
        /// <param name="page">Page number</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoDexNetworksResponse>> GetDexNetworksAsync(int page = 1, CancellationToken ct = default);

        /// <summary>
        /// Search pools
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/search-pools" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/search/pools
        /// </para>
        /// </summary>
        /// <param name="query">Search query, can be pool contract address, token name, token symbol, or token contract address</param>
        /// <param name="network">The network id</param>
        /// <param name="include">Attributes to include. Available values: base_token, quote_token, dex</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoDexSearchPoolsResponse>> SearchPoolsAsync(string query, string? network = null, IEnumerable<string>? include = null, CancellationToken ct = default);


    }
}
