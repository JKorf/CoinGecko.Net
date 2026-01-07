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
    internal class CoinGeckoRestClientApi : RestApiClient, ICoinGeckoRestClientApi
    {
        private static readonly RequestDefinitionCache _definitions = new RequestDefinitionCache();
        private readonly CoinGeckoRestOptions _options;

        protected override IRestMessageHandler MessageHandler { get; } = new CoinGeckoRestMessageHandler(new ErrorMapping([]));

        internal CoinGeckoRestClientApi(CoinGeckoRestClient baseClient, ILogger logger, HttpClient? httpClient, CoinGeckoRestOptions options) 
            : base(logger, httpClient, options.Environment.RestApiAddressPublic, options, options.ApiOptions)
        {
            _options = options;
            StandardRequestHeaders = new Dictionary<string, string>
            {
                { "User-Agent", "CryptoExchange.Net/" + baseClient.CryptoExchangeLibVersion.ToString() }
            };
        }

        /// <inheritdoc />
        protected override IStreamMessageAccessor CreateAccessor() => new SystemTextJsonStreamMessageAccessor(SerializerOptions.WithConverters(CoinGeckoApi.SerializationContext));
        /// <inheritdoc />
        protected override IMessageSerializer CreateSerializer() => new SystemTextJsonMessageSerializer(SerializerOptions.WithConverters(CoinGeckoApi.SerializationContext));

        /// <inheritdoc />
        public override string FormatSymbol(string baseAsset, string quoteAsset, TradingMode tradingMode, DateTime? deliverTime = null) => throw new NotImplementedException();

        #region Ping

        /// <inheritdoc />
        public async Task<WebCallResult<string>> PingAsync(CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/ping", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            var result = await SendAsync<Dictionary<string, string>>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);

            if (!result)
                return result.As<string>(default);

            return result.As(result.Data["gecko_says"]);
        }

        #endregion

        #region Get Assets

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoAsset[]>> GetAssetsAsync(bool? includePlatform = null, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptionalParameter("include_platform", includePlatform?.ToString().ToLowerInvariant());
            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/coins/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoAsset[]>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Markets

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoMarket[]>> GetMarketsAsync(
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
            var parameters = new ParameterCollection();
            parameters.AddParameter("vs_currency", quoteAsset);
            parameters.AddOptionalParameter("ids", assetIds == null ? null : string.Join(",", assetIds));
            parameters.AddOptionalParameter("symbols", symbols == null ? null : string.Join(",", symbols));
            parameters.AddOptionalParameter("category", category);
            parameters.AddOptionalParameter("order", order);
            parameters.AddOptionalParameter("per_page", pageSize);
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("sparkline", sparkline);
            parameters.AddOptionalParameter("price_change_percentage", priceChangePercentages == null ? null : string.Join(", ", priceChangePercentages));
            parameters.AddOptionalParameter("locale", locale);
            parameters.AddOptionalParameter("precision", precision);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/coins/markets", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarket[]>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoAssetDetails>> GetAssetDetailsAsync(
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
            var parameters = new ParameterCollection();
            parameters.AddOptionalParameter("localization", localization);
            parameters.AddOptionalParameter("tickers", tickers);
            parameters.AddOptionalParameter("market_data", marketData);
            parameters.AddOptionalParameter("community_data", communityData);
            parameters.AddOptionalParameter("developer_data", developerData);
            parameters.AddOptionalParameter("sparkline", sparkline);
            parameters.AddOptionalEnum("dex_pair_format", dexPairFormat);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/coins/" + assetId, CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoAssetDetails>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Tickers

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoTickers>> GetTickersAsync(
            string assetId,
            IEnumerable<string>? exchangeIds = null,
            bool? includeExchangeLogo = null,
            int? page = null,
            string? order = null,
            bool? depth = null,
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptionalParameter("exchange_ids", exchangeIds == null ? null : string.Join(",", exchangeIds));
            parameters.AddOptionalParameter("include_exchange_logo", includeExchangeLogo);
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("order", order);
            parameters.AddOptionalParameter("depth", depth);
            parameters.AddOptionalEnum("dex_pair_format", dexPairFormat);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/coins/" + assetId + "/tickers", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoTickers>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset History

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoAssetHistory>> GetAssetHistoryAsync(
            string assetId,
            DateTime date,
            bool? localization = null,
            CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddParameter("date", date.ToString("dd-MM-yyyy"));
            parameters.AddOptionalParameter("localization", localization);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/coins/" + assetId + "/history", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoAssetHistory>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartAsync(
            string assetId,
            string quoteAsset,
            int days,
            string? interval = null,
            string? precision = null,
            CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddParameter("vs_currency", quoteAsset);
            parameters.AddParameter("days", days);
            parameters.AddOptionalParameter("interval", interval);
            parameters.AddOptionalParameter("precision", precision);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "api/v3/coins/" + assetId + "/market_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketChart>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartAsync(
            string assetId,
            string quoteAsset,
            DateTime from,
            DateTime to,
            string? precision = null,
            CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddParameter("vs_currency", quoteAsset);
            parameters.AddParameter("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.AddParameter("to", DateTimeConverter.ConvertToSeconds(to));
            parameters.AddOptionalParameter("precision", precision);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "api/v3/coins/" + assetId + "/market_chart/range", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketChart>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get OHLC

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoOhlc[]>> GetOhlcAsync(
            string assetId,
            string quoteAsset,
            int days,
            string? precision = null,
            CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddParameter("vs_currency", quoteAsset);
            parameters.AddParameter("days", days);
            parameters.AddOptionalParameter("precision", precision);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "api/v3/coins/" + assetId + "/ohlc", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoOhlc[]>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Prices

        /// <inheritdoc />
        public async Task<WebCallResult<Dictionary<string, Dictionary<string, decimal?>>>> GetPricesAsync(
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
            var parameters = new ParameterCollection();
            parameters.AddOptionalParameter("ids", ids?.Any() == true ? string.Join(",", ids) : null);
            parameters.AddOptionalParameter("symbols", symbols?.Any() == true ? string.Join(",", symbols) : null);
            parameters.AddParameter("vs_currencies", string.Join(",", quoteAssets));
            parameters.AddOptionalParameter("include_market_cap", includeMarketCap);
            parameters.AddOptionalParameter("include_24hr_vol", include24hrVolume);
            parameters.AddOptionalParameter("include_24hr_change", include24hrChange);
            parameters.AddOptionalParameter("include_last_updated_at", includeLastUpdatedAt);
            parameters.AddOptionalParameter("precision", precision);
            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/simple/price", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<Dictionary<string, Dictionary<string, decimal?>>>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }
        #endregion

        #region Get Token Prices

        /// <inheritdoc />
        public async Task<WebCallResult<Dictionary<string, Dictionary<string, decimal?>>>> GetTokenPricesAsync(
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
            var parameters = new ParameterCollection();
            parameters.AddParameter("contract_addresses", string.Join(",", contractAddresses));
            parameters.AddParameter("vs_currencies", string.Join(",", quoteAssets));
            parameters.AddOptionalParameter("include_market_cap", includeMarketCap);
            parameters.AddOptionalParameter("include_24hr_vol", include24hrVolume);
            parameters.AddOptionalParameter("include_24hr_change", include24hrChange);
            parameters.AddOptionalParameter("include_last_updated_at", includeLastUpdatedAt);
            parameters.AddOptionalParameter("precision", precision);
            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/simple/token_price/" + platformId, CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<Dictionary<string, Dictionary<string, decimal?>>>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Quote Assets

        /// <inheritdoc />
        public async Task<WebCallResult<string[]>> GetQuoteAssetsAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/simple/supported_vs_currencies", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<string[]>(GetBaseAddress(), request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset Info From Contract

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoAssetDetails>> GetAssetDetailsFromContractAsync(string assetId, string contractAddress, CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/coins/{assetId}/contract/{contractAddress}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoAssetDetails>(GetBaseAddress(), request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart From Contract

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(
            string assetId,
            string contractAddress,
            string quoteAsset,
            int days,
            CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddParameter("vs_currency", quoteAsset);
            parameters.AddParameter("days", days);

            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/coins/{assetId}/contract/{contractAddress}/market_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketChart>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart From Contract

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(
            string assetId,
            string contractAddress,
            string quoteAsset,
            DateTime from,
            DateTime to,
            CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddParameter("vs_currency", quoteAsset);
            parameters.AddParameter("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.AddParameter("to", DateTimeConverter.ConvertToSeconds(to));

            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/coins/{assetId}/contract/{contractAddress}/market_chart/range", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketChart>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset Platforms

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoAssetPlatform[]>> GetAssetPlatformsAsync(
            string? filter = null,
            CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptionalParameter("filter", filter);

            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/asset_platforms", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoAssetPlatform[]>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset Categories

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoCategory[]>> GetAssetCategoriesAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/coins/categories/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoCategory[]>(GetBaseAddress(), request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Data Categories

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoMarketDataCategory[]>> GetMarketDataCategoriesAsync(string? order = null, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptionalParameter("order", order);

            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/coins/categories", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketDataCategory[]>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchanges

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoExchange[]>> GetExchangesAsync(int? page = null, int? pageSize = null, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptionalParameter("per_page", pageSize);
            parameters.AddOptionalParameter("page", page);
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/exchanges", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoExchange[]>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchanges Markets

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoListItem[]>> GetExchangeListAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/exchanges/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoListItem[]>(GetBaseAddress(), request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Details

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoExchangeDetails>> GetExchangeDetailsAsync(
            string exchangeId,
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptionalEnum("dex_pair_format", dexPairFormat);
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/exchanges/{exchangeId}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoExchangeDetails> (GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Tickers
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoTickers>> GetExchangeTickersAsync(
            string exchangeId,
            IEnumerable<string>? coinIds = null,
            bool? includeExchangeLogo = null,
            int? page = null,
            bool? depth = null,
            string? order = null,
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptionalParameter("coin_ids", coinIds == null ? null : string.Join(",", coinIds));
            parameters.AddOptionalParameter("include_exchange_logo", includeExchangeLogo);
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("depth", depth);
            parameters.AddOptionalParameter("order", order);
            parameters.AddOptionalEnum("dex_pair_format", dexPairFormat);

            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/exchanges/{exchangeId}/tickers", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoTickers>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange volumes
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoMarketChartValue[]>> GetExchangeVolumeHistoryAsync(string exchangeId, int days, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddParameter("days", days);
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/exchanges/{exchangeId}/volume_chart", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoMarketChartValue[]>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Derivatives
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoDerivative[]>> GetDerivativesAsync(CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/derivatives", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoDerivative[]>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Derivatives Details
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoExchangeDerivative>> GetExchangeDerivativesDetailsAsync(string exchangeId, string? includeTickers = null, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptionalParameter("include_tickers", includeTickers);
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/derivatives/exchanges/{exchangeId}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoExchangeDerivative>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Derivatives
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoExchangeDerivative[]>> GetExchangeDerivativesAsync(int? page = null, int? pageSize = null, string? order = null, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("pageSize", pageSize);
            parameters.AddOptionalParameter("order", order);
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/derivatives/exchanges", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoExchangeDerivative[]>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Derivatives Exchanges list
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoListItem[]>> GetDerivativesExchangesListAsync(CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/derivatives/exchanges/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoListItem[]>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Rates
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoExchangeRates>> GetBtcExchangeRatesAsync(CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/exchange_rates", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoExchangeRates>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Global Data
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoGlobalData>> GetGlobalDataAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/global", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            var data = await SendAsync<CoinGeckoGlobalDataWrapper>(GetBaseAddress(), request, null, ct).ConfigureAwait(false);
            if (!data)
                return data.As<CoinGeckoGlobalData>(null);

            return data.As(data.Data.Data!);
        }

        #endregion

        #region Get Global Defi Data
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoGlobalDefiData>> GetGlobalDefiDataAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/global/decentralized_finance_defi", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            var data = await SendAsync<CoinGeckoGlobalDefiDataWrapper>(GetBaseAddress(), request, null, ct).ConfigureAwait(false);
            var parameters = new ParameterCollection();
            if (!data)
                return data.As<CoinGeckoGlobalDefiData>(null);

            return data.As(data.Data.Data!);
        }

        #endregion

        #region Get Nfts
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoNft[]>> GetNftsAsync(string? order = null, int? page = null, int? pageSize = null, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptionalParameter("order", order);
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("per_page", pageSize);

            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/nfts/list", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoNft[]>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Nft
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoNftDetails>> GetNftAsync(string id, CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/nfts/{id}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoNftDetails>(GetBaseAddress(), request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Nft by contract address
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoNftDetails>> GetNftByContractAddressAsync(string platformId, string contractAddress, CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/nfts/{platformId}/contract/{contractAddress}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoNftDetails>(GetBaseAddress(), request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Search
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoSearchResult>> SearchAsync(string query, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddParameter("query", query);
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/search", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoSearchResult>(GetBaseAddress(), request, parameters, ct).ConfigureAwait(false);
        }

        #endregion

        #region Trending
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoTrendingSearch>> GetTrendingSearchesAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/search/trending", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            return await SendAsync<CoinGeckoTrendingSearch>(GetBaseAddress(), request, null, ct).ConfigureAwait(false);
        }

        #endregion

        #region Get Company Holdings

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoCompanyHolding>> GetCompanyHoldingsAsync(string asset, CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"/api/v3/companies/public_treasury/{asset}", CoinGeckoApi.RateLimiter.CoinGecko, 1, false);
            var result = await SendAsync<CoinGeckoCompanyHolding>(GetBaseAddress(), request, null, ct).ConfigureAwait(false);
            return result;
        }

        #endregion

        #region Get Api Usage
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoApiUsage>> GetApiUsageAsync(CancellationToken ct = default)
        {
            var request = _definitions.GetOrCreate(HttpMethod.Get, $"api/v3/key", CoinGeckoApi.RateLimiter.CoinGecko, 1, true);
            return await SendAsync<CoinGeckoApiUsage>(GetBaseAddress(), request, null, ct).ConfigureAwait(false);
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
        protected override AuthenticationProvider CreateAuthenticationProvider(ApiCredentials credentials) => new CoinGeckoAuthenticationProvider((CoinGeckoApiCredentials)credentials);
    }
}
