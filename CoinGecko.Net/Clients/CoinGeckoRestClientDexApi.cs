using CoinGecko.Net.Enums;
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

        internal CoinGeckoRestClientDexApi(CoinGeckoRestClient baseClient, ILoggerFactory? loggerFactory, HttpClient? httpClient, CoinGeckoRestOptions options)
            : base(loggerFactory, CoinGeckoApi.Metadata.Id, httpClient, options.Environment.RestApiAddressPublic, options, options.ApiOptions)
        {
            _options = options;
            StandardRequestHeaders = new Dictionary<string, string>
            {
                { "User-Agent", "CryptoExchange.Net/" + baseClient.CryptoExchangeLibVersion.ToString() }
            };
        }

        /// <inheritdoc />
        protected override IMessageSerializer CreateSerializer() => new SystemTextJsonMessageSerializer(SerializerOptions.WithConverters(CoinGeckoApi._serializationContext));

        /// <inheritdoc />
        public override string FormatSymbol(string baseAsset, string quoteAsset, TradingMode tradingMode, DateTime? deliverTime = null) => throw new NotImplementedException();

        #region Search Pools

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexSearchPoolsResponse>> SearchPoolsAsync(string query, string? network = null, IEnumerable<PoolInclude>? include = null, int? page = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("query", query);
            parameters.Add("network", network);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("page", page);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/onchain/search/pools", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return SendAsync<CoinGeckoDexSearchPoolsResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Networks

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexNetworksResponse>> GetDexNetworksAsync(int page = 1, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("page", page);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/onchain/networks", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return SendAsync<CoinGeckoDexNetworksResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Token OHLCV

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexOhlcvResponse>> GetTokenOhlcvAsync(
            string network,
            string tokenAddress,
            DexOhlcvTimeframe timeframe,
            int? aggregate = null,
            int? limit = null,
            DateTime? beforeTimestamp = null,
            DexOhlcvCurrency? currency = null,
            bool? includeEmptyIntervals = null,
            bool? includeInactiveSource = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("aggregate", aggregate);
            parameters.Add("limit", limit);
            parameters.Add("before_timestamp", beforeTimestamp.HasValue ? DateTimeConverter.ConvertToSeconds(beforeTimestamp.Value) : null);
            parameters.Add("currency", currency);
            parameters.Add("include_empty_intervals", includeEmptyIntervals);
            parameters.Add("include_inactive_source", includeInactiveSource);

            var path = $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/tokens/{Uri.EscapeDataString(tokenAddress)}/ohlcv/{EnumConverter.GetString(timeframe)}";
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), path, CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexOhlcvResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Pool

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexPoolResponse>> GetPoolAsync(
            string network,
            string address,
            IEnumerable<PoolInclude>? include = null,
            bool? includeVolumeBreakdown = null,
            bool? includeComposition = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("include_volume_breakdown", includeVolumeBreakdown);
            parameters.Add("include_composition", includeComposition);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/pools/{Uri.EscapeDataString(address)}", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexPoolResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Trending Pools

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexPoolsResponse>> GetTrendingPoolsAsync(
            IEnumerable<TrendingPoolsInclude>? include = null,
            int? page = null,
            DexPoolDuration? duration = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("page", page);
            parameters.Add("duration", duration);
            parameters.Add("include_gt_community_data", includeGtCommunityData);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/onchain/networks/trending_pools", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexPoolsResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Trending Pools By Network

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexPoolsResponse>> GetTrendingPoolsByNetworkAsync(
            string network,
            IEnumerable<PoolInclude>? include = null,
            int? page = null,
            DexPoolDuration? duration = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("page", page);
            parameters.Add("duration", duration);
            parameters.Add("include_gt_community_data", includeGtCommunityData);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/trending_pools", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexPoolsResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Top Pools By Network

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexPoolsResponse>> GetTopPoolsByNetworkAsync(
            string network,
            IEnumerable<PoolInclude>? include = null,
            int? page = null,
            TopPoolsByNetworkSort? sort = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("page", page);
            parameters.Add("sort", sort);
            parameters.Add("include_gt_community_data", includeGtCommunityData);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/pools", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexPoolsResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Top Pools By Dex

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexPoolsResponse>> GetTopPoolsByDexAsync(
            string network,
            string dex,
            IEnumerable<PoolInclude>? include = null,
            int? page = null,
            TopPoolsByNetworkSort? sort = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("page", page);
            parameters.Add("sort", sort);
            parameters.Add("include_gt_community_data", includeGtCommunityData);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/dexes/{Uri.EscapeDataString(dex)}/pools", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexPoolsResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Filtered Pools

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexPoolsResponse>> GetFilteredPoolsAsync(
            IEnumerable<string>? networks = null,
            IEnumerable<string>? dexes = null,
            IEnumerable<string>? quoteTokenAddresses = null,
            FilteredPoolsQuoteTokenPreset? quoteTokenPreset = null,
            IEnumerable<TrendingPoolsInclude>? include = null,
            int? page = null,
            FilteredPoolsSort? sort = null,
            decimal? fdvUsdMin = null,
            decimal? fdvUsdMax = null,
            decimal? reserveInUsdMin = null,
            decimal? reserveInUsdMax = null,
            decimal? h24VolumeUsdMin = null,
            decimal? h24VolumeUsdMax = null,
            decimal? poolCreatedHourMin = null,
            decimal? poolCreatedHourMax = null,
            int? txCountMin = null,
            int? txCountMax = null,
            DexPoolDuration? txCountDuration = null,
            int? buysMin = null,
            int? buysMax = null,
            DexPoolDuration? buysDuration = null,
            int? sellsMin = null,
            int? sellsMax = null,
            DexPoolDuration? sellsDuration = null,
            decimal? priceChangePercentageMin = null,
            decimal? priceChangePercentageMax = null,
            DexPoolDuration? priceChangePercentageDuration = null,
            decimal? buyTaxPercentageMin = null,
            decimal? buyTaxPercentageMax = null,
            decimal? sellTaxPercentageMin = null,
            decimal? sellTaxPercentageMax = null,
            int? holderCountMin = null,
            int? holderCountMax = null,
            decimal? top10HoldersPercentageMin = null,
            decimal? top10HoldersPercentageMax = null,
            IEnumerable<FilteredPoolsCheck>? checks = null,
            bool? includeUnknownHoneypotTokens = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("networks", networks);
            parameters.AddCommaSeparated("dexes", dexes);
            parameters.AddCommaSeparated("quote_token_addresses", quoteTokenAddresses);
            parameters.Add("quote_token_preset", quoteTokenPreset);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("page", page);
            parameters.Add("sort", sort);
            parameters.Add("fdv_usd_min", fdvUsdMin);
            parameters.Add("fdv_usd_max", fdvUsdMax);
            parameters.Add("reserve_in_usd_min", reserveInUsdMin);
            parameters.Add("reserve_in_usd_max", reserveInUsdMax);
            parameters.Add("h24_volume_usd_min", h24VolumeUsdMin);
            parameters.Add("h24_volume_usd_max", h24VolumeUsdMax);
            parameters.Add("pool_created_hour_min", poolCreatedHourMin);
            parameters.Add("pool_created_hour_max", poolCreatedHourMax);
            parameters.Add("tx_count_min", txCountMin);
            parameters.Add("tx_count_max", txCountMax);
            parameters.Add("tx_count_duration", txCountDuration);
            parameters.Add("buys_min", buysMin);
            parameters.Add("buys_max", buysMax);
            parameters.Add("buys_duration", buysDuration);
            parameters.Add("sells_min", sellsMin);
            parameters.Add("sells_max", sellsMax);
            parameters.Add("sells_duration", sellsDuration);
            parameters.Add("price_change_percentage_min", priceChangePercentageMin);
            parameters.Add("price_change_percentage_max", priceChangePercentageMax);
            parameters.Add("price_change_percentage_duration", priceChangePercentageDuration);
            parameters.Add("buy_tax_percentage_min", buyTaxPercentageMin);
            parameters.Add("buy_tax_percentage_max", buyTaxPercentageMax);
            parameters.Add("sell_tax_percentage_min", sellTaxPercentageMin);
            parameters.Add("sell_tax_percentage_max", sellTaxPercentageMax);
            parameters.Add("holder_count_min", holderCountMin);
            parameters.Add("holder_count_max", holderCountMax);
            parameters.Add("top_10_holders_percentage_min", top10HoldersPercentageMin);
            parameters.Add("top_10_holders_percentage_max", top10HoldersPercentageMax);
            parameters.AddCommaSeparated("checks", checks);
            parameters.Add("include_unknown_honeypot_tokens", includeUnknownHoneypotTokens);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/onchain/pools/megafilter", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexPoolsResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Trending Pool Searches

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoTrendingSearchPools>> GetTrendingPoolSearchesAsync(
            IEnumerable<TrendingPoolsInclude>? include = null,
            int? pools = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("pools", pools);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/onchain/pools/trending_search", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoTrendingSearchPools>(request, parameters, ct);
        }

        #endregion

        #region Get Top Pools By Token Address

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexPoolsResponse>> GetTopPoolsByTokenAddressAsync(
            string network,
            string tokenAddress,
            IEnumerable<PoolInclude>? include = null,
            bool? includeInactiveSource = null,
            int? page = null,
            TopPoolsByTokenAddressSort? sort = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("include_inactive_source", includeInactiveSource);
            parameters.Add("page", page);
            parameters.Add("sort", sort);
            parameters.Add("include_gt_community_data", includeGtCommunityData);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/tokens/{Uri.EscapeDataString(tokenAddress)}/pools", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexPoolsResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Token

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexTokenResponse>> GetTokenAsync(
            string network,
            string address,
            TokenInclude? include = null,
            bool? includeComposition = null,
            bool? includeInactiveSource = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("include", include);
            parameters.Add("include_composition", includeComposition);
            parameters.Add("include_inactive_source", includeInactiveSource);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/tokens/{Uri.EscapeDataString(address)}", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexTokenResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Tokens

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexTokensResponse>> GetTokensAsync(
            string network,
            IEnumerable<string> addresses,
            TokenInclude? include = null,
            bool? includeComposition = null,
            bool? includeInactiveSource = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("include", include);
            parameters.Add("include_composition", includeComposition);
            parameters.Add("include_inactive_source", includeInactiveSource);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/tokens/multi/{Uri.EscapeDataString(string.Join(",", addresses))}", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexTokensResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Tokens Across Networks

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexMultiNetworkTokensResponse>> GetTokensAcrossNetworksAsync(
            IEnumerable<string> tokens,
            TokenInclude? include = null,
            bool? includeComposition = null,
            bool? includeInactiveSource = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("tokens", tokens);
            parameters.Add("include", include);
            parameters.Add("include_composition", includeComposition);
            parameters.Add("include_inactive_source", includeInactiveSource);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/onchain/tokens/multi", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexMultiNetworkTokensResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Token Info

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexTokenInfoResponse>> GetTokenInfoAsync(
            string network,
            string address,
            CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/tokens/{Uri.EscapeDataString(address)}/info", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexTokenInfoResponse>(request, null, ct);
        }

        #endregion

        #region Get Pool Token Info

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexPoolTokensInfoResponse>> GetPoolTokenInfoAsync(
            string network,
            string poolAddress,
            PoolTokenInfoInclude? include = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("include", include);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/pools/{Uri.EscapeDataString(poolAddress)}/info", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexPoolTokensInfoResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Recently Updated Tokens

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexRecentTokenInfoResponse>> GetRecentlyUpdatedTokensAsync(
            RecentlyUpdatedTokensInclude? include = null,
            string? network = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("include", include);
            parameters.Add("network", network);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/onchain/tokens/info_recently_updated", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexRecentTokenInfoResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Top Token Traders

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoTopTokenTraders>> GetTopTokenTradersAsync(
            string networkId,
            string tokenAddress,
            string? traders = null,
            TopTokenTradersSort? sort = null,
            bool? includeAddressLabel = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("traders", traders);
            parameters.Add("sort", sort);
            parameters.Add("include_address_label", includeAddressLabel);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(networkId)}/tokens/{Uri.EscapeDataString(tokenAddress)}/top_traders", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoTopTokenTraders>(request, parameters, ct);
        }

        #endregion

        #region Get Top Token Holders

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoTopTokenHolders>> GetTopTokenHoldersAsync(
            string network,
            string address,
            string? holders = null,
            bool? includePnlDetails = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("holders", holders);
            parameters.Add("include_pnl_details", includePnlDetails);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/tokens/{Uri.EscapeDataString(address)}/top_holders", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoTopTokenHolders>(request, parameters, ct);
        }

        #endregion

        #region Get Token Holders Chart

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoTokenHoldersChart>> GetTokenHoldersChartAsync(
            string network,
            string tokenAddress,
            string? days = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("days", days);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/tokens/{Uri.EscapeDataString(tokenAddress)}/holders_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoTokenHoldersChart>(request, parameters, ct);
        }

        #endregion

        #region Get Pool Ohlcv

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexOhlcvResponse>> GetPoolOhlcvAsync(
            string network,
            string poolAddress,
            DexOhlcvTimeframe timeframe,
            int? aggregate = null,
            DateTime? beforeTimestamp = null,
            int? limit = null,
            DexOhlcvCurrency? currency = null,
            string? token = null,
            bool? includeEmptyIntervals = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("aggregate", aggregate);
            parameters.Add("before_timestamp", beforeTimestamp.HasValue ? DateTimeConverter.ConvertToSeconds(beforeTimestamp.Value) : null);
            parameters.Add("limit", limit);
            parameters.Add("currency", currency);
            parameters.Add("token", token);
            parameters.Add("include_empty_intervals", includeEmptyIntervals);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/pools/{Uri.EscapeDataString(poolAddress)}/ohlcv/{Uri.EscapeDataString(EnumConverter.GetString(timeframe))}", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexOhlcvResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Pool Trades

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexPoolTradesResponse>> GetPoolTradesAsync(
            string network,
            string poolAddress,
            decimal? tradeVolumeInUsdGreaterThan = null,
            string? token = null,
            DexTradingPeriod? tradingPeriod = null,
            bool? includeAnomalous = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("trade_volume_in_usd_greater_than", tradeVolumeInUsdGreaterThan);
            parameters.Add("token", token);
            parameters.Add("trading_period", tradingPeriod);
            parameters.Add("include_anomalous", includeAnomalous);
            parameters.Add("cursor", cursor);
            parameters.Add("per_page", pageSize);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/pools/{Uri.EscapeDataString(poolAddress)}/trades", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexPoolTradesResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Pool Trades Range

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexPoolTradesResponse>> GetPoolTradesRangeAsync(
            string network,
            string poolAddress,
            DateTime from,
            DateTime to,
            decimal? tradeVolumeInUsdGreaterThan = null,
            string? token = null,
            bool? includeAnomalous = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.Add("to", DateTimeConverter.ConvertToSeconds(to));
            parameters.Add("trade_volume_in_usd_greater_than", tradeVolumeInUsdGreaterThan);
            parameters.Add("token", token);
            parameters.Add("include_anomalous", includeAnomalous);
            parameters.Add("cursor", cursor);
            parameters.Add("per_page", pageSize);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/pools/{Uri.EscapeDataString(poolAddress)}/trades/range", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexPoolTradesResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Pool Liquidity Events

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoPoolLiquidityEvents>> GetPoolLiquidityEventsAsync(
            string network,
            string poolAddress,
            PoolLiquidityEventsKind? kind = null,
            decimal? volumeInUsdGreaterThan = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("kind", kind);
            parameters.Add("volume_in_usd_greater_than", volumeInUsdGreaterThan);
            parameters.Add("cursor", cursor);
            parameters.Add("per_page", pageSize);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/pools/{Uri.EscapeDataString(poolAddress)}/liquidity_events", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoPoolLiquidityEvents>(request, parameters, ct);
        }

        #endregion

        #region Get Token Trades

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexTokenTradesResponse>> GetTokenTradesAsync(
            string network,
            string tokenAddress,
            decimal? tradeVolumeInUsdGreaterThan = null,
            DexTradingPeriod? tradingPeriod = null,
            bool? includeAnomalous = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("trade_volume_in_usd_greater_than", tradeVolumeInUsdGreaterThan);
            parameters.Add("trading_period", tradingPeriod);
            parameters.Add("include_anomalous", includeAnomalous);
            parameters.Add("cursor", cursor);
            parameters.Add("per_page", pageSize);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/tokens/{Uri.EscapeDataString(tokenAddress)}/trades", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexTokenTradesResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Token Trades Range

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexTokenTradesResponse>> GetTokenTradesRangeAsync(
            string network,
            string tokenAddress,
            DateTime from,
            DateTime to,
            decimal? tradeVolumeInUsdGreaterThan = null,
            bool? includeAnomalous = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.Add("to", DateTimeConverter.ConvertToSeconds(to));
            parameters.Add("trade_volume_in_usd_greater_than", tradeVolumeInUsdGreaterThan);
            parameters.Add("include_anomalous", includeAnomalous);
            parameters.Add("cursor", cursor);
            parameters.Add("per_page", pageSize);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/tokens/{Uri.EscapeDataString(tokenAddress)}/trades/range", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexTokenTradesResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Wallet Token Balances

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoWalletTokenBalances>> GetWalletTokenBalancesAsync(
            string address,
            IEnumerable<string> networks,
            WalletTokenBalancesSort? sort = null,
            WalletTokenBalancesTokenType? tokenType = null,
            decimal? valueUsdMin = null,
            decimal? reserveInUsdMin = null,
            int? page = null,
            int? pageSize = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("networks", networks);
            parameters.Add("sort", sort);
            parameters.Add("token_type", tokenType);
            parameters.Add("value_usd_min", valueUsdMin);
            parameters.Add("reserve_in_usd_min", reserveInUsdMin);
            parameters.Add("page", page);
            parameters.Add("per_page", pageSize);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/wallets/{Uri.EscapeDataString(address)}/balances", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoWalletTokenBalances>(request, parameters, ct);
        }

        #endregion

        #region Get Wallet Token Transfers

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoWalletTokenTransfers>> GetWalletTokenTransfersAsync(
            string network,
            string address,
            string? token = null,
            DateTime? from = null,
            DateTime? to = null,
            WalletTokenTransfersDirection? direction = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("token", token);
            parameters.Add("from", from.HasValue ? DateTimeConverter.ConvertToSeconds(from.Value) : null);
            parameters.Add("to", to.HasValue ? DateTimeConverter.ConvertToSeconds(to.Value) : null);
            parameters.Add("direction", direction);
            parameters.Add("cursor", cursor);
            parameters.Add("per_page", pageSize);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/wallets/{Uri.EscapeDataString(address)}/transfers", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoWalletTokenTransfers>(request, parameters, ct);
        }

        #endregion

        #region Get Wallet Trades

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoWalletTrades>> GetWalletTradesAsync(
            string network,
            string address,
            string? token = null,
            DateTime? from = null,
            DateTime? to = null,
            bool? includeAnomalous = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("token", token);
            parameters.Add("from", from.HasValue ? DateTimeConverter.ConvertToSeconds(from.Value) : null);
            parameters.Add("to", to.HasValue ? DateTimeConverter.ConvertToSeconds(to.Value) : null);
            parameters.Add("include_anomalous", includeAnomalous);
            parameters.Add("cursor", cursor);
            parameters.Add("per_page", pageSize);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/wallets/{Uri.EscapeDataString(address)}/trades", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoWalletTrades>(request, parameters, ct);
        }

        #endregion

        #region Get Wallet Pnl

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoWalletPnl>> GetWalletPnlAsync(
            string address,
            IEnumerable<string> networks,
            WalletPnlSort? sort = null,
            int? page = null,
            int? pageSize = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("networks", networks);
            parameters.Add("sort", sort);
            parameters.Add("page", page);
            parameters.Add("per_page", pageSize);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/wallets/{Uri.EscapeDataString(address)}/pnl", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoWalletPnl>(request, parameters, ct);
        }

        #endregion

        #region Get Pool Categories

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoOnchainCategoriesList>> GetPoolCategoriesAsync(
            int? page = null,
            PoolCategoriesSort? sort = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("page", page);
            parameters.Add("sort", sort);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/onchain/categories", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoOnchainCategoriesList>(request, parameters, ct);
        }

        #endregion

        #region Get Pools By Category

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoCategoriesPools>> GetPoolsByCategoryAsync(
            string categoryId,
            IEnumerable<TrendingPoolsInclude>? include = null,
            int? page = null,
            PoolsByCategorySort? sort = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("page", page);
            parameters.Add("sort", sort);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/categories/{Uri.EscapeDataString(categoryId)}/pools", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoCategoriesPools>(request, parameters, ct);
        }

        #endregion

        #region Get New Pools

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexPoolsResponse>> GetNewPoolsAsync(
            IEnumerable<TrendingPoolsInclude>? include = null,
            int? page = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("page", page);
            parameters.Add("include_gt_community_data", includeGtCommunityData);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/onchain/networks/new_pools", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexPoolsResponse>(request, parameters, ct);
        }

        #endregion

        #region Get New Pools By Network

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexPoolsResponse>> GetNewPoolsByNetworkAsync(
            string network,
            IEnumerable<PoolInclude>? include = null,
            int? page = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("page", page);
            parameters.Add("include_gt_community_data", includeGtCommunityData);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/new_pools", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexPoolsResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Pools

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexMultiPoolResponse>> GetPoolsAsync(
            string network,
            IEnumerable<string> addresses,
            IEnumerable<PoolInclude>? include = null,
            bool? includeVolumeBreakdown = null,
            bool? includeComposition = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("include", include);
            parameters.Add("include_volume_breakdown", includeVolumeBreakdown);
            parameters.Add("include_composition", includeComposition);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/pools/multi/{Uri.EscapeDataString(string.Join(",", addresses))}", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexMultiPoolResponse>(request, parameters, ct);
        }

        #endregion

        #region Get Onchain Token Prices

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoOnchainSimplePrice>> GetOnchainTokenPricesAsync(
            string network,
            IEnumerable<string> addresses,
            bool? includeMarketCap = null,
            bool? mcapFdvFallback = null,
            bool? include24hrVol = null,
            bool? include24hrPriceChange = null,
            bool? includeTotalReserveInUsd = null,
            bool? includeInactiveSource = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("include_market_cap", includeMarketCap);
            parameters.Add("mcap_fdv_fallback", mcapFdvFallback);
            parameters.Add("include_24hr_vol", include24hrVol);
            parameters.Add("include_24hr_price_change", include24hrPriceChange);
            parameters.Add("include_total_reserve_in_usd", includeTotalReserveInUsd);
            parameters.Add("include_inactive_source", includeInactiveSource);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/simple/networks/{Uri.EscapeDataString(network)}/token_price/{Uri.EscapeDataString(string.Join(",", addresses))}", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoOnchainSimplePrice>(request, parameters, ct);
        }

        #endregion

        #region Get Onchain Token Prices Across Networks

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoOnchainSimplePriceMulti>> GetOnchainTokenPricesAcrossNetworksAsync(
            IEnumerable<string> tokens,
            bool? includeMarketCap = null,
            bool? mcapFdvFallback = null,
            bool? include24hrVol = null,
            bool? include24hrPriceChange = null,
            bool? includeTotalReserveInUsd = null,
            bool? includeInactiveSource = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("tokens", tokens);
            parameters.Add("include_market_cap", includeMarketCap);
            parameters.Add("mcap_fdv_fallback", mcapFdvFallback);
            parameters.Add("include_24hr_vol", include24hrVol);
            parameters.Add("include_24hr_price_change", include24hrPriceChange);
            parameters.Add("include_total_reserve_in_usd", includeTotalReserveInUsd);
            parameters.Add("include_inactive_source", includeInactiveSource);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/onchain/simple/token_price/multi", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoOnchainSimplePriceMulti>(request, parameters, ct);
        }

        #endregion

        #region Get Dexes

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDexExchangesResponse>> GetDexesAsync(
            string network,
            int? page = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("page", page);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/onchain/networks/{Uri.EscapeDataString(network)}/dexes", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDexExchangesResponse>(request, parameters, ct);
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
