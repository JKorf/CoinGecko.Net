---
title: ICoinGeckoClientApi
has_children: true
---
*[generated documentation]*  
### CoinGeckoClient  
*CoinGecko API endpoints*
  
***
*The factory for creating requests. Used for unit testing*  
**IRequestFactory RequestFactory { get; set; }**  

***

## GetAssetCategoriesAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/categories/get_coins_categories](https://www.coingecko.com/en/api/documentation?deepLinking=1#/categories/get_coins_categories)  
<p>

*Get asset categories*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetAssetCategoriesAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoCategory>>> GetAssetCategoriesAsync(CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetAssetDetailsAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id_](https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id_)  
<p>

*Get asset details*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetAssetDetailsAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoAssetDetails>> GetAssetDetailsAsync(string assetId, bool? localization = default, bool? tickers = default, bool? marketData = default, bool? communityData = default, bool? developerData = default, bool? sparkline = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|assetId|The asset id|
|_[Optional]_ localization|Include localization|
|_[Optional]_ tickers|Include tickers|
|_[Optional]_ marketData|Include market data|
|_[Optional]_ communityData|Include community data|
|_[Optional]_ developerData|Include developer data|
|_[Optional]_ sparkline|Include sparkline|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetAssetDetailsFromContractAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/contract/get_coins__id__contract__contract_address_](https://www.coingecko.com/en/api/documentation?deepLinking=1#/contract/get_coins__id__contract__contract_address_)  
<p>

*Get asset details by contract address*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetAssetDetailsFromContractAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoAssetDetails>> GetAssetDetailsFromContractAsync(string platformId, string contractAddress, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|platformId|Id of the platform|
|contractAddress|Contract address|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetAssetHistoryAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__history](https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__history)  
<p>

*Get asset history info*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetAssetHistoryAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoAssetHistory>> GetAssetHistoryAsync(string assetId, DateTime date, bool? localization = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|assetId|Asset id|
|date|Date snapshot time|
|_[Optional]_ localization|Include localization|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetAssetPlatformsAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/asset_platforms/get_asset_platforms](https://www.coingecko.com/en/api/documentation?deepLinking=1#/asset_platforms/get_asset_platforms)  
<p>

*Get asset platforms list*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetAssetPlatformsAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoAssetPlatform>>> GetAssetPlatformsAsync(string? filter = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ filter|Filter|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetAssetsAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins_list](https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins_list)  
<p>

*Get list of all assets*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetAssetsAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoAsset>>> GetAssetsAsync(bool? includePlatform = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ includePlatform|Include platform contract address|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetBtcExchangeRatesAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchange_rates/get_exchange_rates](https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchange_rates/get_exchange_rates)  
<p>

*Get BTC-to-Currency exchange rates*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetBtcExchangeRatesAsync();  
```  

```csharp  
Task<WebCallResult<CoinGeckoExchangeRates>> GetBtcExchangeRatesAsync(CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetDerivativesAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/derivatives/get_derivatives](https://www.coingecko.com/en/api/documentation?deepLinking=1#/derivatives/get_derivatives)  
<p>

*Get list of derivative tickers*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetDerivativesAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoDerivative>>> GetDerivativesAsync(string? includeTickers = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ includeTickers|Include tickers for `all` or only `unexpired`|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetDerivativesExchangesListAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/derivatives/get_derivatives_exchanges_list](https://www.coingecko.com/en/api/documentation?deepLinking=1#/derivatives/get_derivatives_exchanges_list)  
<p>

*List all derivatives exchanges name and identifier*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetDerivativesExchangesListAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoListItem>>> GetDerivativesExchangesListAsync(CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetExchangeDerivativesAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/derivatives/get_derivatives_exchanges](https://www.coingecko.com/en/api/documentation?deepLinking=1#/derivatives/get_derivatives_exchanges)  
<p>

*Get all derivatives exchanges*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetExchangeDerivativesAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoExchangeDerivative>>> GetExchangeDerivativesAsync(int? page = default, int? pageSize = default, string? order = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ page|Page|
|_[Optional]_ pageSize|Page size|
|_[Optional]_ order|Sort order|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetExchangeDetailsAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges__id_](https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges__id_)  
<p>

*Get exchange details*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetExchangeDetailsAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoExchangeDetails>> GetExchangeDetailsAsync(string exchangeId, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|exchangeId|Id of the exchange|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetExchangeMarketsAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges_list](https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges_list)  
<p>

*Get all exchange markets*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetExchangeMarketsAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoListItem>>> GetExchangeMarketsAsync(CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetExchangesAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges](https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges)  
<p>

*Get all exchanges*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetExchangesAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoExchange>>> GetExchangesAsync(int? page = default, int? pageSize = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ page|Page|
|_[Optional]_ pageSize|Page size|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetExchangeTickersAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges__id__tickers](https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges__id__tickers)  
<p>

*Get exchange tickers*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetExchangeTickersAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoTickers>> GetExchangeTickersAsync(string exchangeId, IEnumerable<string>? assetIds = default, bool? includeExchangeLogo = default, int? page = default, bool? depth = default, string? order = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|exchangeId|Exchange id|
|_[Optional]_ assetIds|Asset ids filter|
|_[Optional]_ includeExchangeLogo|Include exchange logo|
|_[Optional]_ page|Page|
|_[Optional]_ depth|Include orderbook 2% depth|
|_[Optional]_ order|Sort|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetExchangeVolumeHistoryAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges__id__volume_chart](https://www.coingecko.com/en/api/documentation?deepLinking=1#/exchanges/get_exchanges__id__volume_chart)  
<p>

*Get volume chart data for an exchange*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetExchangeVolumeHistoryAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoMarketChartValue>>> GetExchangeVolumeHistoryAsync(string exchangeId, int days, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|exchangeId|Exchange id|
|days|Days history|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetGlobalDataAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/global/get_global](https://www.coingecko.com/en/api/documentation?deepLinking=1#/global/get_global)  
<p>

*Get global crypto data*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetGlobalDataAsync();  
```  

```csharp  
Task<WebCallResult<CoinGeckoGlobalData>> GetGlobalDataAsync(CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetGlobalDefiDataAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/global/get_global_decentralized_finance_defi](https://www.coingecko.com/en/api/documentation?deepLinking=1#/global/get_global_decentralized_finance_defi)  
<p>

*Get global defi crypto data*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetGlobalDefiDataAsync();  
```  

```csharp  
Task<WebCallResult<CoinGeckoGlobalDefiData>> GetGlobalDefiDataAsync(CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetIndexesAsync  

<p>

*Get indexes*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetIndexesAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoIndex>>> GetIndexesAsync(int? page = default, int? pageSize = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ page|Page|
|_[Optional]_ pageSize|Page size|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetIndexesListAsync  

<p>

*Get indexes list*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetIndexesListAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoListItem>>> GetIndexesListAsync(CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetMarketChartAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__market_chart_range](https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__market_chart_range)  
<p>

*Get historical market data*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetMarketChartAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartAsync(string assetId, string quoteAsset, DateTime from, DateTime to, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|assetId|Asset id|
|quoteAsset|Quote asset|
|from|From date|
|to|To date|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetMarketChartAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__market_chart](https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__market_chart)  
<p>

*Get historical market data*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetMarketChartAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartAsync(string assetId, string quoteAsset, int days, string? interval = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|assetId|Asset id|
|quoteAsset|Quote asset|
|days|Days back|
|_[Optional]_ interval|Data interval|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetMarketChartFromContractAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/contract/get_coins__id__contract__contract_address__market_chart_range](https://www.coingecko.com/en/api/documentation?deepLinking=1#/contract/get_coins__id__contract__contract_address__market_chart_range)  
<p>

*Get historical market data by contract*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetMarketChartFromContractAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(string assetId, string contractAddress, string quoteAsset, DateTime from, DateTime to, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|assetId|Asset id|
|contractAddress|Contract address|
|quoteAsset|Quote asset|
|from|From time|
|to|To time|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetMarketChartFromContractAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/contract/get_coins__id__contract__contract_address__market_chart_](https://www.coingecko.com/en/api/documentation?deepLinking=1#/contract/get_coins__id__contract__contract_address__market_chart_)  
<p>

*Get historical market data by contract*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetMarketChartFromContractAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoMarketChart>> GetMarketChartFromContractAsync(string assetId, string contractAddress, string quoteAsset, int days, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|assetId|Asset id|
|contractAddress|Contract address|
|quoteAsset|Quote asset|
|days|Days back|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetMarketDataCategoriesAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/categories/get_coins_categories](https://www.coingecko.com/en/api/documentation?deepLinking=1#/categories/get_coins_categories)  
<p>

*Get market data categories*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetMarketDataCategoriesAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoMarketDataCategory>>> GetMarketDataCategoriesAsync(string? order = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ order|Sorting|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetMarketsAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins_markets](https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins_markets)  
<p>

*Get coins market data*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetMarketsAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoMarket>>> GetMarketsAsync(string quoteAsset, IEnumerable<string>? assetIds = default, string? category = default, string? order = default, int? page = default, int? pageSize = default, bool? sparkline = default, IEnumerable<string>? priceChangePercentages = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|quoteAsset|Quote asset|
|_[Optional]_ assetIds|Asset ids|
|_[Optional]_ category|Category filter|
|_[Optional]_ order|Sorting|
|_[Optional]_ page|Page|
|_[Optional]_ pageSize|PageSize|
|_[Optional]_ sparkline|Include sparkline|
|_[Optional]_ priceChangePercentages|Include price change percentages|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetNftAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/nfts%20(beta)/get_nfts__id_](https://www.coingecko.com/en/api/documentation?deepLinking=1#/nfts%20(beta)/get_nfts__id_)  
<p>

*Get details on an NFT*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetNftAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoNftDetails>> GetNftAsync(string id, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|id|Id|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetNftByContractAddressAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/nfts%20(beta)/get_nfts__asset_platform_id__contract__contract_address_](https://www.coingecko.com/en/api/documentation?deepLinking=1#/nfts%20(beta)/get_nfts__asset_platform_id__contract__contract_address_)  
<p>

*Get nft info by contract address*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetNftByContractAddressAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoNftDetails>> GetNftByContractAddressAsync(string platformId, string contractAddress, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|platformId|Platform id|
|contractAddress|Contract address|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetNftsAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/nfts%20(beta)/get_nfts_list](https://www.coingecko.com/en/api/documentation?deepLinking=1#/nfts%20(beta)/get_nfts_list)  
<p>

*Get list of nfts*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetNftsAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoNft>>> GetNftsAsync(string? order = default, string? assetPlatformId = default, int? page = default, int? pageSize = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ order|Sort|
|_[Optional]_ assetPlatformId|Platform id|
|_[Optional]_ page|Page|
|_[Optional]_ pageSize|Page size|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetOhlcAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__ohlc](https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__ohlc)  
<p>

*Get Open/High/Low/Close data*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetOhlcAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<IEnumerable<CoinGeckoOhlc>>> GetOhlcAsync(string assetId, string quoteAsset, int days, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|assetId|Asset id|
|quoteAsset|Quote asset|
|days|Days back|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetPricesAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/simple/get_simple_price](https://www.coingecko.com/en/api/documentation?deepLinking=1#/simple/get_simple_price)  
<p>

*Get prices for specific assets*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetPricesAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<Dictionary<string, Dictionary<string, GetPricesAsync(IEnumerable<string> ids, IEnumerable<string> quoteAssets, bool? includeMarketCap, bool? include24hrVolume, bool? include24hrChange, bool? includeLastUpdatedAt, string? precision = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|ids|Asset ids to get data for|
|quoteAssets|Quote assets|
|includeMarketCap|Include market cap|
|include24hrVolume|Include 24h volume|
|include24hrChange|Include 24h change|
|includeLastUpdatedAt|Include last updated at|
|_[Optional]_ precision|Precision|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetQuoteAssetsAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/simple/get_simple_supported_vs_currencies](https://www.coingecko.com/en/api/documentation?deepLinking=1#/simple/get_simple_supported_vs_currencies)  
<p>

*Get list of quote assets*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetQuoteAssetsAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<string>>> GetQuoteAssetsAsync(CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetTickersAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__tickers](https://www.coingecko.com/en/api/documentation?deepLinking=1#/coins/get_coins__id__tickers)  
<p>

*Get tickers for an asset*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetTickersAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoTickers>> GetTickersAsync(string assetId, IEnumerable<string>? exchangeIds = default, bool? includeExchangeLogo = default, int? page = default, string? order = default, bool? depth = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|assetId|Asset id|
|_[Optional]_ exchangeIds|Exchange ids|
|_[Optional]_ includeExchangeLogo|Include exchange logo|
|_[Optional]_ page|Page|
|_[Optional]_ order|Sorting|
|_[Optional]_ depth|Include 2% order book depth info|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetTokenPricesAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/simple/get_simple_token_price__id_](https://www.coingecko.com/en/api/documentation?deepLinking=1#/simple/get_simple_token_price__id_)  
<p>

*Get prices by token contract addresses*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetTokenPricesAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<Dictionary<string, Dictionary<string, GetTokenPricesAsync(string platformId, IEnumerable<string> contractAddresses, IEnumerable<string> quoteAssets, bool? includeMarketCap, bool? include24hrVolume, bool? include24hrChange, bool? includeLastUpdatedAt, string? precision = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|platformId|Platform id|
|contractAddresses|Contract addresses|
|quoteAssets|Quote assets|
|includeMarketCap|Include market cap|
|include24hrVolume|Include 24h volume|
|include24hrChange|Include 24h change|
|includeLastUpdatedAt|Include last updated at|
|_[Optional]_ precision|Precision|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetTrendingSearchesAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/trending/get_search_trending](https://www.coingecko.com/en/api/documentation?deepLinking=1#/trending/get_search_trending)  
<p>

*Get trending searches*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..GetTrendingSearchesAsync();  
```  

```csharp  
Task<WebCallResult<CoinGeckoTrendingSearch>> GetTrendingSearchesAsync(CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ ct|Cancellation token|

</p>

***

## PingAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/ping/get_ping](https://www.coingecko.com/en/api/documentation?deepLinking=1#/ping/get_ping)  
<p>

*Ping the server*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..PingAsync();  
```  

```csharp  
Task<WebCallResult<string>> PingAsync(CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ ct|Cancellation token|

</p>

***

## SearchAsync  

[https://www.coingecko.com/en/api/documentation?deepLinking=1#/search/get_search](https://www.coingecko.com/en/api/documentation?deepLinking=1#/search/get_search)  
<p>

*Search for assets, exchanges, categories or nfts*  

```csharp  
var client = new CoinGeckoClient();  
var result = await client..SearchAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<CoinGeckoSearchResult>> SearchAsync(string query, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|query|Search query|
|_[Optional]_ ct|Cancellation token|

</p>
