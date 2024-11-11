using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using CryptoExchange.Net.Interfaces;
using CoinGecko.Net.Clients;
using CoinGecko.Net.Objects;
using Bybit.Net.UnitTests;

namespace CoinGecko.Net.UnitTests
{
    [TestFixture]
    public class JsonTests
    {
        private JsonToObjectComparer<CoinGeckoRestClient> _comparer = new JsonToObjectComparer<CoinGeckoRestClient>((json) => TestHelpers.CreateResponseClient(json, x =>
        {
            x.ApiCredentials = new CoinGeckoApiCredentials("123");
            x.ApiOptions.OutputOriginalData = true;
        },
            System.Net.HttpStatusCode.OK));

        [Test]
        public async Task ValidateCalls()
        {
            await _comparer.ProcessSubject("", c => c.Api,
                useNestedJsonPropertyForCompare: new Dictionary<string, string>
                {
                    { "GetGlobalDataAsync", "data" },
                    { "GetGlobalDefiDataAsync", "data" },
                },
                ignoreProperties: new Dictionary<string, List<string>>
                {
                    { "SearchAsync", new List<string> { "icos" } },
                    { "GetTrendingSearchesAsync", new List<string> { "exchanges" } }
                }
                );
        }

    }
}
