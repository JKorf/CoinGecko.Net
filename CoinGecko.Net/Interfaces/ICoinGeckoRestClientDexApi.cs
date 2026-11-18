using CoinGecko.Net.Enums;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoinGecko.Net.Objects.Models;
using CryptoExchange.Net.Interfaces.Clients;
using CryptoExchange.Net.Objects;

namespace CoinGecko.Net.Interfaces
{
    /// <summary>
    /// CoinGecko API endpoints
    /// </summary>
    public interface ICoinGeckoRestClientDexApi : IRestApiClient<CoinGeckoCredentials>
    {
        /// <summary>
        /// Get dex networks
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/networks-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks
        /// </para>
        /// </summary>
        /// <param name="page">Page number</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexNetworksResponse>> GetDexNetworksAsync(int page = 1, CancellationToken ct = default);

        /// <summary>
        /// Search pools
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/search-pools" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/search/pools
        /// </para>
        /// </summary>
        /// <param name="query">Search query, can be pool contract address, token name, token symbol, or token contract address</param>
        /// <param name="network">The network id</param>
        /// <param name="include">Attributes to include. Available values: base_token, quote_token, dex</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexSearchPoolsResponse>> SearchPoolsAsync(string query, string? network = null, IEnumerable<PoolInclude>? include = null, int? page = null, CancellationToken ct = default);

        /// <summary>
        /// Get OHLCV data for a token by its contract address on a given network. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/token-ohlcv-token-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/tokens/{token_address}/ohlcv/{timeframe}
        /// </para>
        /// </summary>
        /// <param name="network">The CoinGecko on-chain network id (e.g. "eth", "solana")</param>
        /// <param name="tokenAddress">The token contract address</param>
        /// <param name="timeframe">Candle timeframe: "day", "hour", "minute", or "second"</param>
        /// <param name="aggregate">Time period to aggregate each OHLCV (e.g. 1, 5, 15)</param>
        /// <param name="limit">Maximum number of candles to return (max 1000, default 100)</param>
        /// <param name="beforeTimestamp">Return candles before this timestamp (UTC)</param>
        /// <param name="currency">Quote currency. Either "usd" or "token". Defaults to "usd"</param>
        /// <param name="includeEmptyIntervals">["<c>include_empty_intervals</c>"] Include empty intervals with no trade data.</param>
        /// <param name="includeInactiveSource">["<c>include_inactive_source</c>"] Include token data from inactive pools using the most recent swap.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexOhlcvResponse>> GetTokenOhlcvAsync(
            string network,
            string tokenAddress,
            DexOhlcvTimeframe timeframe,
            int? aggregate = null,
            int? limit = null,
            DateTime? beforeTimestamp = null,
            DexOhlcvCurrency? currency = null,
            bool? includeEmptyIntervals = null,
            bool? includeInactiveSource = null,
            CancellationToken ct = default);

        /// <summary>
        /// Specific Pool Data by Pool Address. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/pool-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/pools/{address}
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="address">["<c>address</c>"] Pool address.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include, comma-separated if more than one.</param>
        /// <param name="includeVolumeBreakdown">["<c>include_volume_breakdown</c>"] Include volume breakdown.</param>
        /// <param name="includeComposition">["<c>include_composition</c>"] Include pool composition.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexPoolResponse>> GetPoolAsync(
            string network,
            string address,
            IEnumerable<PoolInclude>? include = null,
            bool? includeVolumeBreakdown = null,
            bool? includeComposition = null,
            CancellationToken ct = default);

        /// <summary>
        /// Trending Pools List. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/trending-pools-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/trending_pools
        /// </para>
        /// </summary>
        /// <param name="include">["<c>include</c>"] Attributes to include, comma-separated if more than one.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="duration">["<c>duration</c>"] Duration to sort trending list by.</param>
        /// <param name="includeGtCommunityData">["<c>include_gt_community_data</c>"] Include GeckoTerminal community data (sentiment votes, suspicious reports).</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexPoolsResponse>> GetTrendingPoolsAsync(
            IEnumerable<TrendingPoolsInclude>? include = null,
            int? page = null,
            DexPoolDuration? duration = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default);

        /// <summary>
        /// Trending Pools by Network. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/trending-pools-network" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/trending_pools
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include, comma-separated if more than one.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="duration">["<c>duration</c>"] Duration to sort trending list by.</param>
        /// <param name="includeGtCommunityData">["<c>include_gt_community_data</c>"] Include GeckoTerminal community data (sentiment votes, suspicious reports).</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexPoolsResponse>> GetTrendingPoolsByNetworkAsync(
            string network,
            IEnumerable<PoolInclude>? include = null,
            int? page = null,
            DexPoolDuration? duration = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default);

        /// <summary>
        /// Top Pools by Network. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/top-pools-network" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/pools
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include, comma-separated if more than one.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="sort">["<c>sort</c>"] Sort the pools by field.</param>
        /// <param name="includeGtCommunityData">["<c>include_gt_community_data</c>"] Include GeckoTerminal community data (sentiment votes, suspicious reports).</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexPoolsResponse>> GetTopPoolsByNetworkAsync(
            string network,
            IEnumerable<PoolInclude>? include = null,
            int? page = null,
            TopPoolsByNetworkSort? sort = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default);

        /// <summary>
        /// Top Pools by DEX. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/top-pools-dex" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/dexes/{dex}/pools
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="dex">["<c>dex</c>"] DEX ID.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include, comma-separated if more than one.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="sort">["<c>sort</c>"] Sort the pools by field.</param>
        /// <param name="includeGtCommunityData">["<c>include_gt_community_data</c>"] Include GeckoTerminal community data (sentiment votes, suspicious reports).</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexPoolsResponse>> GetTopPoolsByDexAsync(
            string network,
            string dex,
            IEnumerable<PoolInclude>? include = null,
            int? page = null,
            TopPoolsByNetworkSort? sort = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default);

        /// <summary>
        /// Megafilter for Pools. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/pools-megafilter" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/pools/megafilter
        /// </para>
        /// </summary>
        /// <param name="networks">["<c>networks</c>"] Filter pools by networks, comma-separated if more than one.</param>
        /// <param name="dexes">["<c>dexes</c>"] Filter pools by DEXes, comma-separated if more than one.</param>
        /// <param name="quoteTokenAddresses">["<c>quote_token_addresses</c>"] Filter pools whose quote token is one of these token addresses, comma-separated if more than one.</param>
        /// <param name="quoteTokenPreset">["<c>quote_token_preset</c>"] Filter pools whose quote token belongs to a preset group.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include, comma-separated if more than one.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="sort">["<c>sort</c>"] Sort the pools by field.</param>
        /// <param name="fdvUsdMin">["<c>fdv_usd_min</c>"] Minimum fully diluted value in USD.</param>
        /// <param name="fdvUsdMax">["<c>fdv_usd_max</c>"] Maximum fully diluted value in USD.</param>
        /// <param name="reserveInUsdMin">["<c>reserve_in_usd_min</c>"] Minimum reserve in USD.</param>
        /// <param name="reserveInUsdMax">["<c>reserve_in_usd_max</c>"] Maximum reserve in USD.</param>
        /// <param name="h24VolumeUsdMin">["<c>h24_volume_usd_min</c>"] Minimum 24hr volume in USD.</param>
        /// <param name="h24VolumeUsdMax">["<c>h24_volume_usd_max</c>"] Maximum 24hr volume in USD.</param>
        /// <param name="poolCreatedHourMin">["<c>pool_created_hour_min</c>"] Minimum pool age in hours.</param>
        /// <param name="poolCreatedHourMax">["<c>pool_created_hour_max</c>"] Maximum pool age in hours.</param>
        /// <param name="txCountMin">["<c>tx_count_min</c>"] Minimum transaction count.</param>
        /// <param name="txCountMax">["<c>tx_count_max</c>"] Maximum transaction count.</param>
        /// <param name="txCountDuration">["<c>tx_count_duration</c>"] Duration for transaction count metric.</param>
        /// <param name="buysMin">["<c>buys_min</c>"] Minimum number of buy transactions.</param>
        /// <param name="buysMax">["<c>buys_max</c>"] Maximum number of buy transactions.</param>
        /// <param name="buysDuration">["<c>buys_duration</c>"] Duration for buy transactions metric.</param>
        /// <param name="sellsMin">["<c>sells_min</c>"] Minimum number of sell transactions.</param>
        /// <param name="sellsMax">["<c>sells_max</c>"] Maximum number of sell transactions.</param>
        /// <param name="sellsDuration">["<c>sells_duration</c>"] Duration for sell transactions metric.</param>
        /// <param name="priceChangePercentageMin">["<c>price_change_percentage_min</c>"] Minimum price change percentage.</param>
        /// <param name="priceChangePercentageMax">["<c>price_change_percentage_max</c>"] Maximum price change percentage.</param>
        /// <param name="priceChangePercentageDuration">["<c>price_change_percentage_duration</c>"] Duration for price change percentage metric.</param>
        /// <param name="buyTaxPercentageMin">["<c>buy_tax_percentage_min</c>"] Minimum buy tax percentage.</param>
        /// <param name="buyTaxPercentageMax">["<c>buy_tax_percentage_max</c>"] Maximum buy tax percentage.</param>
        /// <param name="sellTaxPercentageMin">["<c>sell_tax_percentage_min</c>"] Minimum sell tax percentage.</param>
        /// <param name="sellTaxPercentageMax">["<c>sell_tax_percentage_max</c>"] Maximum sell tax percentage.</param>
        /// <param name="holderCountMin">["<c>holder_count_min</c>"] Minimum holder count.</param>
        /// <param name="holderCountMax">["<c>holder_count_max</c>"] Maximum holder count.</param>
        /// <param name="top10HoldersPercentageMin">["<c>top_10_holders_percentage_min</c>"] Minimum top 10 holders percentage.</param>
        /// <param name="top10HoldersPercentageMax">["<c>top_10_holders_percentage_max</c>"] Maximum top 10 holders percentage.</param>
        /// <param name="checks">["<c>checks</c>"] Filter options for various checks, comma-separated if more than one.</param>
        /// <param name="includeUnknownHoneypotTokens">["<c>include_unknown_honeypot_tokens</c>"] When checks includes no_honeypot, set to true to also include unknown honeypot tokens.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexPoolsResponse>> GetFilteredPoolsAsync(
            IEnumerable<string>? networks = null,
            IEnumerable<string>? dexes = null,
            IEnumerable<string>? quoteTokenAddresses = null,
            FilteredPoolsQuoteTokenPreset? quoteTokenPreset = null,
            IEnumerable<TrendingPoolsInclude>? include = null,
            int? page = null,
            FilteredPoolsSort? sort = null,
            decimal? fdvUsdMin = null,
            decimal? fdvUsdMax = null,
            decimal? reserveInUsdMin = null,
            decimal? reserveInUsdMax = null,
            decimal? h24VolumeUsdMin = null,
            decimal? h24VolumeUsdMax = null,
            decimal? poolCreatedHourMin = null,
            decimal? poolCreatedHourMax = null,
            int? txCountMin = null,
            int? txCountMax = null,
            DexPoolDuration? txCountDuration = null,
            int? buysMin = null,
            int? buysMax = null,
            DexPoolDuration? buysDuration = null,
            int? sellsMin = null,
            int? sellsMax = null,
            DexPoolDuration? sellsDuration = null,
            decimal? priceChangePercentageMin = null,
            decimal? priceChangePercentageMax = null,
            DexPoolDuration? priceChangePercentageDuration = null,
            decimal? buyTaxPercentageMin = null,
            decimal? buyTaxPercentageMax = null,
            decimal? sellTaxPercentageMin = null,
            decimal? sellTaxPercentageMax = null,
            int? holderCountMin = null,
            int? holderCountMax = null,
            decimal? top10HoldersPercentageMin = null,
            decimal? top10HoldersPercentageMax = null,
            IEnumerable<FilteredPoolsCheck>? checks = null,
            bool? includeUnknownHoneypotTokens = null,
            CancellationToken ct = default);

        /// <summary>
        /// Trending Search Pools. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/trending-search-pools" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/pools/trending_search
        /// </para>
        /// </summary>
        /// <param name="include">["<c>include</c>"] Attributes to include, comma-separated if more than one.</param>
        /// <param name="pools">["<c>pools</c>"] Number of pools to return, maximum 10.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoTrendingSearchPools>> GetTrendingPoolSearchesAsync(
            IEnumerable<TrendingPoolsInclude>? include = null,
            int? pools = null,
            CancellationToken ct = default);

        /// <summary>
        /// Top Pools by Token Address. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/top-pools-contract-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/tokens/{token_address}/pools
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="tokenAddress">["<c>token_address</c>"] Token contract address.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include, comma-separated if more than one.</param>
        /// <param name="includeInactiveSource">["<c>include_inactive_source</c>"] Include tokens from inactive pools using the most recent swap.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="sort">["<c>sort</c>"] Sort the pools by field.</param>
        /// <param name="includeGtCommunityData">["<c>include_gt_community_data</c>"] Include GeckoTerminal community data (sentiment votes, suspicious reports).</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexPoolsResponse>> GetTopPoolsByTokenAddressAsync(
            string network,
            string tokenAddress,
            IEnumerable<PoolInclude>? include = null,
            bool? includeInactiveSource = null,
            int? page = null,
            TopPoolsByTokenAddressSort? sort = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default);

        /// <summary>
        /// Token Data by Token Address. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/token-data-contract-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/tokens/{address}
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="address">["<c>address</c>"] Token contract address.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include.</param>
        /// <param name="includeComposition">["<c>include_composition</c>"] Include pool composition.</param>
        /// <param name="includeInactiveSource">["<c>include_inactive_source</c>"] Include token data from inactive pools using the most recent swap.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexTokenResponse>> GetTokenAsync(
            string network,
            string address,
            TokenInclude? include = null,
            bool? includeComposition = null,
            bool? includeInactiveSource = null,
            CancellationToken ct = default);

        /// <summary>
        /// Tokens Data by Token Addresses. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/tokens-data-contract-addresses" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/tokens/multi/{addresses}
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="addresses">["<c>addresses</c>"] Token contract address, comma-separated if more than one token contract address.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include.</param>
        /// <param name="includeComposition">["<c>include_composition</c>"] Include pool composition.</param>
        /// <param name="includeInactiveSource">["<c>include_inactive_source</c>"] Include tokens from inactive pools using the most recent swap.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexTokensResponse>> GetTokensAsync(
            string network,
            IEnumerable<string> addresses,
            TokenInclude? include = null,
            bool? includeComposition = null,
            bool? includeInactiveSource = null,
            CancellationToken ct = default);

        /// <summary>
        /// Tokens Data by Token Addresses across Networks. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/tokens-data-contract-addresses-multi" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/tokens/multi
        /// </para>
        /// </summary>
        /// <param name="tokens">["<c>tokens</c>"] Network ID and token contract address pairs in network_id:token_address format, comma-separated if more than one.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include.</param>
        /// <param name="includeComposition">["<c>include_composition</c>"] Include pool composition.</param>
        /// <param name="includeInactiveSource">["<c>include_inactive_source</c>"] Include tokens from inactive pools using the most recent swap.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexMultiNetworkTokensResponse>> GetTokensAcrossNetworksAsync(
            IEnumerable<string> tokens,
            TokenInclude? include = null,
            bool? includeComposition = null,
            bool? includeInactiveSource = null,
            CancellationToken ct = default);

        /// <summary>
        /// Token Info by Token Address. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/token-info-contract-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/tokens/{address}/info
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="address">["<c>address</c>"] Token contract address.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexTokenInfoResponse>> GetTokenInfoAsync(
            string network,
            string address,
            CancellationToken ct = default);

        /// <summary>
        /// Pool Tokens Info by Pool Address. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/pool-token-info-contract-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/pools/{pool_address}/info
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="poolAddress">["<c>pool_address</c>"] Pool contract address.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexPoolTokensInfoResponse>> GetPoolTokenInfoAsync(
            string network,
            string poolAddress,
            PoolTokenInfoInclude? include = null,
            CancellationToken ct = default);

        /// <summary>
        /// Most Recently Updated Tokens List. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/tokens-info-recent-updated" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/tokens/info_recently_updated
        /// </para>
        /// </summary>
        /// <param name="include">["<c>include</c>"] Attributes for related resources to include.</param>
        /// <param name="network">["<c>network</c>"] Filter tokens by provided network.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexRecentTokenInfoResponse>> GetRecentlyUpdatedTokensAsync(
            RecentlyUpdatedTokensInclude? include = null,
            string? network = null,
            CancellationToken ct = default);

        /// <summary>
        /// Top Token Traders by Token Address. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/top-token-traders-token-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network_id}/tokens/{token_address}/top_traders
        /// </para>
        /// </summary>
        /// <param name="networkId">["<c>network_id</c>"] Network ID.</param>
        /// <param name="tokenAddress">["<c>token_address</c>"] Token contract address.</param>
        /// <param name="traders">["<c>traders</c>"] Number of top token traders to return, any integer or max.</param>
        /// <param name="sort">["<c>sort</c>"] Sort the traders by field.</param>
        /// <param name="includeAddressLabel">["<c>include_address_label</c>"] Include address label data.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoTopTokenTraders>> GetTopTokenTradersAsync(
            string networkId,
            string tokenAddress,
            string? traders = null,
            TopTokenTradersSort? sort = null,
            bool? includeAddressLabel = null,
            CancellationToken ct = default);

        /// <summary>
        /// Top Token Holders by Token Address. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/top-token-holders-token-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/tokens/{address}/top_holders
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="address">["<c>address</c>"] Token contract address.</param>
        /// <param name="holders">["<c>holders</c>"] Number of top token holders to return, any integer or max.</param>
        /// <param name="includePnlDetails">["<c>include_pnl_details</c>"] Include PnL details for token holders.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoTopTokenHolders>> GetTopTokenHoldersAsync(
            string network,
            string address,
            string? holders = null,
            bool? includePnlDetails = null,
            CancellationToken ct = default);

        /// <summary>
        /// Historical Token Holders Chart by Token Address. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/token-holders-chart-token-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/tokens/{token_address}/holders_chart
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="tokenAddress">["<c>token_address</c>"] Token contract address.</param>
        /// <param name="days">["<c>days</c>"] Number of days to return the historical token holders chart.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoTokenHoldersChart>> GetTokenHoldersChartAsync(
            string network,
            string tokenAddress,
            string? days = null,
            CancellationToken ct = default);

        /// <summary>
        /// Pool OHLCV Chart by Pool Address. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/pool-ohlcv-contract-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/pools/{pool_address}/ohlcv/{timeframe}
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="poolAddress">["<c>pool_address</c>"] Pool contract address.</param>
        /// <param name="timeframe">["<c>timeframe</c>"] Timeframe of the OHLCV chart.</param>
        /// <param name="aggregate">["<c>aggregate</c>"] Time period to aggregate each OHLCV.</param>
        /// <param name="beforeTimestamp">["<c>before_timestamp</c>"] Return OHLCV data up to and including the candle that contains this timestamp (integer seconds since epoch). That candle covers its full interval, so it may include trades after this timestamp.</param>
        /// <param name="limit">["<c>limit</c>"] Number of OHLCV results to return, maximum 1000.</param>
        /// <param name="currency">["<c>currency</c>"] Return OHLCV in USD or quote token.</param>
        /// <param name="token">["<c>token</c>"] Return OHLCV for token, use this to invert the chart.</param>
        /// <param name="includeEmptyIntervals">["<c>include_empty_intervals</c>"] Include empty intervals with no trade data.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexOhlcvResponse>> GetPoolOhlcvAsync(
            string network,
            string poolAddress,
            DexOhlcvTimeframe timeframe,
            int? aggregate = null,
            DateTime? beforeTimestamp = null,
            int? limit = null,
            DexOhlcvCurrency? currency = null,
            string? token = null,
            bool? includeEmptyIntervals = null,
            CancellationToken ct = default);

        /// <summary>
        /// Trades by Pool Address. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/pool-trades-contract-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/pools/{pool_address}/trades
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="poolAddress">["<c>pool_address</c>"] Pool contract address.</param>
        /// <param name="tradeVolumeInUsdGreaterThan">["<c>trade_volume_in_usd_greater_than</c>"] Filter trades by trade volume in USD greater than this value.</param>
        /// <param name="token">["<c>token</c>"] Return trades for token, use this to invert the chart.</param>
        /// <param name="tradingPeriod">["<c>trading_period</c>"] Lookback period for trades.</param>
        /// <param name="includeAnomalous">["<c>include_anomalous</c>"] Include trades flagged as anomalous.</param>
        /// <param name="cursor">["<c>cursor</c>"] Cursor from the previous response, passed back unchanged to fetch the next page.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexPoolTradesResponse>> GetPoolTradesAsync(
            string network,
            string poolAddress,
            decimal? tradeVolumeInUsdGreaterThan = null,
            string? token = null,
            DexTradingPeriod? tradingPeriod = null,
            bool? includeAnomalous = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Trades within Time Range by Pool Address. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/pool-trades-contract-address-range" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/pools/{pool_address}/trades/range
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="poolAddress">["<c>pool_address</c>"] Pool contract address.</param>
        /// <param name="from">["<c>from</c>"] Starting date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="to">["<c>to</c>"] Ending date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="tradeVolumeInUsdGreaterThan">["<c>trade_volume_in_usd_greater_than</c>"] Filter trades by trade volume in USD greater than this value.</param>
        /// <param name="token">["<c>token</c>"] Return trades for token, use this to invert the chart.</param>
        /// <param name="includeAnomalous">["<c>include_anomalous</c>"] Include trades flagged as anomalous.</param>
        /// <param name="cursor">["<c>cursor</c>"] Cursor from the previous response, passed back unchanged to fetch the next page.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexPoolTradesResponse>> GetPoolTradesRangeAsync(
            string network,
            string poolAddress,
            DateTime from,
            DateTime to,
            decimal? tradeVolumeInUsdGreaterThan = null,
            string? token = null,
            bool? includeAnomalous = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Liquidity Events by Pool Address. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/pool-liquidity-events-contract-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/pools/{pool_address}/liquidity_events
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="poolAddress">["<c>pool_address</c>"] Pool contract address.</param>
        /// <param name="kind">["<c>kind</c>"] Filter by liquidity event kind, omit to return both.</param>
        /// <param name="volumeInUsdGreaterThan">["<c>volume_in_usd_greater_than</c>"] Filter liquidity events by volume in USD greater than this value.</param>
        /// <param name="cursor">["<c>cursor</c>"] Cursor from the previous response, passed back unchanged to fetch the next page.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoPoolLiquidityEvents>> GetPoolLiquidityEventsAsync(
            string network,
            string poolAddress,
            PoolLiquidityEventsKind? kind = null,
            decimal? volumeInUsdGreaterThan = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Trades by Token Address. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/token-trades-contract-address" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/tokens/{token_address}/trades
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="tokenAddress">["<c>token_address</c>"] Token contract address.</param>
        /// <param name="tradeVolumeInUsdGreaterThan">["<c>trade_volume_in_usd_greater_than</c>"] Filter trades by trade volume in USD greater than this value.</param>
        /// <param name="tradingPeriod">["<c>trading_period</c>"] Lookback period for trades.</param>
        /// <param name="includeAnomalous">["<c>include_anomalous</c>"] Include trades flagged as anomalous.</param>
        /// <param name="cursor">["<c>cursor</c>"] Cursor from the previous response, passed back unchanged to fetch the next page.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexTokenTradesResponse>> GetTokenTradesAsync(
            string network,
            string tokenAddress,
            decimal? tradeVolumeInUsdGreaterThan = null,
            DexTradingPeriod? tradingPeriod = null,
            bool? includeAnomalous = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Trades within Time Range by Token Address. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/token-trades-contract-address-range" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/tokens/{token_address}/trades/range
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="tokenAddress">["<c>token_address</c>"] Token contract address.</param>
        /// <param name="from">["<c>from</c>"] Starting date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="to">["<c>to</c>"] Ending date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="tradeVolumeInUsdGreaterThan">["<c>trade_volume_in_usd_greater_than</c>"] Filter trades by trade volume in USD greater than this value.</param>
        /// <param name="includeAnomalous">["<c>include_anomalous</c>"] Include trades flagged as anomalous.</param>
        /// <param name="cursor">["<c>cursor</c>"] Cursor from the previous response, passed back unchanged to fetch the next page.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexTokenTradesResponse>> GetTokenTradesRangeAsync(
            string network,
            string tokenAddress,
            DateTime from,
            DateTime to,
            decimal? tradeVolumeInUsdGreaterThan = null,
            bool? includeAnomalous = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Token Balances by Wallet Address. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/wallet-token-balances" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/wallets/{address}/balances
        /// </para>
        /// </summary>
        /// <param name="address">["<c>address</c>"] Wallet address.</param>
        /// <param name="networks">["<c>networks</c>"] Query balances by networks, comma-separated if more than one.</param>
        /// <param name="sort">["<c>sort</c>"] Sort the holdings by field.</param>
        /// <param name="tokenType">["<c>token_type</c>"] Filter holdings by token type.</param>
        /// <param name="valueUsdMin">["<c>value_usd_min</c>"] Minimum holding value in USD.</param>
        /// <param name="reserveInUsdMin">["<c>reserve_in_usd_min</c>"] Minimum total reserve in USD of the holding's token.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoWalletTokenBalances>> GetWalletTokenBalancesAsync(
            string address,
            IEnumerable<string> networks,
            WalletTokenBalancesSort? sort = null,
            WalletTokenBalancesTokenType? tokenType = null,
            decimal? valueUsdMin = null,
            decimal? reserveInUsdMin = null,
            int? page = null,
            int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Token Transfers by Wallet Address. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/wallet-token-transfers" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/wallets/{address}/transfers
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="address">["<c>address</c>"] Wallet address.</param>
        /// <param name="token">["<c>token</c>"] Filter transfers by token contract address.</param>
        /// <param name="from">["<c>from</c>"] Starting date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="to">["<c>to</c>"] Ending date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="direction">["<c>direction</c>"] Filter transfers by direction, relative to the queried wallet.</param>
        /// <param name="cursor">["<c>cursor</c>"] Cursor from the previous response, passed back unchanged to fetch the next page.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoWalletTokenTransfers>> GetWalletTokenTransfersAsync(
            string network,
            string address,
            string? token = null,
            DateTime? from = null,
            DateTime? to = null,
            WalletTokenTransfersDirection? direction = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Trades by Wallet Address. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/wallet-trades" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/wallets/{address}/trades
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="address">["<c>address</c>"] Wallet address.</param>
        /// <param name="token">["<c>token</c>"] Filter trades by token contract address, returning only trades involving this token.</param>
        /// <param name="from">["<c>from</c>"] Starting date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="to">["<c>to</c>"] Ending date in ISO date string (YYYY-MM-DD or YYYY-MM-DDTHH:MM) or UNIX timestamp.</param>
        /// <param name="includeAnomalous">["<c>include_anomalous</c>"] Include trades flagged as anomalous.</param>
        /// <param name="cursor">["<c>cursor</c>"] Cursor from the previous response, passed back unchanged to fetch the next page.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoWalletTrades>> GetWalletTradesAsync(
            string network,
            string address,
            string? token = null,
            DateTime? from = null,
            DateTime? to = null,
            bool? includeAnomalous = null,
            string? cursor = null,
            int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// PnL by Wallet Address. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/wallet-pnl" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/wallets/{address}/pnl
        /// </para>
        /// </summary>
        /// <param name="address">["<c>address</c>"] Wallet address.</param>
        /// <param name="networks">["<c>networks</c>"] Query PnL by networks, comma-separated if more than one.</param>
        /// <param name="sort">["<c>sort</c>"] Sort the token stats by field.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="pageSize">["<c>per_page</c>"] Total results per page.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoWalletPnl>> GetWalletPnlAsync(
            string address,
            IEnumerable<string> networks,
            WalletPnlSort? sort = null,
            int? page = null,
            int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Categories List. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/categories-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/categories
        /// </para>
        /// </summary>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="sort">["<c>sort</c>"] Sort the categories by field.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoOnchainCategoriesList>> GetPoolCategoriesAsync(
            int? page = null,
            PoolCategoriesSort? sort = null,
            CancellationToken ct = default);

        /// <summary>
        /// Pools by Category ID. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/pools-category" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/categories/{category_id}/pools
        /// </para>
        /// </summary>
        /// <param name="categoryId">["<c>category_id</c>"] Category ID.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include, comma-separated if more than one.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="sort">["<c>sort</c>"] Sort the pools by field.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoCategoriesPools>> GetPoolsByCategoryAsync(
            string categoryId,
            IEnumerable<TrendingPoolsInclude>? include = null,
            int? page = null,
            PoolsByCategorySort? sort = null,
            CancellationToken ct = default);

        /// <summary>
        /// New Pools List. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/latest-pools-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/new_pools
        /// </para>
        /// </summary>
        /// <param name="include">["<c>include</c>"] Attributes to include, comma-separated if more than one.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="includeGtCommunityData">["<c>include_gt_community_data</c>"] Include GeckoTerminal community data (sentiment votes, suspicious reports).</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexPoolsResponse>> GetNewPoolsAsync(
            IEnumerable<TrendingPoolsInclude>? include = null,
            int? page = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default);

        /// <summary>
        /// New Pools by Network. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/latest-pools-network" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/new_pools
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include, comma-separated if more than one.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="includeGtCommunityData">["<c>include_gt_community_data</c>"] Include GeckoTerminal community data (sentiment votes, suspicious reports).</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexPoolsResponse>> GetNewPoolsByNetworkAsync(
            string network,
            IEnumerable<PoolInclude>? include = null,
            int? page = null,
            bool? includeGtCommunityData = null,
            CancellationToken ct = default);

        /// <summary>
        /// Multiple Pools Data by Pool Addresses. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/pools-addresses" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/pools/multi/{addresses}
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="addresses">["<c>addresses</c>"] Pool contract address, comma-separated if more than one pool contract address.</param>
        /// <param name="include">["<c>include</c>"] Attributes to include, comma-separated if more than one.</param>
        /// <param name="includeVolumeBreakdown">["<c>include_volume_breakdown</c>"] Include volume breakdown.</param>
        /// <param name="includeComposition">["<c>include_composition</c>"] Include pool composition.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexMultiPoolResponse>> GetPoolsAsync(
            string network,
            IEnumerable<string> addresses,
            IEnumerable<PoolInclude>? include = null,
            bool? includeVolumeBreakdown = null,
            bool? includeComposition = null,
            CancellationToken ct = default);

        /// <summary>
        /// Token Price by Token Addresses. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/onchain-simple-price" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/simple/networks/{network}/token_price/{addresses}
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="addresses">["<c>addresses</c>"] Token contract address, comma-separated if more than one token contract address.</param>
        /// <param name="includeMarketCap">["<c>include_market_cap</c>"] Include market capitalization.</param>
        /// <param name="mcapFdvFallback">["<c>mcap_fdv_fallback</c>"] Return FDV if market cap is not available.</param>
        /// <param name="include24hrVol">["<c>include_24hr_vol</c>"] Include 24hr volume.</param>
        /// <param name="include24hrPriceChange">["<c>include_24hr_price_change</c>"] Include 24hr price change.</param>
        /// <param name="includeTotalReserveInUsd">["<c>include_total_reserve_in_usd</c>"] Include total reserve in USD.</param>
        /// <param name="includeInactiveSource">["<c>include_inactive_source</c>"] Include token price data from inactive pools using the most recent swap.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoOnchainSimplePrice>> GetOnchainTokenPricesAsync(
            string network,
            IEnumerable<string> addresses,
            bool? includeMarketCap = null,
            bool? mcapFdvFallback = null,
            bool? include24hrVol = null,
            bool? include24hrPriceChange = null,
            bool? includeTotalReserveInUsd = null,
            bool? includeInactiveSource = null,
            CancellationToken ct = default);

        /// <summary>
        /// Token Price by Token Addresses across Networks. Requires a Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/onchain-simple-price-multi" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/simple/token_price/multi
        /// </para>
        /// </summary>
        /// <param name="tokens">["<c>tokens</c>"] Network ID and token contract address pairs in network_id:token_address format, comma-separated if more than one.</param>
        /// <param name="includeMarketCap">["<c>include_market_cap</c>"] Include market capitalization.</param>
        /// <param name="mcapFdvFallback">["<c>mcap_fdv_fallback</c>"] Return FDV if market cap is not available.</param>
        /// <param name="include24hrVol">["<c>include_24hr_vol</c>"] Include 24hr volume.</param>
        /// <param name="include24hrPriceChange">["<c>include_24hr_price_change</c>"] Include 24hr price change.</param>
        /// <param name="includeTotalReserveInUsd">["<c>include_total_reserve_in_usd</c>"] Include total reserve in USD.</param>
        /// <param name="includeInactiveSource">["<c>include_inactive_source</c>"] Include token price data from inactive pools using the most recent swap.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoOnchainSimplePriceMulti>> GetOnchainTokenPricesAcrossNetworksAsync(
            IEnumerable<string> tokens,
            bool? includeMarketCap = null,
            bool? mcapFdvFallback = null,
            bool? include24hrVol = null,
            bool? include24hrPriceChange = null,
            bool? includeTotalReserveInUsd = null,
            bool? includeInactiveSource = null,
            CancellationToken ct = default);

        /// <summary>
        /// DEXs List by Network. Requires a Demo or Pro API key.
        /// <para>
        /// Docs:<br />
        /// <a href="https://docs.coingecko.com/reference/dexes-list" /><br />
        /// Endpoint:<br />
        /// GET /api/v3/onchain/networks/{network}/dexes
        /// </para>
        /// </summary>
        /// <param name="network">["<c>network</c>"] Network ID.</param>
        /// <param name="page">["<c>page</c>"] Page through results.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinGeckoDexExchangesResponse>> GetDexesAsync(
            string network,
            int? page = null,
            CancellationToken ct = default);
    }
}
