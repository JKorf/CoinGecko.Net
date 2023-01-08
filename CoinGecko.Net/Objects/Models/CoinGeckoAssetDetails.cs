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
        [JsonProperty("country_origin")]
        public string CountryOrigin { get; set; } = string.Empty;
        /// <summary>
        /// Genesis block date
        /// </summary>
        [JsonProperty("genesis_date")]
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
        [JsonProperty("coingecko_rank")]
        public int CoinGeckoRank { get; set; }
        /// <summary>
        /// Coin gecko score
        /// </summary>
        [JsonProperty("coingecko_score")]
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
        /// Community data
        /// </summary>
        [JsonProperty("community_data")]
        public CoinGeckoCommunityData? CommunityData { get; set; }
        /// <summary>
        /// Developer data
        /// </summary>
        [JsonProperty("developer_data")]
        public CoinGeckoDeveloperData? DeveloperData { get; set; }
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
}
