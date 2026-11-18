using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Testing;
using NUnit.Framework;
using System.Threading.Tasks;
using CoinGecko.Net.Clients;
using CoinGecko.Net.Enums;
using System;

namespace CoinGecko.Net.UnitTests
{
    [TestFixture]
    public class RestRequestTests
    {
        [Test]
        public async Task ValidateAuthCalls()
        {
            var client = new CoinGeckoRestClient(opts =>
            {
                opts.AutoTimestamp = false;
                opts.RateLimiterEnabled = false;
                opts.ApiCredentials = new CoinGeckoCredentials("123");
            });
            var tester = new RestRequestValidator<CoinGeckoRestClient>(client, "Endpoints", "https://pro-api.coingecko.com", IsAuthenticated);
            await tester.ValidateAsync(client => client.Api.GetApiUsageAsync(), "GetApiUsage");
            await tester.ValidateAsync(client => client.Api.GetDerivativesExchangesListAsync(), "GetDerivativesExchangesList");
            await tester.ValidateAsync(client => client.Api.GetExchangeDerivativesAsync(page: 2, pageSize: 5), "GetExchangeDerivatives");
            await tester.ValidateAsync(client => client.Api.GetTokenPricesAsync("ethereum", ["0xdac17f958d2ee523a2206206994597c13d831ec7"], ["usd"]), "GetTokenPrices", skipResponseValidation: true);
            await tester.ValidateAsync(client => client.Api.GetNftByContractAddressAsync("ethereum", "0xbd3531da5cf5857e7cfaa92426877b022e612cf8"), "GetNftByContractAddress");
            await tester.ValidateAsync(client => client.Api.GetTrendingSearchesAsync([TrendingSearchesShowMax.Coins]), "GetTrendingSearchesPro");
            await tester.ValidateAsync(client => client.Api.GetMarketChartAsync("ethereum", "usd", 30, interval: MarketChartInterval.Daily), "GetAssetMarketChart");
            await tester.ValidateAsync(client => client.Api.GetMarketChartFromContractAsync("ethereum", "0xdac17f958d2ee523a2206206994597c13d831ec7", "usd", new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 2, 1, 0, 0, 0, DateTimeKind.Utc), interval: MarketChartInterval.Daily), "GetContractMarketChartRange");
            await tester.ValidateAsync(client => client.Api.GetTopGainersAndLosersAsync("usd", duration: TopGainersAndLosersDuration.Hours1), "GetTopGainersAndLosers");
            await tester.ValidateAsync(client => client.Api.GetOhlcRangeAsync("bitcoin", "usd", new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc), OhlcInterval.Daily), "GetOhlcRange");
            await tester.ValidateAsync(client => client.Api.GetCirculatingSupplyChartAsync("bitcoin", "1", interval: SupplyChartInterval.Minutes5), "GetCirculatingSupplyChart");
            await tester.ValidateAsync(client => client.Api.GetCirculatingSupplyChartRangeAsync("bitcoin", new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)), "GetCirculatingSupplyChartRange");
            await tester.ValidateAsync(client => client.Api.GetTotalSupplyChartAsync("bitcoin", "1", interval: TotalSupplyChartInterval.Daily), "GetTotalSupplyChart");
            await tester.ValidateAsync(client => client.Api.GetTotalSupplyChartRangeAsync("bitcoin", new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)), "GetTotalSupplyChartRange");
            await tester.ValidateAsync(client => client.Api.GetSupplyBreakdownAsync("uniswap"), "GetSupplyBreakdown");
            await tester.ValidateAsync(client => client.Api.GetRecentlyAddedAssetsAsync(), "GetRecentlyAddedAssets");
            await tester.ValidateAsync(client => client.Api.GetTokenListAsync("ethereum"), "GetTokenList");
            await tester.ValidateAsync(client => client.Api.GetRwaMarketsAsync(assetType: RwaAssetType.Stock), "GetRwaMarkets");
            await tester.ValidateAsync(client => client.Api.GetRwaDetailsAsync("gold", sparkline: true), "GetRwaDetails");
            await tester.ValidateAsync(client => client.Api.GetRwaTickersAsync("gold", issuerIds: ["xstocks-ecosystem"]), "GetRwaTickers");
            await tester.ValidateAsync(client => client.Api.GetRwaMarketChartAsync("gold", days: "1"), "GetRwaMarketChart");
            await tester.ValidateAsync(client => client.Api.GetRwaIssuerDetailsAsync("xstocks-ecosystem"), "GetRwaIssuerDetails");
            await tester.ValidateAsync(client => client.Api.GetExchangeVolumeHistoryRangeAsync("binance", new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)), "GetExchangeVolumeHistoryRange");
            await tester.ValidateAsync(client => client.Api.GetDerivativeUnderlyingMarketsAsync(coinIds: ["bitcoin"]), "GetDerivativeUnderlyingMarkets");
            await tester.ValidateAsync(client => client.Api.GetTreasuryHoldingsAsync(TreasuryHoldingEntityType.Companies, "bitcoin", pageSize: 1), "GetTreasuryHoldings");
            await tester.ValidateAsync(client => client.Api.GetTreasuryHoldingsAsync(TreasuryHoldingEntityType.Governments, "bitcoin"), "GetGovernmentTreasuryHoldings");
            await tester.ValidateAsync(client => client.Api.GetTreasuryEntityHoldingsAsync("strategy", holdingAmountChange: [TreasuryHoldingChangePeriod.Days7]), "GetTreasuryEntityHoldings");
            await tester.ValidateAsync(client => client.Api.GetTreasuryHoldingsChartAsync("strategy", "bitcoin", "365", includeEmptyIntervals: true), "GetTreasuryHoldingsChart");
            await tester.ValidateAsync(client => client.Api.GetTreasuryTransactionsAsync("strategy", pageSize: 1), "GetTreasuryTransactions");
            await tester.ValidateAsync(client => client.Api.GetNftMarketsAsync(assetPlatformId: "sample"), "GetNftMarkets");
            await tester.ValidateAsync(client => client.Api.GetNftMarketChartAsync("pudgy-penguins", "1"), "GetNftMarketChart");
            await tester.ValidateAsync(client => client.Api.GetNftMarketChartByContractAddressAsync("ethereum", "0xBd3531dA5CF5857e7CfAA92426877b022e612cf8", "1"), "GetNftMarketChartByContractAddress");
            await tester.ValidateAsync(client => client.Api.GetNftTickersAsync("pudgy-penguins"), "GetNftTickers");
            await tester.ValidateAsync(client => client.Api.GetNewsAsync(page: 1), "GetNews");
            await tester.ValidateAsync(client => client.Api.GetInsightsAsync(page: 1, from: new DateTime(2026, 1, 1), to: new DateTime(2026, 1, 31)), "GetInsights");
            await tester.ValidateAsync(client => client.Api.GetGlobalMarketCapChartAsync("1", quoteAsset: "sample"), "GetGlobalMarketCapChart");
            await tester.ValidateAsync(client => client.Api.GetGlobalFearAndGreedChartAsync("1"), "GetGlobalFearAndGreedChart");
        }

        [TestCase(true, "https://api.coingecko.com", "x_cg_demo_api_key")]
        [TestCase(false, "https://pro-api.coingecko.com", "x_cg_pro_api_key")]
        public async Task ValidateRwaCalls(bool demoKey, string baseAddress, string apiKeyParameter)
        {
            var client = new CoinGeckoRestClient(opts =>
            {
                opts.AutoTimestamp = false;
                opts.ApiCredentials = new CoinGeckoCredentials("123", demoKey);
            });
            var tester = new RestRequestValidator<CoinGeckoRestClient>(client, "Endpoints", baseAddress, result => result.RequestUrl.Contains(apiKeyParameter));
            await tester.ValidateAsync(client => client.Api.GetRwasAsync(RwaAssetType.Commodity), "GetRwas");
            await tester.ValidateAsync(client => client.Api.GetRwaIssuersAsync(), "GetRwaIssuers");
        }

        [TestCase(true, "https://api.coingecko.com", "x_cg_demo_api_key", TreasuryEntityType.Government, "GetTreasuryEntitiesDemo")]
        [TestCase(false, "https://pro-api.coingecko.com", "x_cg_pro_api_key", TreasuryEntityType.Company, "GetTreasuryEntitiesPro")]
        public async Task ValidateDerivativeUnderlyingAssetsAndTreasuryEntities(
            bool demoKey, string baseAddress, string apiKeyParameter, TreasuryEntityType entityType, string entityFixture)
        {
            var client = new CoinGeckoRestClient(opts =>
            {
                opts.AutoTimestamp = false;
                opts.ApiCredentials = new CoinGeckoCredentials("123", demoKey);
            });
            var tester = new RestRequestValidator<CoinGeckoRestClient>(client, "Endpoints", baseAddress, result => result.RequestUrl.Contains(apiKeyParameter));
            await tester.ValidateAsync(client => client.Api.GetDerivativeUnderlyingAssetsAsync(DerivativeUnderlyingType.Rwa), "GetDerivativeUnderlyingAssets");
            await tester.ValidateAsync(client => client.Api.GetTreasuryEntitiesAsync(entityType, page: 2, pageSize: 10), entityFixture);
        }

        [Test]
        public async Task ValidatePublicCalls()
        {
            var client = new CoinGeckoRestClient(opts =>
            {
                opts.AutoTimestamp = false;
            });
            var tester = new RestRequestValidator<CoinGeckoRestClient>(client, "Endpoints", "https://api.coingecko.com", IsAuthenticated);
            await tester.ValidateAsync(client => client.DexApi.GetDexNetworksAsync(2), "GetDexNetworks");
            await tester.ValidateAsync(client => client.DexApi.SearchPoolsAsync("weth", page: 2), "SearchPools");
            await tester.ValidateAsync(client => client.Api.PingAsync(), "Ping", skipResponseValidation: true);
            await tester.ValidateAsync(client => client.Api.GetAssetsAsync(status: ListingStatus.Active), "GetAssets");
            await tester.ValidateAsync(client => client.Api.GetMarketsAsync("USDT", includeTokens: TokenSelection.All, includeRehypothecated: true, priceChangePercentages: [PriceChangePeriod.Hours1, PriceChangePeriod.Hours24]), "GetMarkets");
            await tester.ValidateAsync(client => client.Api.GetAssetDetailsAsync("ethereum", sparkline: true, includeCategoriesDetails: true), "GetAssetDetails");
            await tester.ValidateAsync(client => client.Api.GetTickersAsync("ethereum"), "GetTickers");
            await tester.ValidateAsync(client => client.Api.GetAssetHistoryAsync("ethereum", new DateTime(2025, 1, 1)), "GetAssetHistory");
            await tester.ValidateAsync(client => client.Api.GetMarketChartAsync("ethereum", "USD", DateTime.UtcNow, DateTime.UtcNow), "GetMarketChart");
            await tester.ValidateAsync(client => client.Api.GetOhlcAsync("ethereum", "USD", "max", interval: OhlcInterval.Daily), "GetOhlc");
            await tester.ValidateAsync(client => client.Api.GetPricesAsync(null, ["USD"], names: ["Ethereum"], includeTokens: TokenSelection.Top), "GetPrices", skipResponseValidation: true);
            await tester.ValidateAsync(client => client.Api.GetQuoteAssetsAsync(), "GetQuoteAssets");
            await tester.ValidateAsync(client => client.Api.GetAssetDetailsFromContractAsync("ethereum", "123"), "GetAssetDetailsFromContract");
            await tester.ValidateAsync(client => client.Api.GetMarketChartFromContractAsync("ethereum", "123", "USD", 30, interval: MarketChartInterval.Daily, precision: "4"), "GetMarketChartFromContract");
            await tester.ValidateAsync(client => client.Api.GetAssetPlatformsAsync(), "GetAssetPlatforms");
            await tester.ValidateAsync(client => client.Api.GetAssetCategoriesAsync(), "GetAssetCategories");
            await tester.ValidateAsync(client => client.Api.GetMarketDataCategoriesAsync(), "GetMarketDataCategories");
            await tester.ValidateAsync(client => client.Api.GetExchangesAsync(), "GetExchanges");
            await tester.ValidateAsync(client => client.Api.GetExchangeListAsync(status: ListingStatus.Active), "GetExchangeList");
            await tester.ValidateAsync(client => client.Api.GetExchangeDetailsAsync("gdax"), "GetExchangeDetails");
            await tester.ValidateAsync(client => client.Api.GetExchangeTickersAsync("gdax"), "GetExchangeTickers");
            await tester.ValidateAsync(client => client.Api.GetExchangeVolumeHistoryAsync("gdax", 1), "GetExchangeVolumeHistory");
            await tester.ValidateAsync(client => client.Api.GetDerivativesAsync(page: 2, pageSize: 100), "GetDerivatives");
            await tester.ValidateAsync(client => client.Api.GetExchangeDerivativesDetailsAsync("gdax"), "GetExchangeDerivativesDetails");
            await tester.ValidateAsync(client => client.Api.GetBtcExchangeRatesAsync(), "GetBtcExchangeRates");
            await tester.ValidateAsync(client => client.Api.GetGlobalDataAsync(), "GetGlobalData", nestedJsonProperty: "data");
            await tester.ValidateAsync(client => client.Api.GetGlobalDefiDataAsync(), "GetGlobalDefiData", nestedJsonProperty: "data");
            await tester.ValidateAsync(client => client.Api.GetNftsAsync(), "GetNfts");
            await tester.ValidateAsync(client => client.Api.GetNftAsync("pudgy-penguins"), "GetNft");
            await tester.ValidateAsync(client => client.Api.SearchAsync("x"), "Search");
            await tester.ValidateAsync(client => client.Api.GetCompanyHoldingsAsync("ethereum"), "GetCompanyHoldings");
        }

        [Test]
        public async Task ValidateAuthenticatedDexCalls()
        {
            using var client = new CoinGeckoRestClient(opts =>
            {
                opts.AutoTimestamp = false;
                opts.RateLimiterEnabled = false;
                opts.ApiCredentials = new CoinGeckoCredentials("123");
            });
            var tester = new RestRequestValidator<CoinGeckoRestClient>(client, "Endpoints", "https://pro-api.coingecko.com", IsAuthenticated);
            await tester.ValidateAsync(client => client.DexApi.GetPoolAsync("eth", "0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640", include: [PoolInclude.BaseToken]), "GetPool");
            await tester.ValidateAsync(client => client.DexApi.GetTrendingPoolsAsync(include: [TrendingPoolsInclude.BaseToken]), "GetTrendingPools");
            await tester.ValidateAsync(client => client.DexApi.GetTrendingPoolsByNetworkAsync("eth", include: [PoolInclude.BaseToken]), "GetTrendingPoolsByNetwork");
            await tester.ValidateAsync(client => client.DexApi.GetTopPoolsByNetworkAsync("eth", include: [PoolInclude.BaseToken]), "GetTopPoolsByNetwork");
            await tester.ValidateAsync(client => client.DexApi.GetTopPoolsByDexAsync("eth", "sushiswap", include: [PoolInclude.BaseToken]), "GetTopPoolsByDex");
            await tester.ValidateAsync(client => client.DexApi.GetFilteredPoolsAsync(networks: ["sample"]), "GetFilteredPools");
            await tester.ValidateAsync(client => client.DexApi.GetTrendingPoolSearchesAsync(include: [TrendingPoolsInclude.BaseToken]), "GetTrendingPoolSearches");
            await tester.ValidateAsync(client => client.DexApi.GetTopPoolsByTokenAddressAsync("eth", "0xdac17f958d2ee523a2206206994597c13d831ec7", include: [PoolInclude.BaseToken]), "GetTopPoolsByTokenAddress");
            await tester.ValidateAsync(client => client.DexApi.GetTokenAsync("solana", "8J69rbLTzWWgUJziFY8jeu5tDwEPBwUz4pKBMr5rpump", include: TokenInclude.TopPools), "GetToken");
            await tester.ValidateAsync(client => client.DexApi.GetTokensAsync("solana", ["6p6xgHyF7AeE6TZkSmFsko444wqoP15icUSqi2jfGiPN,2g4LS3y2myPe6vj9wTvoBE1wKqxvhnZPoZA9QU9upump"], include: TokenInclude.TopPools), "GetTokens");
            await tester.ValidateAsync(client => client.DexApi.GetTokensAcrossNetworksAsync(["solana:6p6xgHyF7AeE6TZkSmFsko444wqoP15icUSqi2jfGiPN,solana:2g4LS3y2myPe6vj9wTvoBE1wKqxvhnZPoZA9QU9upump"], include: TokenInclude.TopPools), "GetTokensAcrossNetworks");
            await tester.ValidateAsync(client => client.DexApi.GetTokenInfoAsync("solana", "Dfh5DzRgSvvCFDoYc2ciTkMrbDfRKybA4SoFbPmApump"), "GetTokenInfo");
            await tester.ValidateAsync(client => client.DexApi.GetPoolTokenInfoAsync("solana", "8WwcNqdZjCY5Pt7AkhupAFknV2txca9sq6YBkGzLbvdt", include: PoolTokenInfoInclude.Pool), "GetPoolTokenInfo");
            await tester.ValidateAsync(client => client.DexApi.GetRecentlyUpdatedTokensAsync(include: RecentlyUpdatedTokensInclude.Network), "GetRecentlyUpdatedTokens");
            await tester.ValidateAsync(client => client.DexApi.GetTopTokenTradersAsync("solana", "Dfh5DzRgSvvCFDoYc2ciTkMrbDfRKybA4SoFbPmApump", traders: "10"), "GetTopTokenTraders");
            await tester.ValidateAsync(client => client.DexApi.GetTopTokenHoldersAsync("solana", "Dfh5DzRgSvvCFDoYc2ciTkMrbDfRKybA4SoFbPmApump", holders: "10"), "GetTopTokenHolders");
            await tester.ValidateAsync(client => client.DexApi.GetTokenHoldersChartAsync("solana", "Dfh5DzRgSvvCFDoYc2ciTkMrbDfRKybA4SoFbPmApump", days: "7"), "GetTokenHoldersChart");
            await tester.ValidateAsync(client => client.DexApi.GetTokenOhlcvAsync("solana", "So11111111111111111111111111111111111111112", DexOhlcvTimeframe.Day, includeEmptyIntervals: true, includeInactiveSource: true), "GetTokenOhlcv");
            await tester.ValidateAsync(client => client.DexApi.GetPoolOhlcvAsync("eth", "0x06da0fd433c1a5d7a4faa01111c044910a184553", DexOhlcvTimeframe.Day, aggregate: 1), "GetPoolOhlcv");
            await tester.ValidateAsync(client => client.DexApi.GetPoolTradesAsync("eth", "0x06da0fd433c1a5d7a4faa01111c044910a184553", tradeVolumeInUsdGreaterThan: 1m), "GetPoolTrades");
            await tester.ValidateAsync(client => client.DexApi.GetPoolTradesRangeAsync("eth", "0x06da0fd433c1a5d7a4faa01111c044910a184553", new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc), tradeVolumeInUsdGreaterThan: 1m), "GetPoolTradesRange");
            await tester.ValidateAsync(client => client.DexApi.GetPoolLiquidityEventsAsync("solana", "G9YxfMcZQiW7EmsU1Asxuomcm5iQrBDKpbozuTM2iwne", kind: PoolLiquidityEventsKind.Add), "GetPoolLiquidityEvents");
            await tester.ValidateAsync(client => client.DexApi.GetTokenTradesAsync("eth", "0xdac17f958d2ee523a2206206994597c13d831ec7", tradeVolumeInUsdGreaterThan: 1m), "GetTokenTrades");
            await tester.ValidateAsync(client => client.DexApi.GetTokenTradesRangeAsync("eth", "0xdac17f958d2ee523a2206206994597c13d831ec7", new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc), tradeVolumeInUsdGreaterThan: 1m), "GetTokenTradesRange");
            await tester.ValidateAsync(client => client.DexApi.GetWalletTokenBalancesAsync("0x9642b23ed1e01df1092b92641051881a322f5d4e", ["eth,base"], sort: WalletTokenBalancesSort.ValueUsdDesc), "GetWalletTokenBalances");
            await tester.ValidateAsync(client => client.DexApi.GetWalletTokenTransfersAsync("eth", "0x9642b23ed1e01df1092b92641051881a322f5d4e", token: "sample"), "GetWalletTokenTransfers");
            await tester.ValidateAsync(client => client.DexApi.GetWalletTradesAsync("eth", "0x7942262a7a5637e6eb0eec9b91b55ec232141f87", token: "sample"), "GetWalletTrades");
            await tester.ValidateAsync(client => client.DexApi.GetWalletPnlAsync("0x4b3f1048c55faa0c0873e249e541139360501f2a", ["eth,base"], sort: WalletPnlSort.RealizedPnlUsdDesc), "GetWalletPnl");
            await tester.ValidateAsync(client => client.DexApi.GetPoolCategoriesAsync(page: 1), "GetPoolCategories");
            await tester.ValidateAsync(client => client.DexApi.GetPoolsByCategoryAsync("pump-fun", include: [TrendingPoolsInclude.BaseToken]), "GetPoolsByCategory");
            await tester.ValidateAsync(client => client.DexApi.GetNewPoolsAsync(include: [TrendingPoolsInclude.BaseToken]), "GetNewPools");
            await tester.ValidateAsync(client => client.DexApi.GetNewPoolsByNetworkAsync("eth", include: [PoolInclude.BaseToken]), "GetNewPoolsByNetwork");
            await tester.ValidateAsync(client => client.DexApi.GetPoolsAsync("eth", ["0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640"], include: [PoolInclude.BaseToken]), "GetPools");
            await tester.ValidateAsync(client => client.DexApi.GetOnchainTokenPricesAsync("eth", ["0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2"], includeMarketCap: true), "GetOnchainTokenPrices");
            await tester.ValidateAsync(client => client.DexApi.GetOnchainTokenPricesAcrossNetworksAsync(["eth:0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2,solana:6NwarBvDkXhByqVp2Qkq5i9XbtA2B3Bwe8SWGu9vpump"], includeMarketCap: true), "GetOnchainTokenPricesAcrossNetworks");
            await tester.ValidateAsync(client => client.DexApi.GetDexesAsync("eth", page: 1), "GetDexes");
        }

        private bool IsAuthenticated(IHttpResult result) => result.RequestUrl.Contains("x_cg_pro_api_key");
    }
}
