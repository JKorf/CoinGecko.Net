using System.Globalization;
using CryptoExchange.Net.Converters.SystemTextJson;
using CoinGecko.Net.Clients.MessageHandlers;
using CoinGecko.Net.Enums;
using CoinGecko.Net.Interfaces;
using CoinGecko.Net.Objects;
using CoinGecko.Net.Objects.Models;
using CoinGecko.Net.Objects.Options;
using CryptoExchange.Net;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Clients;
using CryptoExchange.Net.Converters.MessageParsing;
using CryptoExchange.Net.Converters.MessageParsing.DynamicConverters;
using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Objects.Errors;
using CryptoExchange.Net.SharedApis;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CoinGecko.Net.Clients
{
    /// <inheritdoc />
    internal class CoinGeckoRestClientApi : RestApiClient<CoinGeckoEnvironment, CoinGeckoAuthenticationProvider, CoinGeckoCredentials>, ICoinGeckoRestClientApi
    {
        private static readonly RequestDefinitionCache _definitions = new RequestDefinitionCache();
        private readonly CoinGeckoRestOptions _options;

        protected override IRestMessageHandler MessageHandler { get; } = new CoinGeckoRestMessageHandler(new ErrorMapping([]));

        internal CoinGeckoRestClientApi(CoinGeckoRestClient baseClient, ILoggerFactory? loggerFactory, HttpClient? httpClient, CoinGeckoRestOptions options) 
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

        #region Ping

        /// <inheritdoc />
        public async Task<HttpResult<string>> PingAsync(CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/ping", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            var result = await SendAsync<Dictionary<string, string>>(request, parameters, ct).ConfigureAwait(false);
            if (!result.Success)
                return HttpResult.Fail<string>(result);

            return HttpResult.Ok(result, result.Data["gecko_says"]);
        }

        #endregion

        #region Get Assets

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoAsset[]>> GetAssetsAsync(bool? includePlatform = null, ListingStatus? status = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("include_platform", includePlatform?.ToString().ToLowerInvariant());
            parameters.Add("status", status);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/coins/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoAsset[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Markets

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoMarket[]>> GetMarketsAsync(
            string quoteAsset,
            IEnumerable<string>? assetIds = null,
            IEnumerable<string>? symbols = null,
            string? category = null,
            MarketOrder? order = null,
            int? page = null,
            int? pageSize = null,
            bool? sparkline = null,
            IEnumerable<PriceChangePeriod>? priceChangePercentages = null,
            MarketsLocale? locale = null,
            string? precision = null,
            IEnumerable<string>? names = null,
            TokenSelection? includeTokens = null,
            bool? includeRehypothecated = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("vs_currency", quoteAsset);
            parameters.Add("ids", assetIds == null ? null : string.Join(",", assetIds));
            parameters.Add("symbols", symbols == null ? null : string.Join(",", symbols));
            parameters.Add("category", category);
            parameters.Add("order", order);
            parameters.Add("per_page", pageSize);
            parameters.Add("page", page);
            parameters.Add("sparkline", sparkline);
            parameters.AddCommaSeparated("price_change_percentage", priceChangePercentages);
            parameters.Add("locale", locale);
            parameters.Add("precision", precision);
            parameters.AddCommaSeparated("names", names);
            parameters.Add("include_tokens", includeTokens);
            parameters.Add("include_rehypothecated", includeRehypothecated);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/coins/markets", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarket[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoAssetDetails>> GetAssetDetailsAsync(
            string assetId,
            bool? localization = null,
            bool? tickers = null,
            bool? marketData = null,
            bool? communityData = null,
            bool? developerData = null,
            bool? sparkline = null,
            DexPairFormat? dexPairFormat = null,
            bool? includeCategoriesDetails = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("localization", localization);
            parameters.Add("tickers", tickers);
            parameters.Add("market_data", marketData);
            parameters.Add("community_data", communityData);
            parameters.Add("developer_data", developerData);
            parameters.Add("sparkline", sparkline);
            parameters.Add("dex_pair_format", dexPairFormat);
            parameters.Add("include_categories_details", includeCategoriesDetails);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/coins/" + assetId, CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoAssetDetails>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Tickers

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoTickers>> GetTickersAsync(
            string assetId,
            IEnumerable<string>? exchangeIds = null,
            bool? includeExchangeLogo = null,
            int? page = null,
            TickerOrder? order = null,
            bool? depth = null,
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("exchange_ids", exchangeIds == null ? null : string.Join(",", exchangeIds));
            parameters.Add("include_exchange_logo", includeExchangeLogo);
            parameters.Add("page", page);
            parameters.Add("order", order);
            parameters.Add("depth", depth);
            parameters.Add("dex_pair_format", dexPairFormat);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/coins/" + assetId + "/tickers", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoTickers>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset History

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoAssetHistory>> GetAssetHistoryAsync(
            string assetId,
            DateTime date,
            bool? localization = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("date", date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            parameters.Add("localization", localization);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/coins/" + assetId + "/history", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoAssetHistory>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartAsync(
            string assetId,
            string quoteAsset,
            int days,
            MarketChartInterval? interval = null,
            string? precision = null,
            CancellationToken ct = default)
            => GetMarketChartAsync(assetId, quoteAsset, days.ToString(CultureInfo.InvariantCulture), interval, precision, ct);

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartAsync(
            string assetId,
            string quoteAsset,
            string days,
            MarketChartInterval? interval = null,
            string? precision = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("vs_currency", quoteAsset);
            parameters.Add("days", days);
            parameters.Add("interval", interval);
            parameters.Add("precision", precision);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "api/v3/coins/" + assetId + "/market_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketChart>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartAsync(
            string assetId,
            string quoteAsset,
            DateTime from,
            DateTime to,
            string? precision = null,
            MarketChartInterval? interval = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("vs_currency", quoteAsset);
            parameters.Add("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.Add("to", DateTimeConverter.ConvertToSeconds(to));
            parameters.Add("precision", precision);
            parameters.Add("interval", interval);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "api/v3/coins/" + assetId + "/market_chart/range", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketChart>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get OHLC

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoOhlc[]>> GetOhlcAsync(
            string assetId,
            string quoteAsset,
            int days,
            string? precision = null,
            OhlcInterval? interval = null,
            CancellationToken ct = default)
            => GetOhlcAsync(assetId, quoteAsset, days.ToString(CultureInfo.InvariantCulture), precision, interval, ct);

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoOhlc[]>> GetOhlcAsync(
            string assetId,
            string quoteAsset,
            string days,
            string? precision = null,
            OhlcInterval? interval = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("vs_currency", quoteAsset);
            parameters.Add("days", days);
            parameters.Add("precision", precision);
            parameters.Add("interval", interval);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "api/v3/coins/" + assetId + "/ohlc", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoOhlc[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Prices

        /// <inheritdoc />
        public async Task<HttpResult<Dictionary<string, Dictionary<string, decimal?>>>> GetPricesAsync(
            IEnumerable<string>? ids,
            IEnumerable<string> quoteAssets,
            IEnumerable<string>? symbols = null,
            bool? includeMarketCap = false,
            bool? include24hrVolume = false,
            bool? include24hrChange = false,
            bool? includeLastUpdatedAt = false,
            string? precision = null,
            IEnumerable<string>? names = null,
            TokenSelection? includeTokens = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("ids", ids);
            parameters.AddCommaSeparated("symbols", symbols);
            parameters.Add("vs_currencies", string.Join(",", quoteAssets));
            parameters.Add("include_market_cap", includeMarketCap);
            parameters.Add("include_24hr_vol", include24hrVolume);
            parameters.Add("include_24hr_change", include24hrChange);
            parameters.Add("include_last_updated_at", includeLastUpdatedAt);
            parameters.Add("precision", precision);
            parameters.AddCommaSeparated("names", names);
            parameters.Add("include_tokens", includeTokens);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/simple/price", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<Dictionary<string, Dictionary<string, decimal?>>>(request, parameters, ct).ConfigureAwait(false);
        }
        #endregion

        #region Get Token Prices

        /// <inheritdoc />
        public async Task<HttpResult<Dictionary<string, Dictionary<string, decimal?>>>> GetTokenPricesAsync(
            string platformId,
            IEnumerable<string> contractAddresses,
            IEnumerable<string> quoteAssets,
            bool? includeMarketCap = false,
            bool? include24hrVolume = false,
            bool? include24hrChange = false,
            bool? includeLastUpdatedAt = false,
            string? precision = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("contract_addresses", string.Join(",", contractAddresses));
            parameters.Add("vs_currencies", string.Join(",", quoteAssets));
            parameters.Add("include_market_cap", includeMarketCap);
            parameters.Add("include_24hr_vol", include24hrVolume);
            parameters.Add("include_24hr_change", include24hrChange);
            parameters.Add("include_last_updated_at", includeLastUpdatedAt);
            parameters.Add("precision", precision);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/simple/token_price/" + platformId, CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<Dictionary<string, Dictionary<string, decimal?>>>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Quote Assets

        /// <inheritdoc />
        public async Task<HttpResult<string[]>> GetQuoteAssetsAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/simple/supported_vs_currencies", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<string[]>(request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset Info From Contract

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoAssetDetails>> GetAssetDetailsFromContractAsync(string assetId, string contractAddress, CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/coins/{assetId}/contract/{contractAddress}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoAssetDetails>(request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart From Contract

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(
            string assetId,
            string contractAddress,
            string quoteAsset,
            int days,
            MarketChartInterval? interval = null,
            string? precision = null,
            CancellationToken ct = default)
            => GetMarketChartFromContractAsync(assetId, contractAddress, quoteAsset, days.ToString(CultureInfo.InvariantCulture), interval, precision, ct);

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(
            string assetId,
            string contractAddress,
            string quoteAsset,
            string days,
            MarketChartInterval? interval = null,
            string? precision = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("vs_currency", quoteAsset);
            parameters.Add("days", days);
            parameters.Add("interval", interval);
            parameters.Add("precision", precision);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/coins/{assetId}/contract/{contractAddress}/market_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketChart>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart From Contract

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(
            string assetId,
            string contractAddress,
            string quoteAsset,
            DateTime from,
            DateTime to,
            MarketChartInterval? interval = null,
            string? precision = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("vs_currency", quoteAsset);
            parameters.Add("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.Add("to", DateTimeConverter.ConvertToSeconds(to));
            parameters.Add("interval", interval);
            parameters.Add("precision", precision);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/coins/{assetId}/contract/{contractAddress}/market_chart/range", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketChart>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset Platforms

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoAssetPlatform[]>> GetAssetPlatformsAsync(
            AssetPlatformsFilter? filter = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("filter", filter);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/asset_platforms", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoAssetPlatform[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset Categories

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoCategory[]>> GetAssetCategoriesAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/coins/categories/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoCategory[]>(request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Data Categories

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoMarketDataCategory[]>> GetMarketDataCategoriesAsync(MarketDataCategoriesOrder? order = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("order", order);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/coins/categories", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketDataCategory[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Real World Assets

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoRwa[]>> GetRwasAsync(RwaAssetType? assetType = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("asset_type", assetType);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/rwas/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return await SendAsync<CoinGeckoRwa[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Real World Asset Issuers

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoListItem[]>> GetRwaIssuersAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/rwas/issuers/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return await SendAsync<CoinGeckoListItem[]>(request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchanges

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoExchange[]>> GetExchangesAsync(int? page = null, int? pageSize = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("per_page", pageSize);
            parameters.Add("page", page);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/exchanges", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoExchange[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchanges Markets

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoListItem[]>> GetExchangeListAsync(ListingStatus? status = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("status", status);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/exchanges/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoListItem[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Details

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoExchangeDetails>> GetExchangeDetailsAsync(
            string exchangeId,
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("dex_pair_format", dexPairFormat);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/exchanges/{exchangeId}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoExchangeDetails>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Tickers
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoTickers>> GetExchangeTickersAsync(
            string exchangeId,
            IEnumerable<string>? assetIds = null,
            bool? includeExchangeLogo = null,
            int? page = null,
            bool? depth = null,
            ExchangeTickersOrder? order = null,
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("coin_ids", assetIds);
            parameters.Add("include_exchange_logo", includeExchangeLogo);
            parameters.Add("page", page);
            parameters.Add("depth", depth);
            parameters.Add("order", order);
            parameters.Add("dex_pair_format", dexPairFormat);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/exchanges/{exchangeId}/tickers", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoTickers>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange volumes
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoMarketChartValue[]>> GetExchangeVolumeHistoryAsync(string exchangeId, int days, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("days", days);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/exchanges/{exchangeId}/volume_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketChartValue[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Derivatives
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoDerivative[]>> GetDerivativesAsync(int? page = null, int? pageSize = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("page", page);
            parameters.Add("per_page", pageSize);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/derivatives", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoDerivative[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Derivative Underlying Assets

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoDerivativeUnderlyingAsset[]>> GetDerivativeUnderlyingAssetsAsync(
            DerivativeUnderlyingType? underlyingType = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("underlying_type", underlyingType);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/derivatives/underlyings/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return await SendAsync<CoinGeckoDerivativeUnderlyingAsset[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Derivatives Details
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoExchangeDerivative>> GetExchangeDerivativesDetailsAsync(string exchangeId, ExchangeDerivativesDetailsIncludeTickers? includeTickers = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("include_tickers", includeTickers);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/derivatives/exchanges/{exchangeId}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoExchangeDerivative>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Derivatives
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoExchangeDerivative[]>> GetExchangeDerivativesAsync(int? page = null, int? pageSize = null, ExchangeDerivativesOrder? order = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("page", page);
            parameters.Add("per_page", pageSize);
            parameters.Add("order", order);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/derivatives/exchanges", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoExchangeDerivative[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Derivatives Exchanges list
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoListItem[]>> GetDerivativesExchangesListAsync(CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/derivatives/exchanges/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoListItem[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Rates
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoExchangeRates>> GetBtcExchangeRatesAsync(CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/exchange_rates", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoExchangeRates>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Global Data
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoGlobalData>> GetGlobalDataAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/global", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            var data = await SendAsync<CoinGeckoGlobalDataWrapper>(request, null, ct).ConfigureAwait(false);
            if (!data.Success)
                return HttpResult.Fail<CoinGeckoGlobalData>(data);

            return HttpResult.Ok(data, data.Data.Data!);
        }

        #endregion

        #region Get Global Defi Data
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoGlobalDefiData>> GetGlobalDefiDataAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/global/decentralized_finance_defi", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            var data = await SendAsync<CoinGeckoGlobalDefiDataWrapper>(request, null, ct).ConfigureAwait(false);
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            if (!data.Success)
                return HttpResult.Fail<CoinGeckoGlobalDefiData>(data);

            return HttpResult.Ok(data, data.Data.Data!);
        }

        #endregion

        #region Get Nfts
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoNft[]>> GetNftsAsync(NftsOrder? order = null, int? page = null, int? pageSize = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("order", order);
            parameters.Add("page", page);
            parameters.Add("per_page", pageSize);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/nfts/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoNft[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Nft
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoNftDetails>> GetNftAsync(string id, CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/nfts/{id}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoNftDetails>(request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Nft by contract address
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoNftDetails>> GetNftByContractAddressAsync(string platformId, string contractAddress, CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/nfts/{platformId}/contract/{contractAddress}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoNftDetails>(request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Search
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoSearchResult>> SearchAsync(string query, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("query", query);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/search", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoSearchResult>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Trending
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoTrendingSearch>> GetTrendingSearchesAsync(IEnumerable<TrendingSearchesShowMax>? showMax = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("show_max", showMax);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/search/trending", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoTrendingSearch>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Treasury Entities

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoTreasuryEntity[]>> GetTreasuryEntitiesAsync(
            TreasuryEntityType? entityType = null,
            int? page = null,
            int? pageSize = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("entity_type", entityType);
            parameters.Add("per_page", pageSize);
            parameters.Add("page", page);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/entities/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return await SendAsync<CoinGeckoTreasuryEntity[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Company Holdings

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoCompanyHolding>> GetCompanyHoldingsAsync(string asset, CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/companies/public_treasury/{asset}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            var result = await SendAsync<CoinGeckoCompanyHolding>(request, null, ct).ConfigureAwait(false);
            return result;
        }

        #endregion

        #region Get Api Usage
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoApiUsage>> GetApiUsageAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/key", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return await SendAsync<CoinGeckoApiUsage>(request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Top Gainers And Losers

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoTopGainersLosers>> GetTopGainersAndLosersAsync(
            string quoteAsset,
            TopGainersAndLosersDuration? duration = null,
            IEnumerable<TopGainersAndLosersPriceChangePercentage>? priceChangePercentage = null,
            string? topCoins = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("vs_currency", quoteAsset);
            parameters.Add("duration", duration);
            parameters.AddCommaSeparated("price_change_percentage", priceChangePercentage);
            parameters.Add("top_coins", topCoins);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/coins/top_gainers_losers", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoTopGainersLosers>(request, parameters, ct);
        }

        #endregion

        #region Get Ohlc Range

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoOhlc[]>> GetOhlcRangeAsync(
            string id,
            string quoteAsset,
            DateTime from,
            DateTime to,
            OhlcInterval interval,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("vs_currency", quoteAsset);
            parameters.Add("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.Add("to", DateTimeConverter.ConvertToSeconds(to));
            parameters.Add("interval", interval);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/coins/{Uri.EscapeDataString(id)}/ohlc/range", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoOhlc[]>(request, parameters, ct);
        }

        #endregion

        #region Get Circulating Supply Chart

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoCirculatingSupplyChart>> GetCirculatingSupplyChartAsync(
            string id,
            string days,
            SupplyChartInterval? interval = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("days", days);
            parameters.Add("interval", interval);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/coins/{Uri.EscapeDataString(id)}/circulating_supply_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoCirculatingSupplyChart>(request, parameters, ct);
        }

        #endregion

        #region Get Circulating Supply Chart Range

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoCirculatingSupplyChart>> GetCirculatingSupplyChartRangeAsync(
            string id,
            DateTime from,
            DateTime to,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.Add("to", DateTimeConverter.ConvertToSeconds(to));

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/coins/{Uri.EscapeDataString(id)}/circulating_supply_chart/range", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoCirculatingSupplyChart>(request, parameters, ct);
        }

        #endregion

        #region Get Total Supply Chart

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoTotalSupplyChart>> GetTotalSupplyChartAsync(
            string id,
            string days,
            TotalSupplyChartInterval? interval = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("days", days);
            parameters.Add("interval", interval);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/coins/{Uri.EscapeDataString(id)}/total_supply_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoTotalSupplyChart>(request, parameters, ct);
        }

        #endregion

        #region Get Total Supply Chart Range

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoTotalSupplyChart>> GetTotalSupplyChartRangeAsync(
            string id,
            DateTime from,
            DateTime to,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.Add("to", DateTimeConverter.ConvertToSeconds(to));

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/coins/{Uri.EscapeDataString(id)}/total_supply_chart/range", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoTotalSupplyChart>(request, parameters, ct);
        }

        #endregion

        #region Get Supply Breakdown

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoCoinSupplyBreakdown>> GetSupplyBreakdownAsync(
            string id,
            CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/coins/{Uri.EscapeDataString(id)}/supply_breakdown", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoCoinSupplyBreakdown>(request, null, ct);
        }

        #endregion

        #region Get Recently Added Assets

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoRecentAsset[]>> GetRecentlyAddedAssetsAsync(
            CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/coins/list/new", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoRecentAsset[]>(request, null, ct);
        }

        #endregion

        #region Get Token List

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoTokenList>> GetTokenListAsync(
            string assetPlatformId,
            CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/token_lists/{Uri.EscapeDataString(assetPlatformId)}/all.json", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoTokenList>(request, null, ct);
        }

        #endregion

        #region Get Rwa Markets

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoRwaMarket[]>> GetRwaMarketsAsync(
            RwaAssetType? assetType = null,
            IEnumerable<string>? ids = null,
            IEnumerable<string>? names = null,
            IEnumerable<string>? symbols = null,
            string? issuer = null,
            bool? includeNonTokenized = null,
            MarketOrder? order = null,
            int? pageSize = null,
            int? page = null,
            bool? sparkline = null,
            IEnumerable<PriceChangePeriod>? priceChangePercentage = null,
            string? precision = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("asset_type", assetType);
            parameters.AddCommaSeparated("ids", ids);
            parameters.AddCommaSeparated("names", names);
            parameters.AddCommaSeparated("symbols", symbols);
            parameters.Add("issuer", issuer);
            parameters.Add("include_non_tokenized", includeNonTokenized);
            parameters.Add("order", order);
            parameters.Add("per_page", pageSize);
            parameters.Add("page", page);
            parameters.Add("sparkline", sparkline);
            parameters.AddCommaSeparated("price_change_percentage", priceChangePercentage);
            parameters.Add("precision", precision);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/rwas/markets", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoRwaMarket[]>(request, parameters, ct);
        }

        #endregion

        #region Get Rwa Details

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoRwaDetails>> GetRwaDetailsAsync(
            string id,
            bool? sparkline = null,
            bool? tokens = null,
            bool? tokenizedMarketData = null,
            bool? perpsMarketData = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("sparkline", sparkline);
            parameters.Add("tokens", tokens);
            parameters.Add("tokenized_market_data", tokenizedMarketData);
            parameters.Add("perps_market_data", perpsMarketData);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/rwas/{Uri.EscapeDataString(id)}", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoRwaDetails>(request, parameters, ct);
        }

        #endregion

        #region Get Rwa Tickers

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoRwaTickers>> GetRwaTickersAsync(
            string id,
            IEnumerable<string>? issuerIds = null,
            IEnumerable<string>? exchangeIds = null,
            int? page = null,
            TickerOrder? order = null,
            bool? depth = null,
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("issuer_ids", issuerIds);
            parameters.AddCommaSeparated("exchange_ids", exchangeIds);
            parameters.Add("page", page);
            parameters.Add("order", order);
            parameters.Add("depth", depth);
            parameters.Add("dex_pair_format", dexPairFormat);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/rwas/{Uri.EscapeDataString(id)}/tickers", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoRwaTickers>(request, parameters, ct);
        }

        #endregion

        #region Get Rwa Market Chart

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoRwaMarketChart>> GetRwaMarketChartAsync(
            string id,
            string? days = null,
            SupplyChartInterval? interval = null,
            string? precision = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("days", days);
            parameters.Add("interval", interval);
            parameters.Add("precision", precision);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/rwas/{Uri.EscapeDataString(id)}/market_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoRwaMarketChart>(request, parameters, ct);
        }

        #endregion

        #region Get Rwa Issuer Details

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoRwaIssuerDetails>> GetRwaIssuerDetailsAsync(
            string id,
            CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/rwas/issuers/{Uri.EscapeDataString(id)}", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoRwaIssuerDetails>(request, null, ct);
        }

        #endregion

        #region Get Exchange Volume History Range

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoMarketChartValue[]>> GetExchangeVolumeHistoryRangeAsync(
            string id,
            DateTime from,
            DateTime to,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.Add("to", DateTimeConverter.ConvertToSeconds(to));

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/exchanges/{Uri.EscapeDataString(id)}/volume_chart/range", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoMarketChartValue[]>(request, parameters, ct);
        }

        #endregion

        #region Get Derivative Underlying Markets

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoDerivativeUnderlyingMarket[]>> GetDerivativeUnderlyingMarketsAsync(
            IEnumerable<string>? coinIds = null,
            IEnumerable<string>? rwaIds = null,
            DerivativeUnderlyingType? underlyingType = null,
            int? page = null,
            int? pageSize = null,
            DerivativeUnderlyingMarketsOrder? order = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("coin_ids", coinIds);
            parameters.AddCommaSeparated("rwa_ids", rwaIds);
            parameters.Add("underlying_type", underlyingType);
            parameters.Add("page", page);
            parameters.Add("per_page", pageSize);
            parameters.Add("order", order);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/derivatives/underlyings", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoDerivativeUnderlyingMarket[]>(request, parameters, ct);
        }

        #endregion

        #region Get Treasury Holdings

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoPublicTreasury>> GetTreasuryHoldingsAsync(
            TreasuryHoldingEntityType entity,
            string coinId,
            int? pageSize = null,
            int? page = null,
            TreasuryHoldingsOrder? order = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("per_page", pageSize);
            parameters.Add("page", page);
            parameters.Add("order", order);

            var baseAddress = GetBaseAddress();
            var path = $"/api/v3/{EnumConverter.GetString(entity)}/public_treasury/{Uri.EscapeDataString(coinId)}";
            // The company route is also available through GetCompanyHoldingsAsync with a different response type.
            var request = _definitions.GetOrCreate(HttpMethod.Get, baseAddress, path, CoinGeckoApi.RateLimiter.CoinGecko, 1, true,
                preventCaching: true, identifier: $"{nameof(GetTreasuryHoldingsAsync)}:{baseAddress}{path}");
            return SendAsync<CoinGeckoPublicTreasury>(request, parameters, ct);
        }

        #endregion

        #region Get Treasury Entity Holdings

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoPublicTreasuryEntity>> GetTreasuryEntityHoldingsAsync(
            string entityId,
            IEnumerable<TreasuryHoldingChangePeriod>? holdingAmountChange = null,
            IEnumerable<TreasuryHoldingChangePeriod>? holdingChangePercentage = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.AddCommaSeparated("holding_amount_change", holdingAmountChange);
            parameters.AddCommaSeparated("holding_change_percentage", holdingChangePercentage);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/public_treasury/{Uri.EscapeDataString(entityId)}", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoPublicTreasuryEntity>(request, parameters, ct);
        }

        #endregion

        #region Get Treasury Holdings Chart

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoPublicTreasuryEntityChart>> GetTreasuryHoldingsChartAsync(
            string entityId,
            string coinId,
            string days,
            bool? includeEmptyIntervals = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("days", days);
            parameters.Add("include_empty_intervals", includeEmptyIntervals);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/public_treasury/{Uri.EscapeDataString(entityId)}/{Uri.EscapeDataString(coinId)}/holding_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoPublicTreasuryEntityChart>(request, parameters, ct);
        }

        #endregion

        #region Get Treasury Transactions

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoPublicTreasuryTransactionHistory>> GetTreasuryTransactionsAsync(
            string entityId,
            int? pageSize = null,
            int? page = null,
            TreasuryTransactionsOrder? order = null,
            IEnumerable<string>? coinIds = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("per_page", pageSize);
            parameters.Add("page", page);
            parameters.Add("order", order);
            parameters.AddCommaSeparated("coin_ids", coinIds);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/public_treasury/{Uri.EscapeDataString(entityId)}/transaction_history", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoPublicTreasuryTransactionHistory>(request, parameters, ct);
        }

        #endregion

        #region Get Nft Markets

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoNftMarket[]>> GetNftMarketsAsync(
            string? assetPlatformId = null,
            NftMarketsOrder? order = null,
            int? pageSize = null,
            int? page = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("asset_platform_id", assetPlatformId);
            parameters.Add("order", order);
            parameters.Add("per_page", pageSize);
            parameters.Add("page", page);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/nfts/markets", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoNftMarket[]>(request, parameters, ct);
        }

        #endregion

        #region Get Nft Market Chart

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoNftMarketChart>> GetNftMarketChartAsync(
            string id,
            string days,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("days", days);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/nfts/{Uri.EscapeDataString(id)}/market_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoNftMarketChart>(request, parameters, ct);
        }

        #endregion

        #region Get Nft Market Chart By Contract Address

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoNftMarketChart>> GetNftMarketChartByContractAddressAsync(
            string assetPlatformId,
            string contractAddress,
            string days,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("days", days);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/nfts/{Uri.EscapeDataString(assetPlatformId)}/contract/{Uri.EscapeDataString(contractAddress)}/market_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoNftMarketChart>(request, parameters, ct);
        }

        #endregion

        #region Get Nft Tickers

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoNftTicker>> GetNftTickersAsync(
            string id,
            CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"/api/v3/nfts/{Uri.EscapeDataString(id)}/tickers", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoNftTicker>(request, null, ct);
        }

        #endregion

        #region Get News

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoNewsResponse[]>> GetNewsAsync(
            int? page = null,
            int? pageSize = null,
            string? coinId = null,
            NewsLanguage? language = null,
            NewsType? type = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("page", page);
            parameters.Add("per_page", pageSize);
            parameters.Add("coin_id", coinId);
            parameters.Add("language", language);
            parameters.Add("type", type);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/news", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoNewsResponse[]>(request, parameters, ct);
        }

        #endregion

        #region Get Insights

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoInsightsResponse[]>> GetInsightsAsync(
            int? page = null,
            int? pageSize = null,
            string? coinId = null,
            DateTime? from = null,
            DateTime? to = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("page", page);
            parameters.Add("per_page", pageSize);
            parameters.Add("coin_id", coinId);
            parameters.Add("from", from?.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            parameters.Add("to", to?.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/insights", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoInsightsResponse[]>(request, parameters, ct);
        }

        #endregion

        #region Get Global Market Cap Chart

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoGlobalMarketCapChart>> GetGlobalMarketCapChartAsync(
            string days,
            string? quoteAsset = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("days", days);
            parameters.Add("vs_currency", quoteAsset);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/global/market_cap_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoGlobalMarketCapChart>(request, parameters, ct);
        }

        #endregion

        #region Get Global Fear And Greed Chart

        /// <inheritdoc />
        public Task<HttpResult<CoinGeckoGlobalFearAndGreedChart>> GetGlobalFearAndGreedChartAsync(
            string days,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("days", days);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/global/fear_and_greed_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return SendAsync<CoinGeckoGlobalFearAndGreedChart>(request, parameters, ct);
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
