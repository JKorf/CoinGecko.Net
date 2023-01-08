using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System;
using CoinGecko.Net.Objects.Models;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Interfaces;

namespace CoinGecko.Net.Interfaces
{
    /// <summary>
    /// CoinGecko API endpoints
    /// </summary>
    public interface ICoinGeckoClientApi
    {
        /// <summary>
        /// The factory for creating requests. Used for unit testing
        /// </summary>
        IRequestFactory RequestFactory { get; set; }

        /// <summary>
        /// Get asset categories
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/categories/get_coins_categories" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoCategory>>> GetAssetCategoriesAsync(CancellationToken ct = default);
        /// <summary>
        /// Get asset details
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id_" /></para>
        /// </summary>
        /// <param name="assetId">The asset id</param>
        /// <param name="localization">Include localization</param>
        /// <param name="tickers">Include tickers</param>
        /// <param name="marketData">Include market data</param>
        /// <param name="communityData">Include community data</param>
        /// <param name="developerData">Include developer data</param>
        /// <param name="sparkline">Include sparkline</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoAssetDetails>> GetAssetDetailsAsync(string assetId, bool? localization = null, bool? tickers = null, bool? marketData = null, bool? communityData = null, bool? developerData = null, bool? sparkline = null, CancellationToken ct = default);
        /// <summary>
        /// Get asset details by contract address
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/contract/get_coins__id__contract__contract_address_" /></para>
        /// </summary>
        /// <param name="platformId">Id of the platform</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoAssetDetails>> GetAssetDetailsFromContractAsync(string platformId, string contractAddress, CancellationToken ct = default);
        /// <summary>
        /// Get asset platforms list
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/asset_platforms/get_asset_platforms" /></para>
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoAssetPlatform>>> GetAssetPlatformsAsync(string? filter = null, CancellationToken ct = default);
        /// <summary>
        /// Get list of all assets
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins_list" /></para>
        /// </summary>
        /// <param name="includePlatform">Include platform contract address</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoAsset>>> GetAssetsAsync(bool? includePlatform = null, CancellationToken ct = default);
        /// <summary>
        /// Get BTC-to-Currency exchange rates
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchange_rates/get_exchange_rates" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoExchangeRates>> GetBtcExchangeRatesAsync(CancellationToken ct = default);
        /// <summary>
        /// Get list of derivative tickers
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/derivatives/get_derivatives" /></para>
        /// </summary>
        /// <param name="includeTickers">Include tickers for `all` or only `unexpired`</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoDerivative>>> GetDerivativesAsync(string? includeTickers = null, CancellationToken ct = default);
        /// <summary>
        /// List all derivatives exchanges name and identifier
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/derivatives/get_derivatives_exchanges_list" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoListItem>>> GetDerivativesExchangesListAsync(CancellationToken ct = default);
        /// <summary>
        /// Get all derivatives exchanges
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/derivatives/get_derivatives_exchanges" /></para>
        /// </summary>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="order">Sort order</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoExchangeDerivative>>> GetExchangeDerivativesAsync(int? page = null, int? pageSize = null, string? order = null, CancellationToken ct = default);
        /// <summary>
        /// Get exchange details
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges__id_" /></para>
        /// </summary>
        /// <param name="exchangeId">Id of the exchange</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoExchangeDetails>> GetExchangeDetailsAsync(string exchangeId, CancellationToken ct = default);
        /// <summary>
        /// Get all exchange markets 
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges_list" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoListItem>>> GetExchangeMarketsAsync(CancellationToken ct = default);
        /// <summary>
        /// Get all exchanges
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges" /></para>
        /// </summary>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoExchange>>> GetExchangesAsync(int? page = null, int? pageSize = null, CancellationToken ct = default);
        /// <summary>
        /// Get exchange tickers
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges__id__tickers" /></para>
        /// </summary>
        /// <param name="exchangeId">Exchange id</param>
        /// <param name="assetIds">Asset ids filter</param>
        /// <param name="includeExchangeLogo">Include exchange logo</param>
        /// <param name="page">Page</param>
        /// <param name="depth">Include orderbook 2% depth</param>
        /// <param name="order">Sort</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoTickers>> GetExchangeTickersAsync(string exchangeId, IEnumerable<string>? assetIds = null, bool? includeExchangeLogo = null, int? page = null, bool? depth = null, string? order = null, CancellationToken ct = default);
        /// <summary>
        /// Get volume chart data for an exchange
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges__id__volume_chart" /></para>
        /// </summary>
        /// <param name="exchangeId">Exchange id</param>
        /// <param name="days">Days history</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoMarketChartValue>>> GetExchangeVolumeHistoryAsync(string exchangeId, int days, CancellationToken ct = default);
        /// <summary>
        /// Get asset history info
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__history" /></para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="date">Date snapshot time</param>
        /// <param name="localization">Include localization</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoAssetHistory>> GetAssetHistoryAsync(string assetId, DateTime date, bool? localization = null, CancellationToken ct = default);
        /// <summary>
        /// Get historical market data
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__market_chart_range" /></para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="quoteAsset">Quote asset</param>
        /// <param name="from">From date</param>
        /// <param name="to">To date</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartAsync(string assetId, string quoteAsset, DateTime from, DateTime to, CancellationToken ct = default);
        /// <summary>
        /// Get historical market data
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__market_chart" /></para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="quoteAsset">Quote asset</param>
        /// <param name="days">Days back</param>
        /// <param name="interval">Data interval</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartAsync(string assetId, string quoteAsset, int days, string? interval = null, CancellationToken ct = default);
        /// <summary>
        /// Get historical market data by contract
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/contract/get_coins__id__contract__contract_address__market_chart_range" /></para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="quoteAsset">Quote asset</param>
        /// <param name="from">From time</param>
        /// <param name="to">To time</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(string assetId, string contractAddress, string quoteAsset, DateTime from, DateTime to, CancellationToken ct = default);
        /// <summary>
        /// Get historical market data by contract
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/contract/get_coins__id__contract__contract_address__market_chart_" /></para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="quoteAsset">Quote asset</param>
        /// <param name="days">Days back</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(string assetId, string contractAddress, string quoteAsset, int days, CancellationToken ct = default);
        /// <summary>
        /// Get market data categories
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/categories/get_coins_categories" /></para>
        /// </summary>
        /// <param name="order">Sorting</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoMarketDataCategory>>> GetMarketDataCategoriesAsync(string? order = null, CancellationToken ct = default);
        /// <summary>
        /// Get coins market data
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins_markets" /></para>
        /// </summary>
        /// <param name="quoteAsset">Quote asset</param>
        /// <param name="assetIds">Asset ids</param>
        /// <param name="category">Category filter</param>
        /// <param name="order">Sorting</param>
        /// <param name="page">Page</param>
        /// <param name="pageSize">PageSize</param>
        /// <param name="sparkline">Include sparkline</param>
        /// <param name="priceChangePercentages">Include price change percentages</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoMarket>>> GetMarketsAsync(string quoteAsset, IEnumerable<string>? assetIds = null, string? category = null, string? order = null, int? page = null, int? pageSize = null, bool? sparkline = null, IEnumerable<string>? priceChangePercentages = null, CancellationToken ct = default);
        /// <summary>
        /// Get Open/High/Low/Close data
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__ohlc" /></para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="quoteAsset">Quote asset</param>
        /// <param name="days">Days back</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoOhlc>>> GetOhlcAsync(string assetId, string quoteAsset, int days, CancellationToken ct = default);
        /// <summary>
        /// Get prices for specific assets
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/simple/get_simple_price" /></para>
        /// </summary>
        /// <param name="ids">Asset ids to get data for</param>
        /// <param name="quoteAssets">Quote assets</param>
        /// <param name="includeMarketCap">Include market cap</param>
        /// <param name="include24hrVolume">Include 24h volume</param>
        /// <param name="include24hrChange">Include 24h change</param>
        /// <param name="includeLastUpdatedAt">Include last updated at</param>
        /// <param name="precision">Precision</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<Dictionary<string, Dictionary<string, decimal?>>>> GetPricesAsync(IEnumerable<string> ids, IEnumerable<string> quoteAssets, bool? includeMarketCap = false, bool? include24hrVolume = false, bool? include24hrChange = false, bool? includeLastUpdatedAt = false, string? precision = null, CancellationToken ct = default);
        /// <summary>
        /// Get list of quote assets
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/simple/get_simple_supported_vs_currencies" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<string>>> GetQuoteAssetsAsync(CancellationToken ct = default);
        /// <summary>
        /// Get tickers for an asset
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__tickers" /></para>
        /// </summary>
        /// <param name="assetId">Asset id</param>
        /// <param name="exchangeIds">Exchange ids</param>
        /// <param name="includeExchangeLogo">Include exchange logo</param>
        /// <param name="page">Page</param>
        /// <param name="order">Sorting</param>
        /// <param name="depth">Include 2% order book depth info</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoTickers>> GetTickersAsync(string assetId, IEnumerable<string>? exchangeIds = null, bool? includeExchangeLogo = null, int? page = null, string? order = null, bool? depth = null, CancellationToken ct = default);
        /// <summary>
        /// Get prices by token contract addresses
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/simple/get_simple_token_price__id_" /></para>
        /// </summary>
        /// <param name="platformId">Platform id</param>
        /// <param name="contractAddresses">Contract addresses</param>
        /// <param name="quoteAssets">Quote assets</param>
        /// <param name="includeMarketCap">Include market cap</param>
        /// <param name="include24hrVolume">Include 24h volume</param>
        /// <param name="include24hrChange">Include 24h change</param>
        /// <param name="includeLastUpdatedAt">Include last updated at</param>
        /// <param name="precision">Precision</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<Dictionary<string, Dictionary<string, decimal?>>>> GetTokenPricesAsync(string platformId, IEnumerable<string> contractAddresses, IEnumerable<string> quoteAssets, bool? includeMarketCap = false, bool? include24hrVolume = false, bool? include24hrChange = false, bool? includeLastUpdatedAt = false, string? precision = null, CancellationToken ct = default);
        /// <summary>
        /// Ping the server
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/ping/get_ping" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<string>> PingAsync(CancellationToken ct = default);
        /// <summary>
        /// Get global crypto data
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/global/get_global" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoGlobalData>> GetGlobalDataAsync(CancellationToken ct = default);
        /// <summary>
        /// Get global defi crypto data
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/global/get_global_decentralized_finance_defi" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoGlobalDefiData>> GetGlobalDefiDataAsync(CancellationToken ct = default);

        /// <summary>
        /// Get list of nfts
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/nfts%20(beta)/get_nfts_list" /></para>
        /// </summary>
        /// <param name="order">Sort</param>
        /// <param name="assetPlatformId">Platform id</param>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoNft>>> GetNftsAsync(string? order = null, string? assetPlatformId = null, int? page = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Get details on an NFT
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/nfts%20(beta)/get_nfts__id_" /></para>
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoNftDetails>> GetNftAsync(string id, CancellationToken ct = default);

        /// <summary>
        /// Get nft info by contract address
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/nfts%20(beta)/get_nfts__asset_platform_id__contract__contract_address_" /></para>
        /// </summary>
        /// <param name="platformId">Platform id</param>
        /// <param name="contractAddress">Contract address</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoNftDetails>> GetNftByContractAddressAsync(string platformId, string contractAddress, CancellationToken ct = default);

        /// <summary>
        /// Search for assets, exchanges, categories or nfts
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/search/get_search" /></para>
        /// </summary>
        /// <param name="query">Search query</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoSearchResult>> SearchAsync(string query, CancellationToken ct = default);

        /// <summary>
        /// Get trending searches
        /// <para><a href="https://www.coingecko.com/en/api/documentation?deepLinking=1#/trending/get_search_trending" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<CoinGeckoTrendingSearch>> GetTrendingSearchesAsync(CancellationToken ct = default);

        /// <summary>
        /// Get indexes
        /// </summary>
        /// <param name="page">Page</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoIndex>>> GetIndexesAsync(int? page = null, int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Get indexes list
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<CoinGeckoListItem>>> GetIndexesListAsync(CancellationToken ct = default);
    }
}
