using CoinGecko.Net.Interfaces;
using CoinGecko.Net.Objects;
using CoinGecko.Net.Objects.Models;
using CryptoExchange.Net;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Converters;
using CryptoExchange.Net.Logging;
using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CoinGecko.Net.Clients
{
    /// <inheritdoc />
    public class CoinGeckoClientApi : RestApiClient, ICoinGeckoClientApi
    {
        internal CoinGeckoClientApi(Log log, CoinGeckoClientOptions options) : base(log, options, options.ApiOptions)
        {
        }

        #region Ping

        /// <inheritdoc />
        public async Task<WebCallResult<string>> PingAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            var result = await SendRequestAsync<Dictionary<string, string>>(GetUrl("api/v3/ping"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
            if (!result)
                return result.As<string>(default);

            return result.As(result.Data["gecko_says"]);
        }

        #endregion

        #region Get Assets

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoAsset>>> GetAssetsAsync(bool? includePlatform = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("includePlatform", includePlatform);

            return await SendRequestAsync<IEnumerable<CoinGeckoAsset>>(GetUrl("api/v3/coins/list"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Markets

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoMarket>>> GetMarketsAsync(
            string quoteAsset,
            IEnumerable<string>? assetIds = null,
            string? category = null,
            string? order = null,
            int? page = null,
            int? pageSize = null,
            bool? sparkline = null,
            IEnumerable<string>? priceChangePercentages = null,
            CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddParameter("vs_currency", quoteAsset);
            parameters.AddOptionalParameter("ids", assetIds == null ? null : string.Join(",", assetIds));
            parameters.AddOptionalParameter("category", category);
            parameters.AddOptionalParameter("order", order);
            parameters.AddOptionalParameter("per_page", pageSize);
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("sparkline", sparkline);
            parameters.AddOptionalParameter("price_change_percentage", priceChangePercentages == null ? null : string.Join(", ", priceChangePercentages));

            return await SendRequestAsync<IEnumerable<CoinGeckoMarket>>(GetUrl("api/v3/coins/markets"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
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
            CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("localization", localization);
            parameters.AddOptionalParameter("tickers", tickers);
            parameters.AddOptionalParameter("market_data", marketData);
            parameters.AddOptionalParameter("community_data", communityData);
            parameters.AddOptionalParameter("developer_data", developerData);
            parameters.AddOptionalParameter("sparkline", sparkline);

            return await SendRequestAsync<CoinGeckoAssetDetails>(GetUrl("api/v3/coins/" + assetId), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Tickers

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoTickers>> GetTickersAsync(
            string coinId,
            IEnumerable<string>? exchangeIds = null,
            bool? includeExchangeLogo = null,
            int? page = null,
            string? order = null,
            bool? depth = null,
            CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("exchange_ids", exchangeIds == null ? null : string.Join(",", exchangeIds));
            parameters.AddOptionalParameter("include_exchange_logo", includeExchangeLogo);
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("order", order);
            parameters.AddOptionalParameter("depth", depth);

            return await SendRequestAsync<CoinGeckoTickers>(GetUrl("api/v3/coins/" + coinId + "/tickers"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Tickers

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoAssetHistory>> GetAssetHistoryAsync(
            string coinId,
            DateTime date,
            bool? localization = null,
            CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddParameter("date", date.ToString("dd-MM-yyyy"));
            parameters.AddOptionalParameter("localization", localization);

            return await SendRequestAsync<CoinGeckoAssetHistory>(GetUrl("api/v3/coins/" + coinId + "/history"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartAsync(
            string coinId,
            string quoteAsset,
            int days,
            string? interval = null,
            CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddParameter("vs_currency", quoteAsset);
            parameters.AddParameter("days", days);
            parameters.AddOptionalParameter("interval", interval);

            return await SendRequestAsync<CoinGeckoMarketChart>(GetUrl("api/v3/coins/" + coinId + "/market_chart"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartAsync(
            string coinId,
            string quoteAsset,
            DateTime from,
            DateTime to,
            CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddParameter("vs_currency", quoteAsset);
            parameters.AddParameter("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.AddParameter("to", DateTimeConverter.ConvertToSeconds(to));

            return await SendRequestAsync<CoinGeckoMarketChart>(GetUrl("api/v3/coins/" + coinId + "/market_chart/range"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get OHLC

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoOhlc>>> GetOhlcAsync(
            string coinId,
            string quoteAsset,
            int days,
            CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddParameter("vs_currency", quoteAsset);
            parameters.AddParameter("days", days);

            return await SendRequestAsync<IEnumerable<CoinGeckoOhlc>>(GetUrl("api/v3/coins/" + coinId + "/ohlc"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Prices

        /// <inheritdoc />
        public async Task<WebCallResult<Dictionary<string, Dictionary<string, decimal?>>>> GetPricesAsync(
            IEnumerable<string> ids,
            IEnumerable<string> quoteAssets,
            bool? includeMarketCap = false,
            bool? include24hrVolume = false,
            bool? include24hrChange = false,
            bool? includeLastUpdatedAt = false,
            string? precision = null,
            CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddParameter("ids", string.Join(",", ids));
            parameters.AddParameter("vs_currencies", string.Join(",", quoteAssets));
            parameters.AddOptionalParameter("include_market_cap", includeMarketCap);
            parameters.AddOptionalParameter("include_24hr_vol", include24hrVolume);
            parameters.AddOptionalParameter("include_24hr_change", include24hrChange);
            parameters.AddOptionalParameter("include_last_updated_at", includeLastUpdatedAt);
            parameters.AddOptionalParameter("precision", precision);
            return await SendRequestAsync<Dictionary<string, Dictionary<string, decimal?>>>(GetUrl("api/v3/simple/price"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
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
            var parameters = new Dictionary<string, object>();
            parameters.AddParameter("contract_addresses", string.Join(",", contractAddresses));
            parameters.AddParameter("vs_currencies", string.Join(",", quoteAssets));
            parameters.AddOptionalParameter("include_market_cap", includeMarketCap);
            parameters.AddOptionalParameter("include_24hr_vol", include24hrVolume);
            parameters.AddOptionalParameter("include_24hr_change", include24hrChange);
            parameters.AddOptionalParameter("include_last_updated_at", includeLastUpdatedAt);
            parameters.AddOptionalParameter("precision", precision);
            return await SendRequestAsync<Dictionary<string, Dictionary<string, decimal?>>>(GetUrl("api/v3/simple/token_price/" + platformId), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Quote Assets

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<string>>> GetQuoteAssetsAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            return await SendRequestAsync<IEnumerable<string>>(GetUrl("api/v3/simple/supported_vs_currencies"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset Info From Contract

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoAssetDetails>> GetAssetDetailsFromContractAsync(string id, string contractAddress, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            return await SendRequestAsync<CoinGeckoAssetDetails>(GetUrl($"api/v3/coins/{id}/contract/{contractAddress}"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart From Contract

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(
            string coinId,
            string contractAddress,
            string quoteAsset,
            int days,
            CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddParameter("vs_currency", quoteAsset);
            parameters.AddParameter("days", days);

            return await SendRequestAsync<CoinGeckoMarketChart>(GetUrl($"api/v3/coins/{coinId}/contract/{contractAddress}/market_chart"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart From Contract

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(
            string coinId,
            string contractAddress,
            string quoteAsset,
            DateTime from,
            DateTime to,
            CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddParameter("vs_currency", quoteAsset);
            parameters.AddParameter("from", DateTimeConverter.ConvertToSeconds(from));
            parameters.AddParameter("to", DateTimeConverter.ConvertToSeconds(to));

            return await SendRequestAsync<CoinGeckoMarketChart>(GetUrl($"api/v3/coins/{coinId}/contract/{contractAddress}/market_chart/range"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Chart From Contract

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoAssetPlatform>>> GetAssetPlatformsAsync(
            string? filter = null,
            CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("filter", filter);

            return await SendRequestAsync<IEnumerable<CoinGeckoAssetPlatform>>(GetUrl($"api/v3/asset_platforms"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset Categories

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoCategory>>> GetAssetCategoriesAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            return await SendRequestAsync<IEnumerable<CoinGeckoCategory>>(GetUrl($"api/v3/coins/categories/list"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Market Data Categories

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoMarketDataCategory>>> GetMarketDataCategoriesAsync(string? order = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("order", order);
            return await SendRequestAsync<IEnumerable<CoinGeckoMarketDataCategory>>(GetUrl($"api/v3/coins/categories"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchanges

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoExchange>>> GetExchangesAsync(int? page = null, int? pageSize = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("per_page", pageSize);
            parameters.AddOptionalParameter("page", page);
            return await SendRequestAsync<IEnumerable<CoinGeckoExchange>>(GetUrl($"api/v3/exchanges"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchanges Markets

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoListItem>>> GetExchangeMarketsAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            return await SendRequestAsync<IEnumerable<CoinGeckoListItem>>(GetUrl($"api/v3/exchanges/list"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Details

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoExchangeDetails>> GetExchangeDetailsAsync(string exchangeId, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            return await SendRequestAsync<CoinGeckoExchangeDetails>(GetUrl($"api/v3/exchanges/{exchangeId}"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Tickers
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoTickers>> GetExchangeTickersAsync(string exchangeId, IEnumerable<string>? coinIds = null, bool? includeExchangeLogo = null, int? page = null, bool? depth = null, string? order = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("coin_ids", coinIds == null ? null : string.Join(",", coinIds));
            parameters.AddOptionalParameter("include_exchange_logo", includeExchangeLogo);
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("depth", depth);
            parameters.AddOptionalParameter("order", order);
            return await SendRequestAsync<CoinGeckoTickers>(GetUrl($"api/v3/exchanges/{exchangeId}/tickers"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange volumes
        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoMarketChartValue>>> GetExchangeVolumeHistoryAsync(string exchangeId, int days, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddParameter("days", days);
            return await SendRequestAsync<IEnumerable<CoinGeckoMarketChartValue>>(GetUrl($"api/v3/exchanges/{exchangeId}/volume_chart"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Derivatives
        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoDerivative>>> GetDerivativesAsync(string? includeTickers = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("include_tickers", includeTickers);
            return await SendRequestAsync<IEnumerable<CoinGeckoDerivative>>(GetUrl($"api/v3/derivatives"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Exchange Derivatives
        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoExchangeDerivative>>> GetExchangeDerivativesAsync(int? page = null, int? pageSize = null, string? order = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("pageSize", pageSize);
            parameters.AddOptionalParameter("order", order);
            return await SendRequestAsync<IEnumerable<CoinGeckoExchangeDerivative>>(GetUrl($"api/v3/derivatives/exchanges"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Derivatives Exchanges list
        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoListItem>>> GetDerivativesExchangesListAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            return await SendRequestAsync<IEnumerable<CoinGeckoListItem>>(GetUrl($"api/v3/derivatives/exchanges/list"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Derivatives Exchanges list
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoExchangeRates>> GetBtcExchangeRatesAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            return await SendRequestAsync<CoinGeckoExchangeRates>(GetUrl($"api/v3/exchange_rates"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Global Data
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoGlobalData>> GetGlobalDataAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            var data = await SendRequestAsync<CoinGeckoGlobalDataWrapper>(GetUrl($"api/v3/global"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
            if (!data)
                return data.As<CoinGeckoGlobalData>(null);

            return data.As(data.Data.Data!);
        }

        #endregion

        #region Get Global Data
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoGlobalDefiData>> GetGlobalDefiDataAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            var data = await SendRequestAsync<CoinGeckoGlobalDefiDataWrapper>(GetUrl($"api/v3/global/decentralized_finance_defi"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
            if (!data)
                return data.As<CoinGeckoGlobalDefiData>(null);

            return data.As(data.Data.Data!);
        }

        #endregion

        #region Get Nfts
        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoNft>>> GetNftsAsync(string? order = null, string? assetPlatformId = null, int? page = null, int? pageSize = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("order", order);
            parameters.AddOptionalParameter("asset_platform_id", assetPlatformId);
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("per_page", pageSize);
            return await SendRequestAsync<IEnumerable<CoinGeckoNft>>(GetUrl($"api/v3/nfts/list"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Nft
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoNftDetails>> GetNftAsync(string id, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            return await SendRequestAsync<CoinGeckoNftDetails>(GetUrl($"api/v3/nfts/{id}"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Nft by contract address
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoNftDetails>> GetNftByContractAddressAsync(string platformId, string contractAddress, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            return await SendRequestAsync<CoinGeckoNftDetails>(GetUrl($"api/v3/nfts/{platformId}/contract/{contractAddress}"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Search
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoSearchResult>> SearchAsync(string query, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddParameter("query", query);
            return await SendRequestAsync<CoinGeckoSearchResult>(GetUrl($"api/v3/search"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Trending
        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoTrendingSearch>> GetTrendingSearchesAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            return await SendRequestAsync<CoinGeckoTrendingSearch>(GetUrl($"api/v3/search/trending"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Indexes
        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoIndex>>> GetIndexesAsync(int? page = null, int? pageSize = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("per_page", pageSize);
            return await SendRequestAsync<IEnumerable<CoinGeckoIndex>>(GetUrl($"api/v3/indexes"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Indexes list
        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<CoinGeckoListItem>>> GetIndexesListAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            return await SendRequestAsync<IEnumerable<CoinGeckoListItem>>(GetUrl($"api/v3/indexes/list"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        /// <summary>
        /// Get url for an endpoint
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        internal Uri GetUrl(string endpoint)
        {
            return new Uri(BaseAddress.AppendPath(endpoint));
        }

        /// <inheritdoc />
        public override TimeSpan? GetTimeOffset() => null;
        /// <inheritdoc />
        public override TimeSyncInfo? GetTimeSyncInfo() => null;
        /// <inheritdoc />
        protected override AuthenticationProvider CreateAuthenticationProvider(ApiCredentials credentials) => null!;
    }
}
