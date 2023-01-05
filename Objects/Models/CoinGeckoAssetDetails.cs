using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Asset details
    /// </summary>
    public class CoinGeckoAssetDetails
    {
        /// <summary>
        /// Id of the asset
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Symbol of the asset
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Name of the asset
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Main platform
        /// </summary>
        [JsonProperty("asset_platform_id")]
        public string AssetPlatformId { get; set; } = string.Empty;
        /// <summary>
        /// Smart contract addresses on different platforms
        /// </summary>
        public Dictionary<string, string> Platforms { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// Platform details
        /// </summary>
        [JsonProperty("detail_platforms")]
        public Dictionary<string, CoinGeckoPlatform> PlatformDetails { get; set; } = new Dictionary<string, CoinGeckoPlatform>();
        /// <summary>
        /// Block generation time
        /// </summary>
        [JsonProperty("block_time_in_minutes")]
        public int BlockTimeInMinutes { get; set; }
        /// <summary>
        /// Hasing algorithm
        /// </summary>
        [JsonProperty("hashing_algorithm")]
        public string HashingAlgorithm { get; set; } = string.Empty;
        /// <summary>
        /// Categories
        /// </summary>
        public IEnumerable<string> Categories { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Public notice
        /// </summary>
        [JsonProperty("public_notice")]
        public string PublicNotice { get; set; } = string.Empty;
        /// <summary>
        /// Additional notices
        /// </summary>
        [JsonProperty("additional_notices")]
        public IEnumerable<string> AdditionalNotice { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Name in different languages
        /// </summary>
        public Dictionary<string, string> Localization { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// Description in different languages
        /// </summary>
        public Dictionary<string, string> Description { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// Links
        /// </summary>
        public CoinGeckoLinks Links { get; set; } = null!;
        /// <summary>
        /// Images
        /// </summary>
        public CoinGeckoImages Image { get; set; } = null!;
        /// <summary>
        /// Country of origin
        /// </summary>
        [JsonProperty("county_origin")]
        public string CountryOrigin { get; set; } = string.Empty;
        /// <summary>
        /// Genesis block date
        /// </summary>
        [JsonProperty("genisis_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? GenesisDate { get; set; }
        /// <summary>
        /// Contract address
        /// </summary>
        [JsonProperty("contract_address")]
        public string? ContractAddress { get; set; } = string.Empty;
        /// <summary>
        /// Sentiment up votes percentage
        /// </summary>
        [JsonProperty("sentiment_votes_up_percentage")]
        public decimal? SentimentVotesUpPercentage { get; set; }
        /// <summary>
        /// Sentiment down votes percentage
        /// </summary>
        [JsonProperty("sentiment_votes_down_percentage")]
        public decimal? SentimentVotesDownPercentage { get; set; }
        /// <summary>
        /// Ico data
        /// </summary>
        [JsonProperty("ico_data")]
        public CoinGeckoIcoData? IcoData { get; set; }
        /// <summary>
        /// Market cap rank
        /// </summary>
        [JsonProperty("market_cap_rank")]
        public int? MarketCapRank { get; set; }
        /// <summary>
        /// Coin gecko rank
        /// </summary>
        [JsonProperty("coin_gecko_rank")]
        public int CoinGeckoRank { get; set; }
        /// <summary>
        /// Coin gecko score
        /// </summary>
        [JsonProperty("coin_gecko_score")]
        public decimal CoinGeckoScore { get; set; }
        /// <summary>
        /// Developer score
        /// </summary>
        [JsonProperty("developer_score")]
        public decimal DeveloperScore { get; set; }
        /// <summary>
        /// Community score
        /// </summary>
        [JsonProperty("community_score")]
        public decimal CommunityScore { get; set; }
        /// <summary>
        /// Liquidity score
        /// </summary>
        [JsonProperty("liquidity_score")]
        public decimal LiquidityScore { get; set; }
        /// <summary>
        /// Public interest score
        /// </summary>
        [JsonProperty("public_interest_score")]
        public decimal PublicInterestScore { get; set; }
        /// <summary>
        /// Market data
        /// </summary>
        [JsonProperty("market_data")]
        public CoinGeckoMarketData? MarketData { get; set; }
        /// <summary>
        /// Community data
        /// </summary>
        [JsonProperty("community_data")]
        public CoinGeckoCommunityData? CommunityData { get; set; }
        /// <summary>
        /// Developer data
        /// </summary>
        [JsonProperty("developer_data")]
        public CoinGeckoDeveloperData? DeveloperData { get; set; }
    }

    /// <summary>
    /// Developer data
    /// </summary>
    public class CoinGeckoDeveloperData
    {
        /// <summary>
        /// Forks
        /// </summary>
        public int? Forks { get; set; }
        /// <summary>
        /// Stars
        /// </summary>
        public int? Stars { get; set; }
        /// <summary>
        /// Subscribers
        /// </summary>
        public int? Subscribers { get; set; }
        /// <summary>
        /// Total issues
        /// </summary>
        [JsonProperty("total_issues")]
        public int? TotalIssues { get; set; }
        /// <summary>
        /// Closed issues
        /// </summary>
        [JsonProperty("closed_issues")]
        public int? ClosedIssues { get; set; }
        /// <summary>
        /// Pull requests merged
        /// </summary>
        [JsonProperty("pull_requests_merged")]
        public int? PullRequestsMerged { get; set; }
        /// <summary>
        /// Pull request contributors
        /// </summary>
        [JsonProperty("pull_request_contributors")]
        public int? PullRequestContributors { get; set; }
        /// <summary>
        /// Code changes last 4 weeks
        /// </summary>
        [JsonProperty("code_additions_deletions_4_weeks")]
        public CoinGeckoCodeAddDel? CodeAdditionsDeletions4Weeks { get; set; }
        /// <summary>
        /// Amount of commits last 4 weeks
        /// </summary>
        [JsonProperty("commit_count_4_weeks")]
        public int? CommitCount4Weeks { get; set; }
        /// <summary>
        /// Commits series last 4 weeks
        /// </summary>
        [JsonProperty("last_4_weeks_commit_activity_series")]
        public IEnumerable<int> Last4WeeksCommitActivitySeries { get; set; } = new List<int>();
        /// <summary>
        /// Public interest statistics
        /// </summary>
        [JsonProperty("public_interest_stats")]
        public CoinGeckoPublicInterestStats? PublicInterestStats { get; set; }
        /// <summary>
        /// Status updates
        /// </summary>
        [JsonProperty("status_updates")]
        public IEnumerable<string> StatusUpdates { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Last updated
        /// </summary>
        [JsonProperty("last_updated")]
        public DateTime? LastUpdated { get; set; }
        /// <summary>
        /// Tickers
        /// </summary>
        public IEnumerable<CoinGeckoTicker> Tickers { get; set; } = Array.Empty<CoinGeckoTicker>();
    }

    /// <summary>
    /// Ticker info
    /// </summary>
    public class CoinGeckoTicker
    {
        /// <summary>
        /// Base asset
        /// </summary>
        public string Base { get; set; } = string.Empty;
        /// <summary>
        /// Quote asset
        /// </summary>
        public string Target { get; set; } = string.Empty;
        /// <summary>
        /// Market info
        /// </summary>
        public CoinGeckoAssetMarket? Market { get; set; }
        /// <summary>
        /// Last price
        /// </summary>
        public decimal? Last { get; set; }
        /// <summary>
        /// Trade volume
        /// </summary>
        public decimal? Volume { get; set; }
        /// <summary>
        /// Converted last
        /// </summary>
        [JsonProperty("converted_last")]
        public Dictionary<string, decimal> ConvertedLast { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Converted volume
        /// </summary>
        [JsonProperty("converted_volume")]
        public Dictionary<string, decimal> ConvertedVolume { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Trust score
        /// </summary>
        [JsonProperty("trust_score")]
        public int? TrustScore { get; set; }
        /// <summary>
        /// Difference in percentage between best bid and ask
        /// </summary>
        [JsonProperty("bid_ask_spread_percentage")]
        public decimal? BidAskSpreadPercentage { get; set; }
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Last trade timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("last_traded_at")]
        public DateTime? LastTradedAt { get; set; }
        /// <summary>
        /// Last fetch timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("last_fetch_at")]
        public DateTime? LastFetchAt { get; set; }
        /// <summary>
        /// Is anomaly
        /// </summary>
        [JsonProperty("is_anomaly")]
        public bool IsAnomaly { get; set; }
        /// <summary>
        /// Is stale
        /// </summary>
        [JsonProperty("is_stale")]
        public bool IsStale { get; set; }
        /// <summary>
        /// Trade url
        /// </summary>
        [JsonProperty("trade_url")]
        public string? TradeUrl { get; set; }
        /// <summary>
        /// Token info url
        /// </summary>
        [JsonProperty("token_info_url")]
        public string? TokenInfoUrl { get; set; }
        /// <summary>
        /// Coin id
        /// </summary>
        [JsonProperty("coin_id")]
        public string? CoinId { get; set; }
        /// <summary>
        /// Target coin id
        /// </summary>
        [JsonProperty("target_coin_id")]
        public string? TargetCoinId { get; set; }
    }

    /// <summary>
    /// Asset market info
    /// </summary>
    public class CoinGeckoAssetMarket
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Identifier
        /// </summary>
        public string Identifier { get; set; } = string.Empty;
        /// <summary>
        /// Has trading incentive
        /// </summary>
        public bool HasTradingIncentive { get; set; }
    }

    /// <summary>
    /// Public interest statistics
    /// </summary>
    public class CoinGeckoPublicInterestStats
    {
        /// <summary>
        /// Alexa rank
        /// </summary>
        [JsonProperty("alexa_rank")]
        public int? AlexaRank { get; set; }
        /// <summary>
        /// Bing matches
        /// </summary>
        [JsonProperty("bing_matches")]
        public int? BingMatches { get; set; }
    }

    /// <summary>
    /// Code additions/deletions
    /// </summary>
    public class CoinGeckoCodeAddDel
    {
        /// <summary>
        /// Lines added
        /// </summary>
        public int? Additions { get; set; }
        /// <summary>
        /// Lines deleted
        /// </summary>
        public int? Deletions { get; set; }
    }

    /// <summary>
    /// Community data
    /// </summary>
    public class CoinGeckoCommunityData
    {
        /// <summary>
        /// Facebook likes
        /// </summary>
        [JsonProperty("facebook_likes")]
        public int? FacebookLikes { get; set; }
        /// <summary>
        /// Twitter followers
        /// </summary>
        [JsonProperty("twitter_followers")]
        public int? TwitterFollowers { get; set; }
        /// <summary>
        /// Average amount of reddit posts per 48 hours
        /// </summary>
        [JsonProperty("reddit_average_posts_48h")]
        public decimal? RedditAveragePostsPer48h { get; set; }
        /// <summary>
        /// Average amount of reddit comments per 48 hours
        /// </summary>
        [JsonProperty("reddit_average_comments_48h")]
        public decimal? RedditAverageCommentsPer48h { get; set; }
        /// <summary>
        /// Reddit subscribers
        /// </summary>
        [JsonProperty("reddit_subscribers")]
        public int? RedditSubscribers { get; set; }
        /// <summary>
        /// Active reddit subscribers last 48 hours
        /// </summary>
        [JsonProperty("reddit_accounts_active_48h")]
        public decimal? RedditActiveAccounts48h { get; set; }
        /// <summary>
        /// Telegram channel user count
        /// </summary>
        [JsonProperty("telegram_channel_user_count")]
        public int? TelegramChannelUserCount { get; set; }
    }

    public class CoinGeckoMarketData
    {
        /// <summary>
        /// Current price
        /// </summary>
        [JsonProperty("current_price")]
        public Dictionary<string, decimal> CurrentPrice { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Total value locked
        /// </summary>
        [JsonProperty("total_value_locked")]
        public decimal? TotalValueLocked { get; set; }
        /// <summary>
        /// Market cap to total value locked ratio
        /// </summary>
        [JsonProperty("mcap_to_tvl_ratio")]
        public decimal? MarketCapToTotalValueLockedRatio { get; set; }
        /// <summary>
        /// Fully diluted valuation to total value locked ratio
        /// </summary>
        [JsonProperty("fdv_to_tvl_ratio")]
        public decimal? FullyDilutedValuationToTotalValueLockedRatio { get; set; }
        /// <summary>
        /// Return on investment
        /// </summary>
        public CoinGeckoMarketRoi? Roi { get; set; }
        /// <summary>
        /// All time high prices
        /// </summary>
        [JsonProperty("ath")]
        public Dictionary<string, decimal> AllTimeHighs { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Current price change vs all time high
        /// </summary>
        [JsonProperty("ath_change_percentage")]
        public Dictionary<string, decimal> AllTimeHighChangePercentages { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// All time high dates
        /// </summary>
        [JsonProperty("ath_date")]
        public Dictionary<string, DateTime> AllTimeHighDates { get; set; } = new Dictionary<string, DateTime>();
        /// <summary>
        /// All time low prices
        /// </summary>
        [JsonProperty("atl")]
        public Dictionary<string, decimal> AllTimeLows { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Current price change vs all time low
        /// </summary>
        [JsonProperty("atl_change_percentage")]
        public Dictionary<string, decimal> AllTimeLowChangePercentages { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// All time low dates
        /// </summary>
        [JsonProperty("atl_date")]
        public Dictionary<string, DateTime> AllTimeLowDates { get; set; } = new Dictionary<string, DateTime>();
        /// <summary>
        /// Market caps
        /// </summary>
        [JsonProperty("market_cap")]
        public Dictionary<string, decimal> MarketCaps { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Market cap rank
        /// </summary>
        [JsonProperty("market_cap_rank")]
        public int? MarketCapRank { get; set; }
        /// <summary>
        /// Fully diluted valuation
        /// </summary>
        [JsonProperty("fully_diluted_valuation")]
        public Dictionary<string, decimal> FullyDilutedValuations { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Total volumes
        /// </summary>
        [JsonProperty("total_volume")]
        public Dictionary<string, decimal> TotalVolumes { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// 24h high prices
        /// </summary>
        [JsonProperty("high_24h")]
        public Dictionary<string, decimal?> High24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 24h low prices
        /// </summary>
        [JsonProperty("low_24h")]
        public Dictionary<string, decimal?> Low24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 24h price change
        /// </summary>
        [JsonProperty("price_change_24h")]
        public decimal? PriceChange24h { get; set; }
        /// <summary>
        /// 24h price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_24h")]
        public decimal? PriceChangePercentage24h { get; set; }
        /// <summary>
        /// 7 day price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_7d")]
        public decimal PriceChangePercentage7d { get; set; }
        /// <summary>
        /// 14 day price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_14d")]
        public decimal PriceChangePercentage14d { get; set; }
        /// <summary>
        /// 30 day price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_30d")]
        public decimal PriceChangePercentage30d { get; set; }
        /// <summary>
        /// 60 day price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_60d")]
        public decimal PriceChangePercentage60d { get; set; }
        /// <summary>
        /// 200 day price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_200d")]
        public decimal PriceChangePercentage200d { get; set; }
        /// <summary>
        /// 1 year price change percentage
        /// </summary>
        [JsonProperty("price_change_percentage_1y")]
        public decimal PriceChangePercentage1y { get; set; }
        /// <summary>
        /// 24 hour market cap change
        /// </summary>
        [JsonProperty("market_cap_change_24h")]
        public decimal? MarketCapChange24h { get; set; }
        /// <summary>
        /// 24 hour market cap change
        /// </summary>
        [JsonProperty("market_cap_change_percentage_24h")]
        public decimal? MarketCapChangePercentage24h { get; set; }
        /// <summary>
        /// 24h price changes
        /// </summary>
        [JsonProperty("price_change_24h_in_currency")]
        public Dictionary<string, decimal?> PriceChanges24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 1h price changes percentages
        /// </summary>
        [JsonProperty("price_change_percentage_1h_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages1h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 24h price changes percentages
        /// </summary>
        [JsonProperty("price_change_percentage_24h_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 7d price change percentages
        /// </summary>
        [JsonProperty("price_change_percentage_7d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages7d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 14d price change percentages
        /// </summary>
        [JsonProperty("price_change_percentage_14d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages14d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 30d price change percentages
        /// </summary>
        [JsonProperty("price_change_percentage_30d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages30d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 60d price change percentages
        /// </summary>
        [JsonProperty("price_change_percentage_60d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages60d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 200d price change percentages
        /// </summary>
        [JsonProperty("price_change_percentage_200d_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages200d { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 1y price change percentages
        /// </summary>
        [JsonProperty("price_change_percentage_1y_in_currency")]
        public Dictionary<string, decimal?> PriceChangePerecentages1y { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 24h market cap changes
        /// </summary>
        [JsonProperty("market_cap_change_24h_in_currency")]
        public Dictionary<string, decimal?> MarketCapChanges24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// 24h market cap change percentages
        /// </summary>
        [JsonProperty("market_cap_change_percentage_24h_in_currency")]
        public Dictionary<string, decimal?> MarketCapChangePercentages24h { get; set; } = new Dictionary<string, decimal?>();
        /// <summary>
        /// Total supply
        /// </summary>
        [JsonProperty("total_supply")]
        public decimal? TotalSupply { get; set; }
        /// <summary>
        /// Max supply
        /// </summary>
        [JsonProperty("max_supply")]
        public decimal? MaxSupply { get; set; }
        /// <summary>
        /// Circulating supply
        /// </summary>
        [JsonProperty("ciculating_supply")]
        public decimal? CirculatingSupply { get; set; }
        /// <summary>
        /// Last updated timestamp
        /// </summary>
        [JsonProperty("last_updated")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? LastUpdated { get; set; }
    }

    /// <summary>
    /// Platform info
    /// </summary>
    public class CoinGeckoPlatform
    {
        /// <summary>
        /// Decimal places
        /// </summary>
        [JsonProperty("decimail_places")]
        public int DecimalPlaces { get; set; }
        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("contract_address")]
        public string ContractAddress { get; set; } = string.Empty;
    }

    /// <summary>
    /// Images
    /// </summary>
    public class CoinGeckoImages
    {
        /// <summary>
        /// Thumbnail
        /// </summary>
        public string Thumb { get; set; } = string.Empty;
        /// <summary>
        /// Small image
        /// </summary>
        public string Small { get; set; } = string.Empty;
        /// <summary>
        /// Large image
        /// </summary>
        public string Large { get; set; } = string.Empty;
    }

    /// <summary>
    /// Links
    /// </summary>
    public class CoinGeckoLinks
    {
        /// <summary>
        /// Homepage
        /// </summary>
        public IEnumerable<string> Homepage { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Blockchain explorer links
        /// </summary>
        [JsonProperty("blockchain_site")]
        public IEnumerable<string> BlockchainSites { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Official forum urls
        /// </summary>
        [JsonProperty("official_forum_url")]
        public IEnumerable<string> OfficialForumUrls { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Chat urls
        /// </summary>
        [JsonProperty("chat_url")]
        public IEnumerable<string> ChatUrls { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Announcement urls
        /// </summary>
        [JsonProperty("announcement_url")]
        public IEnumerable<string> AnnouncementUrls { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Twitter name
        /// </summary>
        [JsonProperty("twitter_screen_name")]
        public string TwitterScreenName { get; set; } = string.Empty;
        /// <summary>
        /// Facebook name
        /// </summary>
        [JsonProperty("facebook_username")]
        public string FacebookName { get; set; } = string.Empty;
        /// <summary>
        /// BitcoinTalk thread identifier
        /// </summary>
        [JsonProperty("bitcointalk_thread_identifier")]
        public string? BitcoinTalkThreadIdentifier { get; set; } = string.Empty;
        /// <summary>
        /// Telegram channel identifier
        /// </summary>
        [JsonProperty("telegram_channel_identifier")]
        public string? TelegramChannelIdentifier { get; set; } = string.Empty;
        /// <summary>
        /// Subreddit url
        /// </summary>
        [JsonProperty("subreddit_url")]
        public string? SubredditUrl { get; set; } = string.Empty;
        /// <summary>
        /// Git repository urls
        /// </summary>
        [JsonProperty("repos_url")]
        public Dictionary<string, IEnumerable<string>> RepoUrls { get; set; } = new Dictionary<string, IEnumerable<string>>();
    }

    /// <summary>
    /// Ico information
    /// </summary>
    public class CoinGeckoIcoData
    {
        /// <summary>
        /// Ico start date
        /// </summary>
        [JsonProperty("ico_start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? IcoStartDate { get; set; }
        /// <summary>
        /// Ico end date
        /// </summary>
        [JsonProperty("ico_end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? IcoEndDate { get; set; }
        /// <summary>
        /// Short description
        /// </summary>
        [JsonProperty("short_desc")]
        public string ShortDescription { get; set; } = string.Empty;
        /// <summary>
        /// Description
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Soft cap currency
        /// </summary>
        [JsonProperty("softcap_currency")]
        public string? SoftcapCurrency { get; set; }
        /// <summary>
        /// Hard cap currency
        /// </summary>
        [JsonProperty("hardcap_currency")]
        public string? HardcapCurrency { get; set; }
        /// <summary>
        /// Total raised currency
        /// </summary>
        [JsonProperty("total_raised_currency")]
        public string? TotalRaisedCurrency { get; set; }
        /// <summary>
        /// Softcap
        /// </summary>
        [JsonProperty("softcap_amount")]
        public decimal? SoftcapAmount { get; set; }
        /// <summary>
        /// Hardcap amount
        /// </summary>
        [JsonProperty("hardcap_amount")]
        public decimal? HardcapAmount { get; set; }
        /// <summary>
        /// Total raised
        /// </summary>
        [JsonProperty("total_raised")]
        public decimal? TotalRaised { get; set; }
        /// <summary>
        /// Quote pre-sale currency
        /// </summary>
        [JsonProperty("quote_pre_sale_currency")]
        public string QuotePreSaleCurrency { get; set; } = string.Empty;
        /// <summary>
        /// Base pre sale amount
        /// </summary>
        [JsonProperty("base_pre_sale_amount")]
        public string BasePreSaleAmount { get; set; } = string.Empty;
        /// <summary>
        /// Quote pre sale amount
        /// </summary>
        [JsonProperty("quote_pre_sale_amount")]
        public decimal? QuotePreSaleAmount { get; set; }
        /// <summary>
        /// Quote public sale currency
        /// </summary>
        [JsonProperty("quote_public_sale_currency")]
        public string QuotePublicSaleCurrency { get; set; } = string.Empty;
        /// <summary>
        /// Base public sale amount
        /// </summary>
        [JsonProperty("base_public_sale_amount")]
        public decimal? BasePublicSaleAmount { get; set; }
        /// <summary>
        /// Quote public sale amount
        /// </summary>
        [JsonProperty("quote_public_sale_amount")]
        public decimal? QuotePublicSaleAmount { get; set; }
        /// <summary>
        /// Accepting currencies
        /// </summary>
        [JsonProperty("accepting_currencies")]
        public string AcceptingCurrencies { get; set; } = string.Empty;
        /// <summary>
        /// Country origin
        /// </summary>
        [JsonProperty("country_origin")]
        public string CountryOrigin { get; set; } = string.Empty;
        /// <summary>
        /// Pre sale start date
        /// </summary>
        [JsonProperty("pre_sale_start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? PreSaleStartDate { get; set; }
        /// <summary>
        /// Pre sale end date
        /// </summary>
        [JsonProperty("pre_sale_end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? PreSaleEndDate { get; set; }
        /// <summary>
        /// Whitelist url
        /// </summary>
        [JsonProperty("whitelist_url")]
        public string WhitelistUrl { get; set; } = string.Empty;
        /// <summary>
        /// Whitelist start date
        /// </summary>
        [JsonProperty("whitelist_start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? WhitelistStartDate { get; set; }
        /// <summary>
        /// Whitelist end date
        /// </summary>
        [JsonProperty("whitelist_end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? WhitelistEndDate { get; set; }
        /// <summary>
        /// Bounty detail url
        /// </summary>
        [JsonProperty("bounty_detail_url")]
        public string BountyDetailUrl { get; set; } = string.Empty;
        /// <summary>
        /// Amount for sale
        /// </summary>
        [JsonProperty("amount_for_sale")]
        public decimal? AmountForSale { get; set; }
        /// <summary>
        /// KYC required
        /// </summary>
        [JsonProperty("kyc_required")]
        public bool KycRequired { get; set; }
        /// <summary>
        /// Whitelist available
        /// </summary>
        [JsonProperty("whitelist_available")]
        public bool? WhitelistAvailable { get; set; }
        /// <summary>
        /// Pre sale ended
        /// </summary>
        [JsonProperty("pre_sale_ended")]
        public bool PreSaleEnded { get; set; }
    }
}
