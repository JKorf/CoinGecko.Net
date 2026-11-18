using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System;
using CoinGecko.Net.Objects.Models;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Interfaces;
using CoinGecko.Net.Enums;
using CryptoExchange.Net.Interfaces.Clients;

namespace CoinGecko.Net.Interfaces
{
    /// <summary>
    /// CoinGecko API endpoints
    /// </summary>
    public interface ICoinGeckoRestClientApi: IRestApiClient<CoinGeckoCredentials>
    {
        /// <summary>
        /// Get asset categories
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-categories-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/categories/list
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoCategory[]>> GetAssetCategoriesAsync(CancellationToken ct = default);
        /// <summary>
        /// Get asset details
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}
        /// </para>
        /// </summary>
        /// <param name="assetId">The asset id</param>
        /// <param name="localization">["<c>localization</c>"] Include localization</param>
        /// <param name="tickers">["<c>tickers</c>"] Include tickers</param>
        /// <param name="marketData">["<c>market_data</c>"] Include market data</param>
        /// <param name="communityData">["<c>community_data</c>"] Include community data</param>
        /// <param name="developerData">["<c>developer_data</c>"] Include developer data</param>
        /// <param name="sparkline">["<c>sparkline</c>"] Include sparkline</param>
        /// <param name="dexPairFormat">["<c>dex_pair_format</c>"] Dex pair formatting. Defaults to ContractAddress</param>
        /// <param name="includeCategoriesDetails">["<c>include_categories_details</c>"] Include categories details.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoAssetDetails>> GetAssetDetailsAsync(
            string assetId, 
            bool? localization = null, 
            bool? tickers = null, 
            bool? marketData = null,
            bool? communityData = null,
            bool? developerData = null, 
            bool? sparkline = null,
            DexPairFormat? dexPairFormat = null,
            bool? includeCategoriesDetails = null,
            CancellationToken ct = default);
        /// <summary>
        /// Get asset details by contract address
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-contract-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/contract/{contractAddress}
        /// </para>
        /// </summary>
        /// <param name="assetId">Id of the asset</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoAssetDetails>> GetAssetDetailsFromContractAsync(string assetId, string contractAddress, CancellationToken ct = default);
        /// <summary>
        /// Get asset platforms list
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/asset-platforms-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/asset_platforms
        /// </para>
        /// </summary>
        /// <param name="filter">["<c>filter</c>"] Filter</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoAssetPlatform[]>> GetAssetPlatformsAsync(AssetPlatformsFilter? filter = null, CancellationToken ct = default);
        /// <summary>
        /// Get list of all assets
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/list
        /// </para>
        /// </summary>
        /// <param name="includePlatform">["<c>include_platform</c>"] Include platform contract address</param>
        /// <param name="status">["<c>status</c>"] Filter by status of coins.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoAsset[]>> GetAssetsAsync(bool? includePlatform = null, ListingStatus? status = null, CancellationToken ct = default);
        /// <summary>
        /// Get BTC-to-Currency exchange rates
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/exchange-rates" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/exchange_rates
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoExchangeRates>> GetBtcExchangeRatesAsync(CancellationToken ct = default);
        /// <summary>
        /// Get list of derivative tickers
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/derivatives-tickers" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/derivatives
        /// </para>
        /// </summary>
        /// <param name="page">["<c>page</c>"] Page number</param>
        /// <param name="pageSize">["<c>per_page</c>"] Results per page</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDerivative[]>> GetDerivativesAsync(int? page = null, int? pageSize = null, CancellationToken ct = default);
        /// <summary>
        /// Get supported underlying assets for derivatives. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/derivatives-underlyings-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/derivatives/underlyings/list
        /// </para>
        /// </summary>
        /// <param name="underlyingType">["<c>underlying_type</c>"] Filter by underlying asset type</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDerivativeUnderlyingAsset[]>> GetDerivativeUnderlyingAssetsAsync(
            DerivativeUnderlyingType? underlyingType = null,
            CancellationToken ct = default);
        /// <summary>
        /// List all derivatives exchanges name and identifier
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/derivatives-exchanges-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/derivatives/exchanges/list
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoListItem[]>> GetDerivativesExchangesListAsync(CancellationToken ct = default);
        /// <summary>
        /// Get all derivatives exchanges
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/derivatives-exchanges" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/derivatives/exchanges
        /// </para>
        /// </summary>
        /// <param name="page">["<c>page</c>"] Page</param>
        /// <param name="pageSize">["<c>pageSize</c>"] Page size</param>
        /// <param name="order">["<c>order</c>"] Sort order</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoExchangeDerivative[]>> GetExchangeDerivativesAsync(int? page = null, int? pageSize = null, ExchangeDerivativesOrder? order = null, CancellationToken ct = default);

        /// <summary>
        /// Get exchange derivative details
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/derivatives-exchanges-id" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/derivatives/exchanges/{exchangeId}
        /// </para>
        /// </summary>
        /// <param name="exchangeId">Exchange id</param>
        /// <param name="includeTickers">["<c>include_tickers</c>"] Include tickers, 'all' or 'unexpired'</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoExchangeDerivative>> GetExchangeDerivativesDetailsAsync(string exchangeId, ExchangeDerivativesDetailsIncludeTickers? includeTickers = null, CancellationToken ct = default);

        /// <summary>
        /// Get exchange details
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/exchanges-id" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/exchanges/{exchangeId}
        /// </para>
        /// </summary>
        /// <param name="exchangeId">Id of the exchange</param>
        /// <param name="dexPairFormat">["<c>dex_pair_format</c>"] Dex pair formatting. Defaults to ContractAddress</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoExchangeDetails>> GetExchangeDetailsAsync(
            string exchangeId, 
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default);
        /// <summary>
        /// Get all exchanges 
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/exchanges-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/exchanges/list
        /// </para>
        /// </summary>
        /// <param name="status">["<c>status</c>"] Filter by status of exchanges.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoListItem[]>> GetExchangeListAsync(ListingStatus? status = null, CancellationToken ct = default);
        /// <summary>
        /// Get all exchanges
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/exchanges" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/exchanges
        /// </para>
        /// </summary>
        /// <param name="page">["<c>page</c>"] Page</param>
        /// <param name="pageSize">["<c>per_page</c>"] Page size</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoExchange[]>> GetExchangesAsync(int? page = null, int? pageSize = null, CancellationToken ct = default);
        /// <summary>
        /// Get exchange tickers
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/exchanges-id-tickers" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/exchanges/{exchangeId}/tickers
        /// </para>
        /// </summary>
        /// <param name="exchangeId">Exchange id</param>
        /// <param name="assetIds">["<c>coin_ids</c>"] Asset ids filter</param>
        /// <param name="includeExchangeLogo">["<c>include_exchange_logo</c>"] Include exchange logo</param>
        /// <param name="page">["<c>page</c>"] Page</param>
        /// <param name="depth">["<c>depth</c>"] Include orderbook 2% depth</param>
        /// <param name="order">["<c>order</c>"] Sort</param>
        /// <param name="dexPairFormat">["<c>dex_pair_format</c>"] Dex pair formatting. Defaults to ContractAddress</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoTickers>> GetExchangeTickersAsync(
            string exchangeId,
            IEnumerable<string>? assetIds = null,
            bool? includeExchangeLogo = null,
            int? page = null,
            bool? depth = null, 
            ExchangeTickersOrder? order = null,
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default);
        /// <summary>
        /// Get volume chart data for an exchange, interval is determined automatically: 1 day -> 10 minutes, 7-14 days -> 1 hour, 30+ days -> 1 day
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/exchanges-id-volume-chart" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/exchanges/{exchangeId}/volume_chart
        /// </para>
        /// </summary>
        /// <param name="exchangeId">Exchange id</param>
        /// <param name="days">["<c>days</c>"] Days history</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoMarketChartValue[]>> GetExchangeVolumeHistoryAsync(string exchangeId, int days, CancellationToken ct = default);
        /// <summary>
        /// Get asset history info
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-history" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/history
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="date">["<c>date</c>"] Date snapshot time</param>
        /// <param name="localization">["<c>localization</c>"] Include localization</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoAssetHistory>> GetAssetHistoryAsync(string assetId, DateTime date, bool? localization = null, CancellationToken ct = default);
        /// <summary>
        /// Get historical market data
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-market-chart-range" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/market_chart/range
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="from">["<c>from</c>"] From date</param>
        /// <param name="to">["<c>to</c>"] To date</param>
        /// <param name="precision">["<c>precision</c>"] Decimal place for currency price value</param>
        /// <param name="interval">["<c>interval</c>"] Data interval, leave empty for auto granularity.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartAsync(string assetId, string quoteAsset, DateTime from, DateTime to, string? precision = null, MarketChartInterval? interval = null, CancellationToken ct = default);
        /// <summary>
        /// Get historical market data
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-market-chart" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/market_chart
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="days">["<c>days</c>"] Days back</param>
        /// <param name="interval">["<c>interval</c>"] Data interval</param>
        /// <param name="precision">["<c>precision</c>"] Decimal place for currency price value</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartAsync(string assetId, string quoteAsset, int days, MarketChartInterval? interval = null, string? precision = null, CancellationToken ct = default);

        /// <summary>
        /// Get historical market data
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-market-chart" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/market_chart
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="days">Number of days or <c>max</c></param>
        /// <param name="interval">["<c>interval</c>"] Data interval</param>
        /// <param name="precision">["<c>precision</c>"] Decimal place for currency price value</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartAsync(string assetId, string quoteAsset, string days, MarketChartInterval? interval = null, string? precision = null, CancellationToken ct = default);
        /// <summary>
        /// Get historical market data by contract
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/contract-address-market-chart-range" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/contract/{contractAddress}/market_chart/range
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="from">["<c>from</c>"] From time</param>
        /// <param name="to">["<c>to</c>"] To time</param>
        /// <param name="interval">["<c>interval</c>"] Data interval, leave empty for auto granularity.</param>
        /// <param name="precision">["<c>precision</c>"] Decimal place for currency price value.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(string assetId, string contractAddress, string quoteAsset, DateTime from, DateTime to, MarketChartInterval? interval = null, string? precision = null, CancellationToken ct = default);
        /// <summary>
        /// Get historical market data by contract
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-categories-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/contract/{contractAddress}/market_chart
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="days">["<c>days</c>"] Days back</param>
        /// <param name="interval">["<c>interval</c>"] Data interval, leave empty for auto granularity.</param>
        /// <param name="precision">["<c>precision</c>"] Decimal place for currency price value.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(string assetId, string contractAddress, string quoteAsset, int days, MarketChartInterval? interval = null, string? precision = null, CancellationToken ct = default);

        /// <summary>
        /// Get historical market data by contract
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-categories-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/contract/{contractAddress}/market_chart
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="days">Number of days or <c>max</c></param>
        /// <param name="interval">["<c>interval</c>"] Data interval, leave empty for auto granularity.</param>
        /// <param name="precision">["<c>precision</c>"] Decimal place for currency price value.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(string assetId, string contractAddress, string quoteAsset, string days, MarketChartInterval? interval = null, string? precision = null, CancellationToken ct = default);
        /// <summary>
        /// Get market data categories
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-categories-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/categories
        /// </para>
        /// </summary>
        /// <param name="order">["<c>order</c>"] Sorting</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoMarketDataCategory[]>> GetMarketDataCategoriesAsync(MarketDataCategoriesOrder? order = null, CancellationToken ct = default);
        /// <summary>
        /// Get coins market data
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-markets" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/markets
        /// </para>
        /// </summary>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="assetIds">["<c>ids</c>"] Asset ids, for example `bitcoin` and `tether`</param>
        /// <param name="symbols">["<c>symbols</c>"] Symbols, for example `btc` and `usdt`</param>
        /// <param name="category">["<c>category</c>"] Category filter</param>
        /// <param name="order">["<c>order</c>"] Sorting</param>
        /// <param name="page">["<c>page</c>"] Page</param>
        /// <param name="pageSize">["<c>per_page</c>"] PageSize</param>
        /// <param name="sparkline">["<c>sparkline</c>"] Include sparkline</param>
        /// <param name="priceChangePercentages">["<c>price_change_percentage</c>"] Include price change percentages</param>
        /// <param name="locale">["<c>locale</c>"] Language, defaults to `en`</param>
        /// <param name="precision">["<c>precision</c>"] Decimal place for currency price value</param>
        /// <param name="names">["<c>names</c>"] Coins' names, comma-separated if querying more than 1 coin.</param>
        /// <param name="includeTokens">["<c>include_tokens</c>"] For symbols lookups, specify all to include all matching tokens.</param>
        /// <param name="includeRehypothecated">["<c>include_rehypothecated</c>"] Include rehypothecated tokens in results. When true, returns market_cap_rank_with_rehypothecated field.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoMarket[]>> GetMarketsAsync(
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
            CancellationToken ct = default);

        /// <summary>
        /// Get Open/High/Low/Close data, interval is determined automatically: 1-2 days -> 30 minutes, 3-30 days -> 4 hours, 31+ days -> 4 days
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-ohlc" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/ohlc
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="days">["<c>days</c>"] Days back</param>
        /// <param name="precision">["<c>precision</c>"] Decimal place for currency price value</param>
        /// <param name="interval">["<c>interval</c>"] Data interval, leave empty for auto granularity.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoOhlc[]>> GetOhlcAsync(string assetId, string quoteAsset, int days, string? precision = null, OhlcInterval? interval = null, CancellationToken ct = default);

        /// <summary>
        /// Get Open/High/Low/Close data, interval is determined automatically: 1-2 days -> 30 minutes, 3-30 days -> 4 hours, 31+ days -> 4 days
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-ohlc" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/ohlc
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="days">Number of days or <c>max</c></param>
        /// <param name="precision">["<c>precision</c>"] Decimal place for currency price value</param>
        /// <param name="interval">["<c>interval</c>"] Data interval, leave empty for auto granularity.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoOhlc[]>> GetOhlcAsync(string assetId, string quoteAsset, string days, string? precision = null, OhlcInterval? interval = null, CancellationToken ct = default);

        /// <summary>
        /// Get prices for specific assets
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/simple-price" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/simple/price
        /// </para>
        /// </summary>
        /// <param name="ids">["<c>ids</c>"] Asset ids to get data for, for example `bitcoin` and `tether`</param>
        /// <param name="quoteAssets">["<c>vs_currencies</c>"] Quote assets</param>
        /// <param name="symbols">["<c>symbols</c>"] Symbols, for example `btc` and `usdt`</param>
        /// <param name="includeMarketCap">["<c>include_market_cap</c>"] Include market cap</param>
        /// <param name="include24hrVolume">["<c>include_24hr_vol</c>"] Include 24h volume</param>
        /// <param name="include24hrChange">["<c>include_24hr_change</c>"] Include 24h change</param>
        /// <param name="includeLastUpdatedAt">["<c>include_last_updated_at</c>"] Include last updated at</param>
        /// <param name="precision">["<c>precision</c>"] Precision</param>
        /// <param name="names">["<c>names</c>"] Coins' names, comma-separated if querying more than 1 coin.</param>
        /// <param name="includeTokens">["<c>include_tokens</c>"] For symbols lookups, specify all to include all matching tokens.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<Dictionary<string, Dictionary<string, decimal?>>>> GetPricesAsync(
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
            CancellationToken ct = default);

        /// <summary>
        /// Get list of quote assets
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/simple-supported-currencies" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/simple/supported_vs_currencies
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<string[]>> GetQuoteAssetsAsync(CancellationToken ct = default);
        /// <summary>
        /// Get supported tokenized real-world assets. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/demo/reference/rwas-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/rwas/list
        /// </para>
        /// </summary>
        /// <param name="assetType">["<c>asset_type</c>"] Filter by <c>stock</c>, <c>commodity</c> or <c>etf</c></param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoRwa[]>> GetRwasAsync(RwaAssetType? assetType = null, CancellationToken ct = default);
        /// <summary>
        /// Get supported issuers of tokenized real-world assets. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/demo/reference/rwas-issuers-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/rwas/issuers/list
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoListItem[]>> GetRwaIssuersAsync(CancellationToken ct = default);
        /// <summary>
        /// Get tickers for an asset
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-tickers" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/tickers
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="exchangeIds">["<c>exchange_ids</c>"] Exchange ids</param>
        /// <param name="includeExchangeLogo">["<c>include_exchange_logo</c>"] Include exchange logo</param>
        /// <param name="page">["<c>page</c>"] Page</param>
        /// <param name="order">["<c>order</c>"] Sorting</param>
        /// <param name="depth">["<c>depth</c>"] Include 2% order book depth info</param>
        /// <param name="dexPairFormat">["<c>dex_pair_format</c>"] Dex pair formatting. Defaults to ContractAddress</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoTickers>> GetTickersAsync(
            string assetId,
            IEnumerable<string>? exchangeIds = null,
            bool? includeExchangeLogo = null,
            int? page = null,
            TickerOrder? order = null,
            bool? depth = null, 
            DexPairFormat? dexPairFormat = null, 
            CancellationToken ct = default);
        /// <summary>
        /// Get prices by token contract addresses
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/simple-token-price" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/simple/token_price/{platformId}
        /// </para>
        /// </summary>
        /// <param name="platformId">Platform id</param>
        /// <param name="contractAddresses">["<c>contract_addresses</c>"] Contract addresses</param>
        /// <param name="quoteAssets">["<c>vs_currencies</c>"] Quote assets</param>
        /// <param name="includeMarketCap">["<c>include_market_cap</c>"] Include market cap</param>
        /// <param name="include24hrVolume">["<c>include_24hr_vol</c>"] Include 24h volume</param>
        /// <param name="include24hrChange">["<c>include_24hr_change</c>"] Include 24h change</param>
        /// <param name="includeLastUpdatedAt">["<c>include_last_updated_at</c>"] Include last updated at</param>
        /// <param name="precision">["<c>precision</c>"] Precision</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<Dictionary<string, Dictionary<string, decimal?>>>> GetTokenPricesAsync(string platformId, IEnumerable<string> contractAddresses, IEnumerable<string> quoteAssets, bool? includeMarketCap = false, bool? include24hrVolume = false, bool? include24hrChange = false, bool? includeLastUpdatedAt = false, string? precision = null, CancellationToken ct = default);
        /// <summary>
        /// Ping the server
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/ping-server" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/ping
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<string>> PingAsync(CancellationToken ct = default);
        /// <summary>
        /// Get global crypto data
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/crypto-global" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/global
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoGlobalData>> GetGlobalDataAsync(CancellationToken ct = default);
        /// <summary>
        /// Get global defi crypto data
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/global-defi" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/global/decentralized_finance_defi
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoGlobalDefiData>> GetGlobalDefiDataAsync(CancellationToken ct = default);

        /// <summary>
        /// Get list of nfts
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/nfts-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/nfts/list
        /// </para>
        /// </summary>
        /// <param name="order">["<c>order</c>"] Sort</param>
        /// <param name="page">["<c>page</c>"] Page</param>
        /// <param name="pageSize">["<c>per_page</c>"] Page size</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoNft[]>> GetNftsAsync(NftsOrder? order = null, int? page = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Get details on an NFT
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/nfts-id" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/nfts/{id}
        /// </para>
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoNftDetails>> GetNftAsync(string id, CancellationToken ct = default);

        /// <summary>
        /// Get nft info by contract address
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/nfts-contract-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/nfts/{platformId}/contract/{contractAddress}
        /// </para>
        /// </summary>
        /// <param name="platformId">Platform id</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoNftDetails>> GetNftByContractAddressAsync(string platformId, string contractAddress, CancellationToken ct = default);

        /// <summary>
        /// Search for assets, exchanges, categories or nfts
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/search-data" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/search
        /// </para>
        /// </summary>
        /// <param name="query">["<c>query</c>"] Search query</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoSearchResult>> SearchAsync(string query, CancellationToken ct = default);

        /// <summary>
        /// Get trending searches
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/trending-search" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/search/trending
        /// </para>
        /// </summary>
        /// <param name="showMax">["<c>show_max</c>"] Show max number of results available for the given type.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoTrendingSearch>> GetTrendingSearchesAsync(IEnumerable<TrendingSearchesShowMax>? showMax = null, CancellationToken ct = default);

        /// <summary>
        /// Get public companies and governments tracked by CoinGecko. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/entities-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/entities/list
        /// </para>
        /// </summary>
        /// <param name="entityType">["<c>entity_type</c>"] Filter by entity type</param>
        /// <param name="page">["<c>page</c>"] Page number. Defaults to 1</param>
        /// <param name="pageSize">["<c>per_page</c>"] Results per page, from 1 to 250. Defaults to 100</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoTreasuryEntity[]>> GetTreasuryEntitiesAsync(
            TreasuryEntityType? entityType = null,
            int? page = null,
            int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Get public company holdings for an asset
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/companies-public-treasury" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/companies/public_treasury/{asset}
        /// </para>
        /// </summary>
        /// <param name="asset">Asset name</param>
        /// <param name="ct">Cancellation token</param>
        Task<HttpResult<CoinGeckoCompanyHolding>> GetCompanyHoldingsAsync(string asset, CancellationToken ct = default);

        /// <summary>
        /// Get current API usage stats
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/api-usage" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/key
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoApiUsage>> GetApiUsageAsync(CancellationToken ct = default);

        /// <summary>
        /// Top Gainers &amp; Losers. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-top-gainers-losers" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/top_gainers_losers
        /// </para>
        /// </summary>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Target currency of coins.</param>
        /// <param name="duration">["<c>duration</c>"] Filter result by time range.</param>
        /// <param name="priceChangePercentage">["<c>price_change_percentage</c>"] Include price change percentage timeframe, comma-separated if querying more than 1 timeframe.</param>
        /// <param name="topCoins">["<c>top_coins</c>"] Filter result by market cap ranking (top 300 to 1000) or all coins (including coins that do not have market cap).</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoTopGainersLosers>> GetTopGainersAndLosersAsync(
            string quoteAsset,
            TopGainersAndLosersDuration? duration = null,
            IEnumerable<TopGainersAndLosersPriceChangePercentage>? priceChangePercentage = null,
            string? topCoins = null,
            CancellationToken ct = default);

        /// <summary>
        /// Coin OHLC Chart within Time Range by ID. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-ohlc-range" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{id}/ohlc/range
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] Coin ID.</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Target currency of price data.</param>
        /// <param name="from">["<c>from</c>"] Starting date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="to">["<c>to</c>"] Ending date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="interval">["<c>interval</c>"] Data interval.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoOhlc[]>> GetOhlcRangeAsync(
            string id,
            string quoteAsset,
            DateTime from,
            DateTime to,
            OhlcInterval interval,
            CancellationToken ct = default);

        /// <summary>
        /// Circulating Supply Chart by ID. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-circulating-supply-chart" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{id}/circulating_supply_chart
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] Coin ID.</param>
        /// <param name="days">["<c>days</c>"] Data up to number of days ago.</param>
        /// <param name="interval">["<c>interval</c>"] Data interval.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoCirculatingSupplyChart>> GetCirculatingSupplyChartAsync(
            string id,
            string days,
            SupplyChartInterval? interval = null,
            CancellationToken ct = default);

        /// <summary>
        /// Circulating Supply Chart within Time Range by ID. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-circulating-supply-chart-range" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{id}/circulating_supply_chart/range
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] Coin ID.</param>
        /// <param name="from">["<c>from</c>"] Starting date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="to">["<c>to</c>"] Ending date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoCirculatingSupplyChart>> GetCirculatingSupplyChartRangeAsync(
            string id,
            DateTime from,
            DateTime to,
            CancellationToken ct = default);

        /// <summary>
        /// Total Supply Chart by ID. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-total-supply-chart" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{id}/total_supply_chart
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] Coin ID.</param>
        /// <param name="days">["<c>days</c>"] Data up to number of days ago.</param>
        /// <param name="interval">["<c>interval</c>"] Data interval.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoTotalSupplyChart>> GetTotalSupplyChartAsync(
            string id,
            string days,
            TotalSupplyChartInterval? interval = null,
            CancellationToken ct = default);

        /// <summary>
        /// Total Supply Chart within Time Range by ID. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-total-supply-chart-range" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{id}/total_supply_chart/range
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] Coin ID.</param>
        /// <param name="from">["<c>from</c>"] Starting date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="to">["<c>to</c>"] Ending date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoTotalSupplyChart>> GetTotalSupplyChartRangeAsync(
            string id,
            DateTime from,
            DateTime to,
            CancellationToken ct = default);

        /// <summary>
        /// Coin Supply Breakdown by ID. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-id-supply-breakdown" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{id}/supply_breakdown
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] Coin ID.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoCoinSupplyBreakdown>> GetSupplyBreakdownAsync(
            string id,
            CancellationToken ct = default);

        /// <summary>
        /// Recently Added Coins. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/coins-list-new" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/list/new
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoRecentAsset[]>> GetRecentlyAddedAssetsAsync(
            CancellationToken ct = default);

        /// <summary>
        /// Token Lists by Asset Platform ID. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/token-lists" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/token_lists/{asset_platform_id}/all.json
        /// </para>
        /// </summary>
        /// <param name="assetPlatformId">["<c>asset_platform_id</c>"] Asset platform ID.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoTokenList>> GetTokenListAsync(
            string assetPlatformId,
            CancellationToken ct = default);

        /// <summary>
        /// RWA List with Market Data. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/rwas-markets" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/rwas/markets
        /// </para>
        /// </summary>
        /// <param name="assetType">["<c>asset_type</c>"] Filter by RWA asset type.</param>
        /// <param name="ids">["<c>ids</c>"] RWAs' IDs, comma-separated if querying more than 1 RWA.</param>
        /// <param name="names">["<c>names</c>"] RWAs' names, comma-separated if querying more than 1 RWA.</param>
        /// <param name="symbols">["<c>symbols</c>"] RWAs' symbols, comma-separated if querying more than 1 RWA.</param>
        /// <param name="issuer">["<c>issuer</c>"] Filter based on RWAs' issuer.</param>
        /// <param name="includeNonTokenized">["<c>include_non_tokenized</c>"] Include non-tokenized RWAs, which have no tokenized market data.</param>
        /// <param name="order">["<c>order</c>"] Sort result by field.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="sparkline">["<c>sparkline</c>"] Include sparkline 7-day data.</param>
        /// <param name="priceChangePercentage">["<c>price_change_percentage</c>"] Include price change percentage timeframe, comma-separated if querying more than 1 timeframe.</param>
        /// <param name="precision">["<c>precision</c>"] Decimal places for currency price value</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoRwaMarket[]>> GetRwaMarketsAsync(
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
            CancellationToken ct = default);

        /// <summary>
        /// RWA Data by ID. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/rwas-id" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/rwas/{id}
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] RWA ID.</param>
        /// <param name="sparkline">["<c>sparkline</c>"] Include sparkline 7-day data.</param>
        /// <param name="tokens">["<c>tokens</c>"] Include tokens data.</param>
        /// <param name="tokenizedMarketData">["<c>tokenized_market_data</c>"] Include tokenized market data.</param>
        /// <param name="perpsMarketData">["<c>perps_market_data</c>"] Include perpetuals market data.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoRwaDetails>> GetRwaDetailsAsync(
            string id,
            bool? sparkline = null,
            bool? tokens = null,
            bool? tokenizedMarketData = null,
            bool? perpsMarketData = null,
            CancellationToken ct = default);

        /// <summary>
        /// RWA Tickers by ID. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/rwas-id-tickers" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/rwas/{id}/tickers
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] RWA ID.</param>
        /// <param name="issuerIds">["<c>issuer_ids</c>"] Issuer ID.</param>
        /// <param name="exchangeIds">["<c>exchange_ids</c>"] Exchange ID.</param>
        /// <param name="page">["<c>page</c>"] Page through results</param>
        /// <param name="order">["<c>order</c>"] Sort the order of responses.</param>
        /// <param name="depth">["<c>depth</c>"] Include 2% orderbook depth, i.e. cost_to_move_up_usd and cost_to_move_down_usd.</param>
        /// <param name="dexPairFormat">["<c>dex_pair_format</c>"] Set to symbol to display DEX pair base and target as symbols.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoRwaTickers>> GetRwaTickersAsync(
            string id,
            IEnumerable<string>? issuerIds = null,
            IEnumerable<string>? exchangeIds = null,
            int? page = null,
            TickerOrder? order = null,
            bool? depth = null,
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default);

        /// <summary>
        /// RWA Historical Chart Data by ID. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/rwas-id-market-chart" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/rwas/{id}/market_chart
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] RWA ID.</param>
        /// <param name="days">["<c>days</c>"] Data up to number of days ago.</param>
        /// <param name="interval">["<c>interval</c>"] Data interval, leave empty for auto granularity.</param>
        /// <param name="precision">["<c>precision</c>"] Decimal place for currency price value.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoRwaMarketChart>> GetRwaMarketChartAsync(
            string id,
            string? days = null,
            SupplyChartInterval? interval = null,
            string? precision = null,
            CancellationToken ct = default);

        /// <summary>
        /// RWA Issuer Data by ID. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/rwas-issuers-id" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/rwas/issuers/{id}
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] Issuer ID.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoRwaIssuerDetails>> GetRwaIssuerDetailsAsync(
            string id,
            CancellationToken ct = default);

        /// <summary>
        /// Exchange Volume Chart within Time Range by ID. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/exchanges-id-volume-chart-range" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/exchanges/{id}/volume_chart/range
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] Exchange ID or derivative exchange ID.</param>
        /// <param name="from">["<c>from</c>"] Starting date in UNIX timestamp.</param>
        /// <param name="to">["<c>to</c>"] Ending date in UNIX timestamp.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoMarketChartValue[]>> GetExchangeVolumeHistoryRangeAsync(
            string id,
            DateTime from,
            DateTime to,
            CancellationToken ct = default);

        /// <summary>
        /// Derivatives Underlying Assets List with Data. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/derivatives-underlyings" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/derivatives/underlyings
        /// </para>
        /// </summary>
        /// <param name="coinIds">["<c>coin_ids</c>"] Coins' IDs, comma-separated if querying more than 1 coin.</param>
        /// <param name="rwaIds">["<c>rwa_ids</c>"] RWAs' IDs, comma-separated if querying more than 1 RWA.</param>
        /// <param name="underlyingType">["<c>underlying_type</c>"] Filter by underlying type.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="order">["<c>order</c>"] Sort result by field.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDerivativeUnderlyingMarket[]>> GetDerivativeUnderlyingMarketsAsync(
            IEnumerable<string>? coinIds = null,
            IEnumerable<string>? rwaIds = null,
            DerivativeUnderlyingType? underlyingType = null,
            int? page = null,
            int? pageSize = null,
            DerivativeUnderlyingMarketsOrder? order = null,
            CancellationToken ct = default);

        /// <summary>
        /// Crypto Treasury Holdings by Coin ID. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/companies-public-treasury" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/{entity}/public_treasury/{coin_id}
        /// </para>
        /// </summary>
        /// <param name="entity">["<c>entity</c>"] Public company or government entity.</param>
        /// <param name="coinId">["<c>coin_id</c>"] Coin ID.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="order">["<c>order</c>"] Sort order for results.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoPublicTreasury>> GetTreasuryHoldingsAsync(
            TreasuryHoldingEntityType entity,
            string coinId,
            int? pageSize = null,
            int? page = null,
            TreasuryHoldingsOrder? order = null,
            CancellationToken ct = default);

        /// <summary>
        /// Crypto Treasury Holdings by Entity ID. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/public-treasury-entity" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/public_treasury/{entity_id}
        /// </para>
        /// </summary>
        /// <param name="entityId">["<c>entity_id</c>"] Public company or government entity ID.</param>
        /// <param name="holdingAmountChange">["<c>holding_amount_change</c>"] Include holding amount change for specified timeframes, comma-separated if querying more than 1 timeframe.</param>
        /// <param name="holdingChangePercentage">["<c>holding_change_percentage</c>"] Include holding change percentage for specified timeframes, comma-separated if querying more than 1 timeframe.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoPublicTreasuryEntity>> GetTreasuryEntityHoldingsAsync(
            string entityId,
            IEnumerable<TreasuryHoldingChangePeriod>? holdingAmountChange = null,
            IEnumerable<TreasuryHoldingChangePeriod>? holdingChangePercentage = null,
            CancellationToken ct = default);

        /// <summary>
        /// Crypto Treasury Holdings Historical Chart Data by ID. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/public-treasury-entity-chart" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/public_treasury/{entity_id}/{coin_id}/holding_chart
        /// </para>
        /// </summary>
        /// <param name="entityId">["<c>entity_id</c>"] Public company or government entity ID.</param>
        /// <param name="coinId">["<c>coin_id</c>"] Coin ID.</param>
        /// <param name="days">["<c>days</c>"] Data up to number of days ago.</param>
        /// <param name="includeEmptyIntervals">["<c>include_empty_intervals</c>"] Include empty intervals with no transaction data.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoPublicTreasuryEntityChart>> GetTreasuryHoldingsChartAsync(
            string entityId,
            string coinId,
            string days,
            bool? includeEmptyIntervals = null,
            CancellationToken ct = default);

        /// <summary>
        /// Crypto Treasury Transaction History by Entity ID. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/public-treasury-transaction-history" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/public_treasury/{entity_id}/transaction_history
        /// </para>
        /// </summary>
        /// <param name="entityId">["<c>entity_id</c>"] Public company or government entity ID.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="order">["<c>order</c>"] Sort order of transactions.</param>
        /// <param name="coinIds">["<c>coin_ids</c>"] Filter transactions by coin IDs, comma-separated if querying more than 1 coin.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoPublicTreasuryTransactionHistory>> GetTreasuryTransactionsAsync(
            string entityId,
            int? pageSize = null,
            int? page = null,
            TreasuryTransactionsOrder? order = null,
            IEnumerable<string>? coinIds = null,
            CancellationToken ct = default);

        /// <summary>
        /// NFTs List with Market Data. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/nfts-markets" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/nfts/markets
        /// </para>
        /// </summary>
        /// <param name="assetPlatformId">["<c>asset_platform_id</c>"] Filter result by asset platform (blockchain network).</param>
        /// <param name="order">["<c>order</c>"] Sort results by field.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoNftMarket[]>> GetNftMarketsAsync(
            string? assetPlatformId = null,
            NftMarketsOrder? order = null,
            int? pageSize = null,
            int? page = null,
            CancellationToken ct = default);

        /// <summary>
        /// NFTs Collection Historical Chart Data by ID. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/nfts-id-market-chart" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/nfts/{id}/market_chart
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] NFT collection ID.</param>
        /// <param name="days">["<c>days</c>"] Data up to number of days ago.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoNftMarketChart>> GetNftMarketChartAsync(
            string id,
            string days,
            CancellationToken ct = default);

        /// <summary>
        /// NFTs Collection Historical Chart Data by Contract Address. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/nfts-contract-address-market-chart" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/nfts/{asset_platform_id}/contract/{contract_address}/market_chart
        /// </para>
        /// </summary>
        /// <param name="assetPlatformId">["<c>asset_platform_id</c>"] Asset platform ID.</param>
        /// <param name="contractAddress">["<c>contract_address</c>"] Contract address of the NFT collection.</param>
        /// <param name="days">["<c>days</c>"] Data up to number of days ago.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoNftMarketChart>> GetNftMarketChartByContractAddressAsync(
            string assetPlatformId,
            string contractAddress,
            string days,
            CancellationToken ct = default);

        /// <summary>
        /// NFTs Collection Tickers by ID. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/nfts-id-tickers" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/nfts/{id}/tickers
        /// </para>
        /// </summary>
        /// <param name="id">["<c>id</c>"] NFT collection ID.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoNftTicker>> GetNftTickersAsync(
            string id,
            CancellationToken ct = default);

        /// <summary>
        /// Crypto News. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/news" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/news
        /// </para>
        /// </summary>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="coinId">["<c>coin_id</c>"] Filter news by coin ID.</param>
        /// <param name="language">["<c>language</c>"] Filter news by language.</param>
        /// <param name="type">["<c>type</c>"] Filter news by type.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoNewsResponse[]>> GetNewsAsync(
            int? page = null,
            int? pageSize = null,
            string? coinId = null,
            NewsLanguage? language = null,
            NewsType? type = null,
            CancellationToken ct = default);

        /// <summary>
        /// Coin Insights. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/insights" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/insights
        /// </para>
        /// </summary>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="coinId">["<c>coin_id</c>"] Filter insights by coin ID.</param>
        /// <param name="from">["<c>from</c>"] Starting date in ISO date string (YYYY-MM-DD).</param>
        /// <param name="to">["<c>to</c>"] Ending date in ISO date string (YYYY-MM-DD).</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoInsightsResponse[]>> GetInsightsAsync(
            int? page = null,
            int? pageSize = null,
            string? coinId = null,
            DateTime? from = null,
            DateTime? to = null,
            CancellationToken ct = default);

        /// <summary>
        /// Global Market Cap Chart Data. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/global-market-cap-chart" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/global/market_cap_chart
        /// </para>
        /// </summary>
        /// <param name="days">["<c>days</c>"] Data up to number of days ago.</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Target currency of market cap.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoGlobalMarketCapChart>> GetGlobalMarketCapChartAsync(
            string days,
            string? quoteAsset = null,
            CancellationToken ct = default);

        /// <summary>
        /// Global Fear &amp; Greed Chart Data. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/global-fear-and-greed-chart" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/global/fear_and_greed_chart
        /// </para>
        /// </summary>
        /// <param name="days">["<c>days</c>"] Data up to number of days ago.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoGlobalFearAndGreedChart>> GetGlobalFearAndGreedChartAsync(
            string days,
            CancellationToken ct = default);
    }
}
