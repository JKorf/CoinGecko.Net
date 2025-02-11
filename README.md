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

## Install the library

### NuGet 
[![NuGet version](https://img.shields.io/nuget/v/CoinGecko.net.svg?style=for-the-badge)](https://www.nuget.org/packages/CoinGecko.Net)  [![Nuget downloads](https://img.shields.io/nuget/dt/CoinGecko.Net.svg?style=for-the-badge)](https://www.nuget.org/packages/CoinGecko.Net)

	dotnet add package CoinGecko.Net
	
### GitHub packages
CoinGecko.Net is available on [GitHub packages](https://github.com/JKorf/CoinGecko.Net/pkgs/nuget/CoinGecko.Net). You'll need to add `https://nuget.pkg.github.com/JKorf/index.json` as a NuGet package source.

### Download release
[![GitHub Release](https://img.shields.io/github/v/release/JKorf/CoinGecko.Net?style=for-the-badge&label=GitHub)](https://github.com/JKorf/CoinGecko.Net/releases)

The NuGet package files are added along side the source with the latest GitHub release which can found [here](https://github.com/JKorf/CoinGecko.Net/releases).

## How to use
*REST Endpoints*  

```csharp
// Get the ETH price via rest request
var tickerResult = await restClient.Api.GetMarketsAsync("USD");
var lastPrice = tickerResult.Data.Single(x => x.Name == "Ethereum").CurrentPrice;
Console.ReadLine();
```

For information on the clients, dependency injection, response processing and more see the [CoinGecko.Net documentation](https://jkorf.github.io/CoinGecko.Net), [CryptoExchange.Net documentation](https://jkorf.github.io/CryptoExchange.Net), or have a look at the examples [here](https://github.com/JKorf/CoinGecko.Net/tree/master/Examples) or [here](https://github.com/JKorf/CryptoExchange.Net/tree/master/Examples).

## CryptoExchange.Net
CoinGecko.Net is based on the [CryptoExchange.Net](https://github.com/JKorf/CryptoExchange.Net) base library. Other exchange API implementations based on the CryptoExchange.Net base library are available and follow the same logic.

CryptoExchange.Net also allows for [easy access to different exchange API's](https://jkorf.github.io/CryptoExchange.Net#idocs_shared).

|Exchange|Repository|Nuget|
|--|--|--|
|Binance|[JKorf/Binance.Net](https://github.com/JKorf/Binance.Net)|[![Nuget version](https://img.shields.io/nuget/v/Binance.net.svg?style=flat-square)](https://www.nuget.org/packages/Binance.Net)|
|BingX|[JKorf/BingX.Net](https://github.com/JKorf/BingX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.BingX.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.BingX.Net)|
|Bitfinex|[JKorf/Bitfinex.Net](https://github.com/JKorf/Bitfinex.Net)|[![Nuget version](https://img.shields.io/nuget/v/Bitfinex.net.svg?style=flat-square)](https://www.nuget.org/packages/Bitfinex.Net)|
|Bitget|[JKorf/Bitget.Net](https://github.com/JKorf/Bitget.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.Bitget.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.Bitget.Net)|
|BitMart|[JKorf/BitMart.Net](https://github.com/JKorf/BitMart.Net)|[![Nuget version](https://img.shields.io/nuget/v/BitMart.Net.svg?style=flat-square)](https://www.nuget.org/packages/BitMart.Net)|
|BitMEX|[JKorf/BitMEX.Net](https://github.com/JKorf/BitMEX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JKorf.BitMEX.net.svg?style=flat-square)](https://www.nuget.org/packages/JKorf.BitMEX.Net)|
|Bybit|[JKorf/Bybit.Net](https://github.com/JKorf/Bybit.Net)|[![Nuget version](https://img.shields.io/nuget/v/Bybit.net.svg?style=flat-square)](https://www.nuget.org/packages/Bybit.Net)|
|Coinbase|[JKorf/Coinbase.Net](https://github.com/JKorf/Coinbase.Net)|[![Nuget version](https://img.shields.io/nuget/v/JKorf.Coinbase.Net.svg?style=flat-square)](https://www.nuget.org/packages/JKorf.Coinbase.Net)|
|CoinEx|[JKorf/CoinEx.Net](https://github.com/JKorf/CoinEx.Net)|[![Nuget version](https://img.shields.io/nuget/v/CoinEx.net.svg?style=flat-square)](https://www.nuget.org/packages/CoinEx.Net)|
|Crypto.com|[JKorf/CryptoCom.Net](https://github.com/JKorf/CryptoCom.Net)|[![Nuget version](https://img.shields.io/nuget/v/CryptoCom.net.svg?style=flat-square)](https://www.nuget.org/packages/CryptoCom.Net)|
|Gate.io|[JKorf/GateIo.Net](https://github.com/JKorf/GateIo.Net)|[![Nuget version](https://img.shields.io/nuget/v/GateIo.net.svg?style=flat-square)](https://www.nuget.org/packages/GateIo.Net)|
|HTX|[JKorf/HTX.Net](https://github.com/JKorf/HTX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JKorf.HTX.Net.svg?style=flat-square)](https://www.nuget.org/packages/JKorf.HTX.Net)|
|HyperLiquid|[JKorf/HyperLiquid.Net](https://github.com/JKorf/HyperLiquid.Net)|[![Nuget version](https://img.shields.io/nuget/v/HyperLiquid.Net.svg?style=flat-square)](https://www.nuget.org/packages/HyperLiquid.Net)|
|Kraken|[JKorf/Kraken.Net](https://github.com/JKorf/Kraken.Net)|[![Nuget version](https://img.shields.io/nuget/v/KrakenExchange.net.svg?style=flat-square)](https://www.nuget.org/packages/KrakenExchange.Net)|
|Kucoin|[JKorf/Kucoin.Net](https://github.com/JKorf/Kucoin.Net)|[![Nuget version](https://img.shields.io/nuget/v/Kucoin.net.svg?style=flat-square)](https://www.nuget.org/packages/Kucoin.Net)|
|Mexc|[JKorf/Mexc.Net](https://github.com/JKorf/Mexc.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.Mexc.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.Mexc.Net)|
|OKX|[JKorf/OKX.Net](https://github.com/JKorf/OKX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.OKX.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.OKX.Net)|
|WhiteBit|[JKorf/WhiteBit.Net](https://github.com/JKorf/WhiteBit.Net)|[![Nuget version](https://img.shields.io/nuget/v/WhiteBit.net.svg?style=flat-square)](https://www.nuget.org/packages/WhiteBit.Net)|
|XT|[JKorf/XT.Net](https://github.com/JKorf/XT.Net)|[![Nuget version](https://img.shields.io/nuget/v/XT.net.svg?style=flat-square)](https://www.nuget.org/packages/XT.Net)|

## Discord
[![Nuget version](https://img.shields.io/discord/847020490588422145?style=for-the-badge)](https://discord.gg/MSpeEtSY8t)  
A Discord server is available [here](https://discord.gg/MSpeEtSY8t). Feel free to join for discussion and/or questions around the CryptoExchange.Net and implementation libraries.

## Supported functionality
Note that only the public endpoints are supported, but setting API key is supported and the correct API urls will be selected.

### V3 API
|API|Supported|Location|
|--|--:|--|
|Ping|✓|`restClient.Api`|
|Key|✓|`restClient.Api`|
|Simple|✓|`restClient.Api`|
|Coins|✓|`restClient.Api`|
|Contract|✓|`restClient.Api`|
|Asset Platforms|✓|`restClient.Api`|
|Categories|✓|`restClient.Api`|
|Exchanges|✓|`restClient.Api`|
|Derivatives|✓|`restClient.Api`|
|Nfts|✓|`restClient.Api`|
|Exchange Rates|✓|`restClient.Api`|
|Search|✓|`restClient.Api`|
|Trending|✓|`restClient.Api`|
|Global|✓|`restClient.Api`|
|Companies|✓|`restClient.Api`|

## Support the project
Any support is greatly appreciated.

### Donate
Make a one time donation in a crypto currency of your choice. If you prefer to donate a currency not listed here please contact me.

**Btc**:  bc1q277a5n54s2l2mzlu778ef7lpkwhjhyvghuv8qf  
**Eth**:  0xcb1b63aCF9fef2755eBf4a0506250074496Ad5b7   
**USDT (TRX)**  TKigKeJPXZYyMVDgMyXxMf17MWYia92Rjd

### Sponsor
Alternatively, sponsor me on Github using [Github Sponsors](https://github.com/sponsors/JKorf). 

## Release notes
* Version 3.4.0 - 11 Feb 2025
    * Updated CryptoExchange.Net to version 8.8.0, see https://github.com/JKorf/CryptoExchange.Net/releases/
    * Fix Mono runtime exception on rest client construction using DI

* Version 3.3.1 - 07 Jan 2025
    * Updated CryptoExchange.Net version

* Version 3.3.0 - 23 Dec 2024
    * Updated CryptoExchange.Net to version 8.5.0, see https://github.com/JKorf/CryptoExchange.Net/releases/
    * Added SetOptions methods on Rest client
    * Added setting of DefaultProxyCredentials to CredentialCache.DefaultCredentials on the DI http client

* Version 3.2.0 - 28 Nov 2024
    * Updated CryptoExchange.Net to version 8.4.0, see https://github.com/JKorf/CryptoExchange.Net/releases/tag/8.4.0
    * Updated test and analyzer package versions

* Version 3.1.0 - 19 Nov 2024
    * Updated CryptoExchange.Net to version 8.3.0, see https://github.com/JKorf/CryptoExchange.Net/releases/tag/8.3.0
    * Added support for loading client settings from IConfiguration
    * Updated client constructors to accept IOptions from DI

* Version 3.0.0 - 11 Nov 2024
    * Switched json (de)serialization from Newtonsoft.Json to System.Text.Json
    * Added support for setting API key
    * Added error parsing implementation
    * Added pro API endpoint to CoinGeckoEnvironment
    * Added GetMarketsAsync endpoint
    * Added GetCompanyHoldingsAsync endpoint
    * Added GetExchangeDerivativesDetailsAsync endpoint
    * Added GetApiUsageAsync endpoint
    * Added precision parameter to GetMarketChartAsync, GetOhlcAsync
    * Updated response models
    * Updated API doc references
    * Removed includeTickers parameter from GetDerivativesAsync endpoint
    * Removed assetPlatformId parameter from GetNftsAsync endpoint

* Version 2.8.0 - 06 Nov 2024
    * Updated CryptoExchange.Net to version 8.2.0, see https://github.com/JKorf/CryptoExchange.Net/releases/tag/8.2.0

* Version 2.7.0 - 28 Oct 2024
    * Updated CryptoExchange.Net to version 8.1.0, see https://github.com/JKorf/CryptoExchange.Net/releases/tag/8.1.0

* Version 2.6.1 - 14 Oct 2024
    * Updated CryptoExchange.Net to version 8.0.3, see https://github.com/JKorf/CryptoExchange.Net/releases/tag/8.0.3
    * Fixed TypeLoadException during initialization

* Version 2.6.0 - 27 Sep 2024
    * Updated CryptoExchange.Net to version 8.0.0, see https://github.com/JKorf/CryptoExchange.Net/releases/tag/8.0.0
    * Updated Sourcelink package version

* Version 2.5.0 - 07 Aug 2024
    * Updated CryptoExchange.Net to version 7.11.0, see https://github.com/JKorf/CryptoExchange.Net/releases/tag/7.11.0

* Version 2.4.0 - 27 Jul 2024
    * Updated CryptoExchange.Net to version 7.10.0, see https://github.com/JKorf/CryptoExchange.Net/releases/tag/7.10.0

* Version 2.3.0 - 16 Jul 2024
    * Updated CryptoExchange.Net to version 7.9.0, see https://github.com/JKorf/CryptoExchange.Net/releases/tag/7.9.0
    * Updated internal classes to internal access modifier

* Version 2.2.10 - 02 Jul 2024
    * Updated CryptoExchange.Net to V7.8.0, see https://github.com/JKorf/CryptoExchange.Net/releases/tag/7.8.0

* Version 2.2.9 - 23 Jun 2024
    * Updated CryptoExchange.Net to version 7.7.0, see https://github.com/JKorf/CryptoExchange.Net/releases/tag/7.7.0

* Version 2.2.8 - 11 Jun 2024
    * Updated CryptoExchange.Net to v7.6.0, see https://github.com/JKorf/CryptoExchange.Net?tab=readme-ov-file#release-notes for release notes

* Version 2.2.7 - 07 May 2024
    * Updated CryptoExchange.Net to v7.5.2, see https://github.com/JKorf/CryptoExchange.Net?tab=readme-ov-file#release-notes for release notes

* Version 2.2.6 - 01 May 2024
    * Updated CryptoExchange.Net to v7.5.0, see https://github.com/JKorf/CryptoExchange.Net?tab=readme-ov-file#release-notes for release notes

* Version 2.2.5 - 28 Apr 2024
    * Updated CryptoExchange.Net to v7.4.0, see https://github.com/JKorf/CryptoExchange.Net?tab=readme-ov-file#release-notes for release notes

* Version 2.2.4 - 23 Apr 2024
    * Updated CryptoExchange.Net to 7.3.3, see https://github.com/JKorf/CryptoExchange.Net?tab=readme-ov-file#release-notes for release notes

* Version 2.2.3 - 18 Apr 2024
    * Updated CryptoExchange.Net to 7.3.1, see https://github.com/JKorf/CryptoExchange.Net?tab=readme-ov-file#release-notes for release notes

* Version 2.2.2 - 27 Mar 2024
    * Fixed client injection

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