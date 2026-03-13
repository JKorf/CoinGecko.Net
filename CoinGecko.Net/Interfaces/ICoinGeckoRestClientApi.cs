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
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/coins-categories-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/categories/list
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoCategory[]>> GetAssetCategoriesAsync(CancellationToken ct = default);
        /// <summary>
        /// Get asset details
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/coins-id" /><br />
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
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoAssetDetails>> GetAssetDetailsAsync(
            string assetId, 
            bool? localization = null, 
            bool? tickers = null, 
            bool? marketData = null,
            bool? communityData = null,
            bool? developerData = null, 
            bool? sparkline = null,
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default);
        /// <summary>
        /// Get asset details by contract address
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/coins-contract-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/contract/{contractAddress}
        /// </para>
        /// </summary>
        /// <param name="assetId">Id of the asset</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoAssetDetails>> GetAssetDetailsFromContractAsync(string assetId, string contractAddress, CancellationToken ct = default);
        /// <summary>
        /// Get asset platforms list
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/asset-platforms-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/asset_platforms
        /// </para>
        /// </summary>
        /// <param name="filter">["<c>filter</c>"] Filter</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoAssetPlatform[]>> GetAssetPlatformsAsync(string? filter = null, CancellationToken ct = default);
        /// <summary>
        /// Get list of all assets
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/coins-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/list
        /// </para>
        /// </summary>
        /// <param name="includePlatform">["<c>include_platform</c>"] Include platform contract address</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoAsset[]>> GetAssetsAsync(bool? includePlatform = null, CancellationToken ct = default);
        /// <summary>
        /// Get BTC-to-Currency exchange rates
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/exchange-rates" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/exchange_rates
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoExchangeRates>> GetBtcExchangeRatesAsync(CancellationToken ct = default);
        /// <summary>
        /// Get list of derivative tickers
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/derivatives-tickers" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/derivatives
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoDerivative[]>> GetDerivativesAsync(CancellationToken ct = default);
        /// <summary>
        /// List all derivatives exchanges name and identifier
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/derivatives-exchanges-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/derivatives/exchanges/list
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoListItem[]>> GetDerivativesExchangesListAsync(CancellationToken ct = default);
        /// <summary>
        /// Get all derivatives exchanges
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/derivatives-exchanges" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/derivatives/exchanges
        /// </para>
        /// </summary>
        /// <param name="page">["<c>page</c>"] Page</param>
        /// <param name="pageSize">["<c>pageSize</c>"] Page size</param>
        /// <param name="order">["<c>order</c>"] Sort order</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoExchangeDerivative[]>> GetExchangeDerivativesAsync(int? page = null, int? pageSize = null, string? order = null, CancellationToken ct = default);

        /// <summary>
        /// Get exchange derivative details
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/derivatives-exchanges-id" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/derivatives/exchanges/{exchangeId}
        /// </para>
        /// </summary>
        /// <param name="exchangeId">Exchange id</param>
        /// <param name="includeTickers">["<c>include_tickers</c>"] Include tickers, 'all' or 'unexpired'</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoExchangeDerivative>> GetExchangeDerivativesDetailsAsync(string exchangeId, string? includeTickers = null, CancellationToken ct = default);

        /// <summary>
        /// Get exchange details
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/exchanges-id" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/exchanges/{exchangeId}
        /// </para>
        /// </summary>
        /// <param name="exchangeId">Id of the exchange</param>
        /// <param name="dexPairFormat">["<c>dex_pair_format</c>"] Dex pair formatting. Defaults to ContractAddress</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoExchangeDetails>> GetExchangeDetailsAsync(
            string exchangeId, 
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default);
        /// <summary>
        /// Get all exchanges 
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/exchanges-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/exchanges/list
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoListItem[]>> GetExchangeListAsync(CancellationToken ct = default);
        /// <summary>
        /// Get all exchanges
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/exchanges" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/exchanges
        /// </para>
        /// </summary>
        /// <param name="page">["<c>page</c>"] Page</param>
        /// <param name="pageSize">["<c>per_page</c>"] Page size</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoExchange[]>> GetExchangesAsync(int? page = null, int? pageSize = null, CancellationToken ct = default);
        /// <summary>
        /// Get exchange tickers
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/exchanges-id-tickers" /><br />
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
        Task<WebCallResult<CoinGeckoTickers>> GetExchangeTickersAsync(
            string exchangeId,
            IEnumerable<string>? assetIds = null,
            bool? includeExchangeLogo = null,
            int? page = null,
            bool? depth = null, 
            string? order = null,
            DexPairFormat? dexPairFormat = null,
            CancellationToken ct = default);
        /// <summary>
        /// Get volume chart data for an exchange, interval is determined automatically: 1 day -> 10 minutes, 7-14 days -> 1 hour, 30+ days -> 1 day
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/exchanges-id-volume-chart" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/exchanges/{exchangeId}/volume_chart
        /// </para>
        /// </summary>
        /// <param name="exchangeId">Exchange id</param>
        /// <param name="days">["<c>days</c>"] Days history</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoMarketChartValue[]>> GetExchangeVolumeHistoryAsync(string exchangeId, int days, CancellationToken ct = default);
        /// <summary>
        /// Get asset history info
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/coins-id-history" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/history
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="date">["<c>date</c>"] Date snapshot time</param>
        /// <param name="localization">["<c>localization</c>"] Include localization</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoAssetHistory>> GetAssetHistoryAsync(string assetId, DateTime date, bool? localization = null, CancellationToken ct = default);
        /// <summary>
        /// Get historical market data
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/coins-id-market-chart-range" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/market_chart/range
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="from">["<c>from</c>"] From date</param>
        /// <param name="to">["<c>to</c>"] To date</param>
        /// <param name="precision">["<c>precision</c>"] Decimal place for currency price value</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartAsync(string assetId, string quoteAsset, DateTime from, DateTime to, string? precision = null, CancellationToken ct = default);
        /// <summary>
        /// Get historical market data
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/coins-id-market-chart" /><br />
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
        Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartAsync(string assetId, string quoteAsset, int days, string? interval = null, string? precision = null, CancellationToken ct = default);
        /// <summary>
        /// Get historical market data by contract
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/contract-address-market-chart-range" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/contract/{contractAddress}/market_chart/range
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="from">["<c>from</c>"] From time</param>
        /// <param name="to">["<c>to</c>"] To time</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(string assetId, string contractAddress, string quoteAsset, DateTime from, DateTime to, CancellationToken ct = default);
        /// <summary>
        /// Get historical market data by contract
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/coins-categories-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/contract/{contractAddress}/market_chart
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="days">["<c>days</c>"] Days back</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(string assetId, string contractAddress, string quoteAsset, int days, CancellationToken ct = default);
        /// <summary>
        /// Get market data categories
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/coins-categories-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/categories
        /// </para>
        /// </summary>
        /// <param name="order">["<c>order</c>"] Sorting</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoMarketDataCategory[]>> GetMarketDataCategoriesAsync(string? order = null, CancellationToken ct = default);
        /// <summary>
        /// Get coins market data
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/coins-markets" /><br />
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
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoMarket[]>> GetMarketsAsync(
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
            CancellationToken ct = default);

        /// <summary>
        /// Get Open/High/Low/Close data, interval is determined automatically: 1-2 days -> 30 minutes, 3-30 days -> 4 hours, 31+ days -> 4 days
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/coins-id-ohlc" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/coins/{assetId}/ohlc
        /// </para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="quoteAsset">["<c>vs_currency</c>"] Quote asset</param>
        /// <param name="days">["<c>days</c>"] Days back</param>
        /// <param name="precision">["<c>precision</c>"] Decimal place for currency price value</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoOhlc[]>> GetOhlcAsync(string assetId, string quoteAsset, int days, string? precision = null, CancellationToken ct = default);

        /// <summary>
        /// Get prices for specific assets
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/simple-price" /><br />
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
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<Dictionary<string, Dictionary<string, decimal?>>>> GetPricesAsync(
            IEnumerable<string> ids,
            IEnumerable<string> quoteAssets,
            IEnumerable<string>? symbols = null,
            bool? includeMarketCap = false, 
            bool? include24hrVolume = false, 
            bool? include24hrChange = false, 
            bool? includeLastUpdatedAt = false,
            string? precision = null,
            CancellationToken ct = default);

        /// <summary>
        /// Get list of quote assets
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/simple-supported-currencies" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/simple/supported_vs_currencies
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<string[]>> GetQuoteAssetsAsync(CancellationToken ct = default);
        /// <summary>
        /// Get tickers for an asset
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/coins-id-tickers" /><br />
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
        Task<WebCallResult<CoinGeckoTickers>> GetTickersAsync(
            string assetId,
            IEnumerable<string>? exchangeIds = null,
            bool? includeExchangeLogo = null,
            int? page = null,
            string? order = null,
            bool? depth = null, 
            DexPairFormat? dexPairFormat = null, 
            CancellationToken ct = default);
        /// <summary>
        /// Get prices by token contract addresses
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/simple-token-price" /><br />
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
        Task<WebCallResult<Dictionary<string, Dictionary<string, decimal?>>>> GetTokenPricesAsync(string platformId, IEnumerable<string> contractAddresses, IEnumerable<string> quoteAssets, bool? includeMarketCap = false, bool? include24hrVolume = false, bool? include24hrChange = false, bool? includeLastUpdatedAt = false, string? precision = null, CancellationToken ct = default);
        /// <summary>
        /// Ping the server
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/ping-server" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/ping
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<string>> PingAsync(CancellationToken ct = default);
        /// <summary>
        /// Get global crypto data
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/crypto-global" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/global
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoGlobalData>> GetGlobalDataAsync(CancellationToken ct = default);
        /// <summary>
        /// Get global defi crypto data
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/global-defi" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/global/decentralized_finance_defi
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoGlobalDefiData>> GetGlobalDefiDataAsync(CancellationToken ct = default);

        /// <summary>
        /// Get list of nfts
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/nfts-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/nfts/list
        /// </para>
        /// </summary>
        /// <param name="order">["<c>order</c>"] Sort</param>
        /// <param name="page">["<c>page</c>"] Page</param>
        /// <param name="pageSize">["<c>per_page</c>"] Page size</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoNft[]>> GetNftsAsync(string? order = null, int? page = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Get details on an NFT
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/nfts-id" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/nfts/{id}
        /// </para>
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoNftDetails>> GetNftAsync(string id, CancellationToken ct = default);

        /// <summary>
        /// Get nft info by contract address
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/nfts-contract-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/nfts/{platformId}/contract/{contractAddress}
        /// </para>
        /// </summary>
        /// <param name="platformId">Platform id</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoNftDetails>> GetNftByContractAddressAsync(string platformId, string contractAddress, CancellationToken ct = default);

        /// <summary>
        /// Search for assets, exchanges, categories or nfts
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/search-data" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/search
        /// </para>
        /// </summary>
        /// <param name="query">["<c>query</c>"] Search query</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoSearchResult>> SearchAsync(string query, CancellationToken ct = default);

        /// <summary>
        /// Get trending searches
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/v3.0.1/reference/trending-search" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/search/trending
        /// </para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoTrendingSearch>> GetTrendingSearchesAsync(CancellationToken ct = default);

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
        Task<WebCallResult<CoinGeckoCompanyHolding>> GetCompanyHoldingsAsync(string asset, CancellationToken ct = default);

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
        Task<WebCallResult<CoinGeckoApiUsage>> GetApiUsageAsync(CancellationToken ct = default);
    }
}
