using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Testing;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using CryptoExchange.Net.Authentication;
using System.Linq;
using CoinGecko.Net.Clients;
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
                opts.ApiCredentials = new Objects.CoinGeckoApiCredentials("123");
            });
            var tester = new RestRequestValidator<CoinGeckoRestClient>(client, "Endpoints", "https://pro-api.coingecko.com", IsAuthenticated);
            await tester.ValidateAsync(client => client.Api.GetApiUsageAsync(), "GetApiUsage");
        }

        [Test]
        public async Task ValidatePublicCalls()
        {
            var client = new CoinGeckoRestClient(opts =>
            {
                opts.AutoTimestamp = false;
            });
            var tester = new RestRequestValidator<CoinGeckoRestClient>(client, "Endpoints", "https://api.coingecko.com", IsAuthenticated);
            await tester.ValidateAsync(client => client.Api.PingAsync(), "Ping", skipResponseValidation: true);
            await tester.ValidateAsync(client => client.Api.GetAssetsAsync(), "GetAssets");
            await tester.ValidateAsync(client => client.Api.GetMarketsAsync("USDT"), "GetMarkets");
            await tester.ValidateAsync(client => client.Api.GetAssetDetailsAsync("ethereum"), "GetAssetDetails");
            await tester.ValidateAsync(client => client.Api.GetTickersAsync("ethereum"), "GetTickers");
            await tester.ValidateAsync(client => client.Api.GetAssetHistoryAsync("ethereum", DateTime.UtcNow), "GetAssetHistory");
            await tester.ValidateAsync(client => client.Api.GetMarketChartAsync("ethereum", "USD", DateTime.UtcNow, DateTime.UtcNow), "GetMarketChart");
            await tester.ValidateAsync(client => client.Api.GetOhlcAsync("ethereum", "USD", 30), "GetOhlc");
            await tester.ValidateAsync(client => client.Api.GetPricesAsync(["ethereum"], ["USD"]), "GetPrices", skipResponseValidation: true);
            await tester.ValidateAsync(client => client.Api.GetQuoteAssetsAsync(), "GetQuoteAssets");
            await tester.ValidateAsync(client => client.Api.GetAssetDetailsFromContractAsync("ethereum", "123"), "GetAssetDetailsFromContract");
            await tester.ValidateAsync(client => client.Api.GetMarketChartFromContractAsync("ethereum", "123", "USD", 30), "GetMarketChartFromContract");
            await tester.ValidateAsync(client => client.Api.GetAssetPlatformsAsync(), "GetAssetPlatforms");
            await tester.ValidateAsync(client => client.Api.GetAssetCategoriesAsync(), "GetAssetCategories");
            await tester.ValidateAsync(client => client.Api.GetMarketDataCategoriesAsync(), "GetMarketDataCategories");
            await tester.ValidateAsync(client => client.Api.GetExchangesAsync(), "GetExchanges");
            await tester.ValidateAsync(client => client.Api.GetExchangeListAsync(), "GetExchangeList");
            await tester.ValidateAsync(client => client.Api.GetExchangeDetailsAsync("gdax"), "GetExchangeDetails");
            await tester.ValidateAsync(client => client.Api.GetExchangeTickersAsync("gdax"), "GetExchangeTickers");
            await tester.ValidateAsync(client => client.Api.GetExchangeVolumeHistoryAsync("gdax", 1), "GetExchangeVolumeHistory");
            await tester.ValidateAsync(client => client.Api.GetDerivativesAsync(), "GetDerivatives");
            await tester.ValidateAsync(client => client.Api.GetExchangeDerivativesDetailsAsync("gdax"), "GetExchangeDerivativesDetails");
            await tester.ValidateAsync(client => client.Api.GetBtcExchangeRatesAsync(), "GetBtcExchangeRates");
            await tester.ValidateAsync(client => client.Api.GetGlobalDataAsync(), "GetGlobalData", nestedJsonProperty: "data");
            await tester.ValidateAsync(client => client.Api.GetGlobalDefiDataAsync(), "GetGlobalDefiData", nestedJsonProperty: "data");
            await tester.ValidateAsync(client => client.Api.GetNftsAsync(), "GetNfts");
            await tester.ValidateAsync(client => client.Api.GetNftAsync("pudgy-penguins"), "GetNft");
            await tester.ValidateAsync(client => client.Api.SearchAsync("x"), "Search");
            await tester.ValidateAsync(client => client.Api.GetCompanyHoldingsAsync("ethereum"), "GetCompanyHoldings");
        }


        private bool IsAuthenticated(WebCallResult result) => result.RequestUrl.Contains("x_cg_pro_api_key");
    }
}
