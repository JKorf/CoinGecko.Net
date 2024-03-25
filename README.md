# ![.CoinGecko.Net](https://github.com/JKorf/CoinGecko.Net/blob/main/CoinGecko.Net/Icon/icon.png?raw=true) CoinGecko.Net

[![.NET](https://img.shields.io/github/actions/workflow/status/JKorf/CoinGecko.Net/dotnet.yml?style=for-the-badge)](https://github.com/JKorf/CoinGecko.Net/actions/workflows/dotnet.yml)

CoinGecko.Net is a strongly typed client library for accessing the [CoinGecko REST API](https://www.coingecko.com/en/api/documentation). All data is mapped to readable models and enum values.

## Supported Frameworks
The library is targeting both `.NET Standard 2.0` and `.NET Standard 2.1` for optimal compatibility

|.NET implementation|Version Support|
|--|--|
|.NET Core|`2.0` and higher|
|.NET Framework|`4.6.1` and higher|
|Mono|`5.4` and higher|
|Xamarin.iOS|`10.14` and higher|
|Xamarin.Android|`8.0` and higher|
|UWP|`10.0.16299` and higher|
|Unity|`2018.1` and higher|

## Get the library
[![Nuget version](https://img.shields.io/nuget/v/coingecko.net.svg?style=for-the-badge)](https://www.nuget.org/packages/CoinGecko.Net)  [![Nuget downloads](https://img.shields.io/nuget/dt/CoinGecko.Net.svg?style=for-the-badge)](https://www.nuget.org/packages/CoinGecko.Net)

	dotnet add package CoinGecko.Net

## How to use
*REST Endpoints*  

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
|Binance|[JKorf/Binance.Net](https://github.com/JKorf/Binance.Net)|[![Nuget version](https://img.shields.io/nuget/v/Binance.net.svg?style=flat-square)](https://www.nuget.org/packages/Binance.Net)|
|BingX|[JKorf/BingX.Net](https://github.com/JKorf/BingX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.BingX.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.BingX.Net)|
|Bitfinex|[JKorf/Bitfinex.Net](https://github.com/JKorf/Bitfinex.Net)|[![Nuget version](https://img.shields.io/nuget/v/Bitfinex.net.svg?style=flat-square)](https://www.nuget.org/packages/Bitfinex.Net)|
|Bitget|[JKorf/Bitget.Net](https://github.com/JKorf/Bitget.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.Bitget.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.Bitget.Net)|
|Bybit|[JKorf/Bybit.Net](https://github.com/JKorf/Bybit.Net)|[![Nuget version](https://img.shields.io/nuget/v/Bybit.net.svg?style=flat-square)](https://www.nuget.org/packages/Bybit.Net)|
|CoinEx|[JKorf/CoinEx.Net](https://github.com/JKorf/CoinEx.Net)|[![Nuget version](https://img.shields.io/nuget/v/CoinEx.net.svg?style=flat-square)](https://www.nuget.org/packages/CoinEx.Net)|
|Huobi/HTX|[JKorf/Huobi.Net](https://github.com/JKorf/Huobi.Net)|[![Nuget version](https://img.shields.io/nuget/v/Huobi.net.svg?style=flat-square)](https://www.nuget.org/packages/Huobi.Net)|
|Kraken|[JKorf/Kraken.Net](https://github.com/JKorf/Kraken.Net)|[![Nuget version](https://img.shields.io/nuget/v/KrakenExchange.net.svg?style=flat-square)](https://www.nuget.org/packages/KrakenExchange.Net)|
|Kucoin|[JKorf/Kucoin.Net](https://github.com/JKorf/Kucoin.Net)|[![Nuget version](https://img.shields.io/nuget/v/Kucoin.net.svg?style=flat-square)](https://www.nuget.org/packages/Kucoin.Net)|
|Mexc|[JKorf/Mexc.Net](https://github.com/JKorf/Mexc.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.Mexc.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.Mexc.Net)|
|OKX|[JKorf/OKX.Net](https://github.com/JKorf/OKX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.OKX.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.OKX.Net)|

## Discord
[![Nuget version](https://img.shields.io/discord/847020490588422145?style=for-the-badge)](https://discord.gg/MSpeEtSY8t)  
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

**Btc**:  bc1q277a5n54s2l2mzlu778ef7lpkwhjhyvghuv8qf  
**Eth**:  0xcb1b63aCF9fef2755eBf4a0506250074496Ad5b7   
**USDT (TRX)**  TKigKeJPXZYyMVDgMyXxMf17MWYia92Rjd

### Sponsor
Alternatively, sponsor me on Github using [Github Sponsors](https://github.com/sponsors/JKorf). 

## Release notes
* Version 2.2.1 - 24 Mar 2024
	* Updated CryptoExchange.Net to 7.2.0, see https://github.com/JKorf/CryptoExchange.Net?tab=readme-ov-file#release-notes for release notes

* Version 2.2.0 - 16 Mar 2024
    * Updated CryptoExchange.Net to 7.1.0, see https://github.com/JKorf/CryptoExchange.Net?tab=readme-ov-file#release-notes for release notes
	* Fixed deserialization issues
	
* Version 2.1.0 - 25 Feb 2024
    * Updated CryptoExchange.Net
    * Fixed issue in DI registration causing http client to not be correctly injected
    * Updated some namespaces

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