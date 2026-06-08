using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CoinGecko.Net.Clients.MessageHandlers;
using CoinGecko.Net.Interfaces;
using CoinGecko.Net.Objects.Models;
using CoinGecko.Net.Objects.Options;
using CryptoExchange.Net.Clients;
using CryptoExchange.Net.Converters.MessageParsing.DynamicConverters;
using CryptoExchange.Net.Converters.SystemTextJson;
using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Objects.Errors;
using CryptoExchange.Net.SharedApis;
using Microsoft.Extensions.Logging;

namespace CoinGecko.Net.Clients
{
    /// <inheritdoc />
    internal class CoinGeckoRestClientDexApi : RestApiClient<CoinGeckoEnvironment, CoinGeckoAuthenticationProvider, CoinGeckoCredentials>, ICoinGeckoRestClientDexApi
    {
        private static readonly RequestDefinitionCache _definitions = new RequestDefinitionCache();
        private readonly CoinGeckoRestOptions _options;

        protected override IRestMessageHandler MessageHandler { get; } = new CoinGeckoRestMessageHandler(new ErrorMapping([]));

        internal CoinGeckoRestClientDexApi(CoinGeckoRestClient baseClient, ILogger logger, HttpClient? httpClient, CoinGeckoRestOptions options)
            : base(logger, httpClient, options.Environment.RestApiAddressPublic, options, options.ApiOptions)
        {
            _options = options;
            StandardRequestHeaders = new Dictionary<string, string>
            {
                { "User-Agent", "CryptoExchange.Net/" + baseClient.CryptoExchangeLibVersion.ToString() }
            };
        }

        /// <inheritdoc />
        protected override IMessageSerializer CreateSerializer() => new SystemTextJsonMessageSerializer(SerializerOptions.WithConverters(CoinGeckoApi.SerializationContext));

        /// <inheritdoc />
        public override string FormatSymbol(string baseAsset, string quoteAsset, TradingMode tradingMode, DateTime? deliverTime = null) => throw new NotImplementedException();

        #region Search Pools

        /// <inheritdoc />
        public Task<WebCallResult<CoinGeckoDexSearchPoolsResponse>> SearchPoolsAsync(string query, string? network = null, IEnumerable<string>? include = null, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.Add("query", query);
            parameters.AddOptional("network", network);
            parameters.AddOptionalCommaSeparated("include", include);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/onchain/search/pools", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return SendAsync<CoinGeckoDexSearchPoolsResponse>(GetBaseAddress(), request, parameters, ct);
        }

        #endregion

        #region Get Networks

        /// <inheritdoc />
        public Task<WebCallResult<CoinGeckoDexNetworksResponse>> GetDexNetworksAsync(int page = 1, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.Add("page", page);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/onchain/networks", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return SendAsync<CoinGeckoDexNetworksResponse>(GetBaseAddress(), request, parameters, ct);
        }

        #endregion

        #region Get Token OHLCV

        /// <inheritdoc />
        public Task<WebCallResult<CoinGeckoDexOhlcvResponse>> GetTokenOhlcvAsync(
            string network,
            string tokenAddress,
            string timeframe,
            int? aggregate = null,
            int? limit = null,
            DateTime? beforeTimestamp = null,
            string? currency = null,
            CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptional("aggregate", aggregate);
            parameters.AddOptional("limit", limit);
            parameters.AddOptional("before_timestamp", beforeTimestamp.HasValue ? DateTimeConverter.ConvertToSeconds(beforeTimestamp.Value) : null);
            parameters.AddOptional("currency", currency);

            var path = $"/api/v3/onchain/networks/{network}/tokens/{tokenAddress}/ohlcv/{timeframe}";
            var request = _definitions.GetOrCreate(HttpMethod.Get, path, CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return SendAsync<CoinGeckoDexOhlcvResponse>(GetBaseAddress(), request, parameters, ct);
        }

        #endregion



        private string GetBaseAddress()
        {
            if (AuthenticationProvider != null)
            {
                if (((CoinGeckoAuthenticationProvider)AuthenticationProvider).IsDemo)
                    return _options.Environment.RestApiAddressPublic;

                return _options.Environment.RestApiAddressPro;
            }

            return _options.Environment.RestApiAddressPublic;
        }

        /// <inheritdoc />
        protected override CoinGeckoAuthenticationProvider CreateAuthenticationProvider(CoinGeckoCredentials credentials)
            => new CoinGeckoAuthenticationProvider(credentials);
    }
}
