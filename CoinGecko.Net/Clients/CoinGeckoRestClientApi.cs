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
        public async Task<HttpResult<CoinGeckoAsset[]>> GetAssetsAsync(bool? includePlatform = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("include_platform", includePlatform?.ToString().ToLowerInvariant());
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
            string? order = null,
            int? page = null,
            int? pageSize = null,
            bool? sparkline = null,
            IEnumerable<string>? priceChangePercentages = null,
            string? locale = null,
            string? precision = null,
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
            parameters.Add("price_change_percentage", priceChangePercentages == null ? null : string.Join(", ", priceChangePercentages));
            parameters.Add("locale", locale);
            parameters.Add("precision", precision);

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
            string? order = null,
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
            parameters.Add("date", date.ToString("dd-MM-yyyy"));
            parameters.Add("localization", localization);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "/api/v3/coins/" + assetId + "/history", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoAssetHistory>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartAsync(
            string assetId,
            string quoteAsset,
            int days,
            string? interval = null,
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
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("vs_currency", quoteAsset);
            parameters.Add("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.Add("to", DateTimeConverter.ConvertToSeconds(to));
            parameters.Add("precision", precision);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "api/v3/coins/" + assetId + "/market_chart/range", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketChart>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get OHLC

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoOhlc[]>> GetOhlcAsync(
            string assetId,
            string quoteAsset,
            int days,
            string? precision = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("vs_currency", quoteAsset);
            parameters.Add("days", days);
            parameters.Add("precision", precision);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), "api/v3/coins/" + assetId + "/ohlc", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoOhlc[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Prices

        /// <inheritdoc />
        public async Task<HttpResult<Dictionary<string, Dictionary<string, decimal?>>>> GetPricesAsync(
            IEnumerable<string> ids,
            IEnumerable<string> quoteAssets,
            IEnumerable<string>? symbols = null,
            bool? includeMarketCap = false,
            bool? include24hrVolume = false,
            bool? include24hrChange = false,
            bool? includeLastUpdatedAt = false,
            string? precision = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("ids", ids?.Any() == true ? string.Join(",", ids) : null);
            parameters.Add("symbols", symbols?.Any() == true ? string.Join(",", symbols) : null);
            parameters.Add("vs_currencies", string.Join(",", quoteAssets));
            parameters.Add("include_market_cap", includeMarketCap);
            parameters.Add("include_24hr_vol", include24hrVolume);
            parameters.Add("include_24hr_change", include24hrChange);
            parameters.Add("include_last_updated_at", includeLastUpdatedAt);
            parameters.Add("precision", precision);
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
        public async Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(
            string assetId,
            string contractAddress,
            string quoteAsset,
            int days,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("vs_currency", quoteAsset);
            parameters.Add("days", days);

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
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("vs_currency", quoteAsset);
            parameters.Add("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.Add("to", DateTimeConverter.ConvertToSeconds(to));

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/coins/{assetId}/contract/{contractAddress}/market_chart/range", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketChart>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset Platforms

        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoAssetPlatform[]>> GetAssetPlatformsAsync(
            string? filter = null,
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
        public async Task<HttpResult<CoinGeckoMarketDataCategory[]>> GetMarketDataCategoriesAsync(string? order = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("order", order);

            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/coins/categories", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketDataCategory[]>(request, parameters, ct).ConfigureAwait(false);
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
        public async Task<HttpResult<CoinGeckoListItem[]>> GetExchangeListAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/exchanges/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoListItem[]>(request, null, ct).ConfigureAwait(false);
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
            IEnumerable<string>? coinIds = null,
            bool? includeExchangeLogo = null,
            int? page = null,
            bool? depth = null,
            string? order = null,
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("coin_ids", coinIds == null ? null : string.Join(",", coinIds));
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
        public async Task<HttpResult<CoinGeckoDerivative[]>> GetDerivativesAsync(CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/derivatives", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoDerivative[]>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Derivatives Details
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoExchangeDerivative>> GetExchangeDerivativesDetailsAsync(string exchangeId, string? includeTickers = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("include_tickers", includeTickers);
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/derivatives/exchanges/{exchangeId}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoExchangeDerivative>(request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Derivatives
        /// <inheritdoc />
        public async Task<HttpResult<CoinGeckoExchangeDerivative[]>> GetExchangeDerivativesAsync(int? page = null, int? pageSize = null, string? order = null, CancellationToken ct = default)
        {
            var parameters = new Parameters(CoinGeckoApi._parameterSerializationSettings);
            parameters.Add("page", page);
            parameters.Add("pageSize", pageSize);
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
        public async Task<HttpResult<CoinGeckoNft[]>> GetNftsAsync(string? order = null, int? page = null, int? pageSize = null, CancellationToken ct = default)
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
        public async Task<HttpResult<CoinGeckoTrendingSearch>> GetTrendingSearchesAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, GetBaseAddress(), $"api/v3/search/trending", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoTrendingSearch>(request, null, ct).ConfigureAwait(false);
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
