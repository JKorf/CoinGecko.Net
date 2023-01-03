using Bybit.Net.Objects;
using CoinGecko.Net.Objects.Models;
using CryptoExchange.Net;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Converters;
using CryptoExchange.Net.Logging;
using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoinGecko.Net.Clients.AssetApi
{
    public class CoinGeckoAssetApi
    {
        private CoinGeckoApi _baseClient;

        internal CoinGeckoAssetApi(CoinGeckoApi baseClient)
        {
            _baseClient = baseClient;
        }

        #region Ping

        /// <inheritdoc />
        public async Task<WebCallResult<string>> PingAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            var result = await _baseClient.SendRequestAsync<Dictionary<string, string>>(_baseClient.GetUrl("api/v3/ping"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
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

            return await _baseClient.SendRequestAsync<IEnumerable<CoinGeckoAsset>>(_baseClient.GetUrl("api/v3/coins/list"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
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
            parameters.AddOptionalParameter("ids", assetIds == null ? null: string.Join(",", assetIds));
            parameters.AddOptionalParameter("category", category);
            parameters.AddOptionalParameter("order", order);
            parameters.AddOptionalParameter("per_page", pageSize);
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("sparkline", sparkline);
            parameters.AddOptionalParameter("price_change_percentage", priceChangePercentages == null ? null: string.Join(", ", priceChangePercentages));

            return await _baseClient.SendRequestAsync<IEnumerable<CoinGeckoMarket>>(_baseClient.GetUrl("api/v3/coins/markets"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Asset

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoAssetDetails>> GetAssetDetailsAsync(
            string coinId,
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

            return await _baseClient.SendRequestAsync<CoinGeckoAssetDetails>(_baseClient.GetUrl("api/v3/coins/" + coinId), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
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
            parameters.AddOptionalParameter("exchange_ids", exchangeIds == null? null: string.Join(",", exchangeIds));
            parameters.AddOptionalParameter("include_exchange_logo", includeExchangeLogo);
            parameters.AddOptionalParameter("page", page);
            parameters.AddOptionalParameter("order", order);
            parameters.AddOptionalParameter("depth", depth);

            return await _baseClient.SendRequestAsync<CoinGeckoTickers>(_baseClient.GetUrl("api/v3/coins/" + coinId + "/tickers"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Tickers

        /// <inheritdoc />
        public async Task<WebCallResult<CoinGeckoAssetHistory>> GetHistoryAsync(
            string coinId,
            DateTime date,
            bool? localization = null,
            CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddParameter("date", date.ToString("dd-MM-yyyy"));
            parameters.AddOptionalParameter("localization", localization);

            return await _baseClient.SendRequestAsync<CoinGeckoAssetHistory>(_baseClient.GetUrl("api/v3/coins/" + coinId + "/history"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
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

            return await _baseClient.SendRequestAsync<CoinGeckoMarketChart>(_baseClient.GetUrl("api/v3/coins/" + coinId + "/market_chart"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
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

            return await _baseClient.SendRequestAsync<CoinGeckoMarketChart>(_baseClient.GetUrl("api/v3/coins/" + coinId + "/market_chart/range"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
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

            return await _baseClient.SendRequestAsync<IEnumerable<CoinGeckoOhlc>>(_baseClient.GetUrl("api/v3/coins/" + coinId + "/ohlc"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
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
            return await _baseClient.SendRequestAsync<Dictionary<string, Dictionary<string, decimal?>>>(_baseClient.GetUrl("api/v3/simple/price"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
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
            return await _baseClient.SendRequestAsync<Dictionary<string, Dictionary<string, decimal?>>>(_baseClient.GetUrl("api/v3/simple/token_price/" + platformId), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion

        #region Get Quote Assets

        /// <inheritdoc />
        public async Task<WebCallResult<IEnumerable<string>>> GetQuoteAssetsAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            return await _baseClient.SendRequestAsync<IEnumerable<string>>(_baseClient.GetUrl("api/v3/simple/supported_vs_currencies"), HttpMethod.Get, ct, parameters).ConfigureAwait(false);
        }

        #endregion
    }
}
