
using CoinGecko.Net.Clients;

// REST
var restClient = new CoinGeckoRestClient();
var markets = await restClient.Api.GetMarketsAsync("usd");
if (!markets.Success)
{
    Console.WriteLine($"Market request failed: {markets.Error}");
    return;
}

var ethMarket = markets.Data.Single(d => d.Name == "Ethereum");
Console.WriteLine($"Rest client ticker price for ETHUSDT: {ethMarket.CurrentPrice}");

var networks = await restClient.DexApi.GetDexNetworksAsync();
if (!networks.Success)
{
    Console.WriteLine($"DEX networks request failed: {networks.Error}");
    return;
}

Console.WriteLine($"DEX networks returned: {networks.Data.Data.Length}");

Console.ReadLine();
