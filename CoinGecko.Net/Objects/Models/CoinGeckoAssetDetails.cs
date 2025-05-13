using CryptoExchange.Net.Converters.SystemTextJson;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Asset details
    /// </summary>
    [SerializationModel]
    public record CoinGeckoAssetDetails
    {
        /// <summary>
        /// Id of the asset
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Symbol of the asset
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Name of the asset
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Asset web slug
        /// </summary>
        [JsonPropertyName("web_slug")]
        public string WebSlug { get; set; } = string.Empty;
        /// <summary>
        /// Main platform
        /// </summary>
        [JsonPropertyName("asset_platform_id")]
        public string AssetPlatformId { get; set; } = string.Empty;
        /// <summary>
        /// Smart contract addresses on different platforms
        /// </summary>
        [JsonPropertyName("platforms")]
        public Dictionary<string, string> Platforms { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// Platform details
        /// </summary>
        [JsonPropertyName("detail_platforms")]
        public Dictionary<string, CoinGeckoPlatform> PlatformDetails { get; set; } = new Dictionary<string, CoinGeckoPlatform>();
        /// <summary>
        /// Block generation time
        /// </summary>
        [JsonPropertyName("block_time_in_minutes")]
        public int? BlockTimeInMinutes { get; set; }
        /// <summary>
        /// Hashing algorithm
        /// </summary>
        [JsonPropertyName("hashing_algorithm")]
        public string HashingAlgorithm { get; set; } = string.Empty;
        /// <summary>
        /// Contract address
        /// </summary>
        [JsonPropertyName("contract_address")]
        public string? ContractAddress { get; set; }
        /// <summary>
        /// Categories
        /// </summary>
        [JsonPropertyName("categories")]
        public string[] Categories { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Preview listing
        /// </summary>
        [JsonPropertyName("preview_listing")]
        public bool PreviewListing { get; set; }
        /// <summary>
        /// Public notice
        /// </summary>
        [JsonPropertyName("public_notice")]
        public string PublicNotice { get; set; } = string.Empty;
        /// <summary>
        /// Additional notices
        /// </summary>
        [JsonPropertyName("additional_notices")]
        public string[] AdditionalNotice { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Name in different languages
        /// </summary>
        [JsonPropertyName("localization")]
        public Dictionary<string, string> Localization { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// Description in different languages
        /// </summary>
        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// Links
        /// </summary>
        [JsonPropertyName("links")]
        public CoinGeckoLinks Links { get; set; } = null!;
        /// <summary>
        /// Images
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoImages Image { get; set; } = null!;
        /// <summary>
        /// Country of origin
        /// </summary>
        [JsonPropertyName("country_origin")]
        public string CountryOrigin { get; set; } = string.Empty;
        /// <summary>
        /// Genesis block date
        /// </summary>
        [JsonPropertyName("genesis_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? GenesisDate { get; set; }
        /// <summary>
        /// Sentiment up votes percentage
        /// </summary>
        [JsonPropertyName("sentiment_votes_up_percentage")]
        public decimal? SentimentVotesUpPercentage { get; set; }
        /// <summary>
        /// Sentiment down votes percentage
        /// </summary>
        [JsonPropertyName("sentiment_votes_down_percentage")]
        public decimal? SentimentVotesDownPercentage { get; set; }
        /// <summary>
        /// Watchlist portfolio users
        /// </summary>
        [JsonPropertyName("watchlist_portfolio_users")]
        public int? WatchListPortfolioUsers { get; set; }
        /// <summary>
        /// Market cap rank
        /// </summary>
        [JsonPropertyName("market_cap_rank")]
        public int? MarketCapRank { get; set; }
        /// <summary>
        /// Market data
        /// </summary>
        [JsonPropertyName("market_data")]
        public CoinGeckoMarketData? MarketData { get; set; }
        /// <summary>
        /// Status updates
        /// </summary>
        [JsonPropertyName("status_updates")]
        public CoinGeckoStatusUpdate[] StatusUpdates { get; set; } = Array.Empty<CoinGeckoStatusUpdate>();
        /// <summary>
        /// Community data
        /// </summary>
        [JsonPropertyName("community_data")]
        public CoinGeckoCommunityData? CommunityData { get; set; }
        /// <summary>
        /// Developer data
        /// </summary>
        [JsonPropertyName("developer_data")]
        public CoinGeckoDeveloperData? DeveloperData { get; set; }
        /// <summary>
        /// Last updated
        /// </summary>
        [JsonPropertyName("last_updated")]
        public DateTime? LastUpdated { get; set; }
        /// <summary>
        /// Tickers
        /// </summary>
        [JsonPropertyName("tickers")]
        public CoinGeckoTicker[] Tickers { get; set; } = Array.Empty<CoinGeckoTicker>();
    }
}
