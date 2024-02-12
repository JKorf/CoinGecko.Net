# ![.CoinGecko.Net](https://github.com/JKorf/CoinGecko.Net/blob/main/CoinGecko.Net/Icon/icon.png?raw=true) CoinGecko.Net

[![.NET](https://github.com/JKorf/CoinGecko.Net/actions/workflows/dotnet.yml/badge.svg)](https://github.com/JKorf/CoinGecko.Net/actions/workflows/dotnet.yml)

CoinGecko.Net is a wrapper around the CoinGecko API as described on [CoinGecko](https://www.coingecko.com/en/api/documentation), including all features the API provides using clear and readable objects.

## Get the library
Available on Nuget  
 [![Nuget version](https://img.shields.io/nuget/v/coingecko.net.svg)](https://www.nuget.org/packages/CoinGecko.Net)  [![Nuget downloads](https://img.shields.io/nuget/dt/CoinGecko.Net.svg)](https://www.nuget.org/packages/CoinGecko.Net)

`dotnet add package CoinGecko.Net`

## How to use
Simplest usage
```csharp
// Get the ETH/USDT ticker via rest request
var restClient = new CoinGeckoRestClient();
var tickerResult = await restClient.Api.GetMarketsAsync("USD");
var lastPrice = tickerResult.Data.First().CurrentPrice;
```

For information on the clients, dependency injection, response processing and more see the [documentation](https://jkorf.github.io/CryptoExchange.Net), or have a look at the examples  [here](https://github.com/JKorf/CryptoExchange.Net/tree/master/Examples).

## CryptoExchange.Net
CoinGecko.Net is based on the [CryptoExchange.Net](https://github.com/JKorf/CryptoExchange.Net) base library. Other exchange API implementations based on the CryptoExchange.Net base library are available and follow the same logic.

CryptoExchange.Net also allows for [easy access to different exchange API's](https://jkorf.github.io/CryptoExchange.Net#idocs_common).

|Exchange|Repository|Nuget|
|--|--|--|
|Binance|[JKorf/Binance.Net](https://github.com/JKorf/Binance.Net)|[![Nuget version](https://img.shields.io/nuget/v/Binance.net.svg)](https://www.nuget.org/packages/Binance.Net)|
|Bitfinex|[JKorf/Bitfinex.Net](https://github.com/JKorf/Bitfinex.Net)|[![Nuget version](https://img.shields.io/nuget/v/Bitfinex.net.svg)](https://www.nuget.org/packages/Bitfinex.Net)|
|Bitget|[JKorf/Bitget.Net](https://github.com/JKorf/Bitget.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.Bitget.net.svg)](https://www.nuget.org/packages/JK.Bitget.Net)|
|Bybit|[JKorf/Bybit.Net](https://github.com/JKorf/Bybit.Net)|[![Nuget version](https://img.shields.io/nuget/v/Bybit.net.svg)](https://www.nuget.org/packages/Bybit.Net)|
|CoinEx|[JKorf/CoinEx.Net](https://github.com/JKorf/CoinEx.Net)|[![Nuget version](https://img.shields.io/nuget/v/CoinEx.net.svg)](https://www.nuget.org/packages/CoinEx.Net)|
|Huobi/HTX|[JKorf/Huobi.Net](https://github.com/JKorf/Huobi.Net)|[![Nuget version](https://img.shields.io/nuget/v/Huobi.net.svg)](https://www.nuget.org/packages/Huobi.Net)|
|Kraken|[JKorf/Kraken.Net](https://github.com/JKorf/Kraken.Net)|[![Nuget version](https://img.shields.io/nuget/v/KrakenExchange.net.svg)](https://www.nuget.org/packages/KrakenExchange.Net)|
|Kucoin|[JKorf/Kucoin.Net](https://github.com/JKorf/Kucoin.Net)|[![Nuget version](https://img.shields.io/nuget/v/Kucoin.net.svg)](https://www.nuget.org/packages/Kucoin.Net)|
|Mexc|[JKorf/Mexc.Net](https://github.com/JKorf/Mexc.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.Mexc.net.svg)](https://www.nuget.org/packages/JK.Mexc.Net)|
|OKX|[JKorf/OKX.Net](https://github.com/JKorf/OKX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.OKX.net.svg)](https://www.nuget.org/packages/JK.OKX.Net)|

## Discord
A Discord server is available [here](https://discord.gg/MSpeEtSY8t). Feel free to join for discussion and/or questions around the CryptoExchange.Net and implementation libraries.

## Supported functionality

### V3 API
|API|Supported|Location|
|--|--:|--|
|Ping|✓|`restClient.Api`|
|Simple|✓|`restClient.Api`|
|Coins|✓|`restClient.Api`|
|Contract|X||
|Asset Platforms|✓|`restClient.Api`|
|Categories|✓|`restClient.Api`|
|Exchanges|✓|`restClient.Api`|
|Derivatives|✓|`restClient.Api`|
|Nfts|X||
|Exchange Rates|✓|`restClient.Api`|
|Search|✓|`restClient.Api`|
|Trending|✓|`restClient.Api`|
|Global|✓|`restClient.Api`|
|Companies|X||

## Support the project
I develop and maintain this package on my own for free in my spare time, any support is greatly appreciated.

### Donate
Make a one time donation in a crypto currency of your choice. If you prefer to donate a currency not listed here please contact me.

**Btc**:  bc1qz0jv0my7fc60rxeupr23e75x95qmlq6489n8gh  
**Eth**:  0x8E21C4d955975cB645589745ac0c46ECA8FAE504   

### Sponsor
Alternatively, sponsor me on Github using [Github Sponsors](https://github.com/sponsors/JKorf). 

## Release notes
* Version 2.1.0-beta1 - 06 Feb 2024
    * Updated CryptoExchange.Net

* Version 2.0.6 - 03 Dec 2023
    * Updated CryptoExchange.Net

* Version 2.0.5 - 07 Nov 2023
    * Fix deserialization issue in GetAssetDetailsAsync for certain assets

* Version 2.0.4 - 24 Oct 2023
    * Updated CryptoExchange.Net

* Version 2.0.3 - 09 Oct 2023
    * Updated CryptoExchange.Net version

* Version 2.0.2 - 01 Oct 2023
    * Fixed deserialization issue market model

* Version 2.0.1 - 25 Aug 2023
    * Updated CryptoExchange.Net

* Version 2.0.0 - 25 Jun 2023
    * Updated CryptoExchange.Net to version 6.0.0
    * Renamed CoinGeckoClient to CoinGeckoRestClient
    * Updated dependency injection register method (AddCoinGecko)
    * Fixed deserialization error on Asset details model

* Version 1.0.4 - 16 Apr 2023
    * Fixed some calls returning a 401 Unauthorized error

* Version 1.0.3 - 18 Mar 2023
    * Updated CryptoExchange.Net

* Version 1.0.2 - 14 Feb 2023
    * Updated CryptoExchange.Net

* Version 1.0.1 - 25 Jan 2023
    * Fixed mapping of status updates in GetAssetDetailsAsync

* Version 1.0.0 - 08 Jan 2023
    * Initial release