using CoinGecko.Net.Interfaces;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add the CoinGecko services
builder.Services.AddCoinGecko();

// OR to provide options:
/*
builder.Services.AddCoinGecko(restOptions =>
{
    restOptions.ApiCredentials = new CoinGeckoApiCredentials("<APIKEY>");
});
*/

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

// Map the endpoints and inject the CoinGecko rest client
app.MapGet("/{asset}", async ([FromServices] ICoinGeckoRestClient client, string asset) =>
{
    var result = await client.Api.GetMarketsAsync(asset);
    return (object)(result.Success ? result.Data : result.Error!);
})
.WithOpenApi();

app.Run();