# CoinGecko.Net
[![.NET](https://github.com/JKorf/CoinGecko.Net/actions/workflows/dotnet.yml/badge.svg)](https://github.com/JKorf/CoinGecko.Net/actions/workflows/dotnet.yml) [![Nuget version](https://img.shields.io/nuget/v/coingecko.net.svg)](https://www.nuget.org/packages/CoinGecko.Net)  [![Nuget downloads](https://img.shields.io/nuget/dt/CoinGecko.Net.svg)](https://www.nuget.org/packages/CoinGecko.Net)

CoinGecko.Net is a wrapper around the CoinGecko API as described on [CoinGecko](https://www.coingecko.com/en/api/documentation), including all features the API provides using clear and readable objects.

**If you think something is broken, something is missing or have any questions, please open an [Issue](https://github.com/JKorf/Binance.Net/issues)**

[Documentation](https://jkorf.github.io/CoinGecko.Net/)

## Installation
`dotnet add package CoinGecko.Net`

## Support the project
I develop and maintain this package on my own for free in my spare time, any support is greatly appreciated.

### Donate
Make a one time donation in a crypto currency of your choice. If you prefer to donate a currency not listed here please contact me.

**Btc**:  bc1qz0jv0my7fc60rxeupr23e75x95qmlq6489n8gh  
**Eth**:  0x8E21C4d955975cB645589745ac0c46ECA8FAE504   

### Sponsor
Alternatively, sponsor me on Github using [Github Sponsors](https://github.com/sponsors/JKorf). 

## Discord
A Discord server is available [here](https://discord.gg/MSpeEtSY8t). For discussion and/or questions around the CryptoExchange.Net and implementation libraries, feel free to join.

## Release notes
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