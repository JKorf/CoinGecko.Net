using System;
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

        /// <summary>
        /// Get OHLCV data for a token by its contract address on a given network.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/token-ohlcv-token-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/tokens/{token_address}/ohlcv/{timeframe}
        /// </para>
        /// </summary>
        /// <param name="network">The CoinGecko on-chain network id (e.g. "eth", "solana")</param>
        /// <param name="tokenAddress">The token contract address</param>
        /// <param name="timeframe">Candle timeframe: "day", "hour", "minute", or "second"</param>
        /// <param name="aggregate">Time period to aggregate each OHLCV (e.g. 1, 5, 15)</param>
        /// <param name="limit">Maximum number of candles to return (max 1000, default 100)</param>
        /// <param name="beforeTimestamp">Return candles before this timestamp (UTC)</param>
        /// <param name="currency">Quote currency. Either "usd" or "token". Defaults to "usd"</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoDexOhlcvResponse>> GetTokenOhlcvAsync(
            string network,
            string tokenAddress,
            string timeframe,
            int? aggregate = null,
            int? limit = null,
            DateTime? beforeTimestamp = null,
            string? currency = null,
            CancellationToken ct = default);
    }
}
