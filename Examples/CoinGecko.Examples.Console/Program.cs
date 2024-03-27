
using CoinGecko.Net.Clients;

// REST
var restClient = new CoinGeckoRestClient();
var markets = await restClient.Api.GetMarketsAsync("usd");
var ethMarket = markets.Data.Single(d => d.Name == "Ethereum");
Console.WriteLine($"Rest client ticker price for ETHUSDT: {ethMarket.CurrentPrice}");

Console.ReadLine();
