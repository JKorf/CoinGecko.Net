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
        /// ["<c>id</c>"] Id of the asset
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Symbol of the asset
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Name of the asset
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>web_slug</c>"] Asset web slug
        /// </summary>
        [JsonPropertyName("web_slug")]
        public string WebSlug { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>asset_platform_id</c>"] Main platform
        /// </summary>
        [JsonPropertyName("asset_platform_id")]
        public string AssetPlatformId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>platforms</c>"] Smart contract addresses on different platforms
        /// </summary>
        [JsonPropertyName("platforms")]
        public Dictionary<string, string> Platforms { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// ["<c>detail_platforms</c>"] Platform details
        /// </summary>
        [JsonPropertyName("detail_platforms")]
        public Dictionary<string, CoinGeckoPlatform> PlatformDetails { get; set; } = new Dictionary<string, CoinGeckoPlatform>();
        /// <summary>
        /// ["<c>block_time_in_minutes</c>"] Block generation time
        /// </summary>
        [JsonPropertyName("block_time_in_minutes")]
        public int? BlockTimeInMinutes { get; set; }
        /// <summary>
        /// ["<c>hashing_algorithm</c>"] Hashing algorithm
        /// </summary>
        [JsonPropertyName("hashing_algorithm")]
        public string HashingAlgorithm { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>contract_address</c>"] Contract address
        /// </summary>
        [JsonPropertyName("contract_address")]
        public string? ContractAddress { get; set; }
        /// <summary>
        /// ["<c>categories</c>"] Categories
        /// </summary>
        [JsonPropertyName("categories")]
        public string[] Categories { get; set; } = Array.Empty<string>();
        /// <summary>
        /// ["<c>preview_listing</c>"] Preview listing
        /// </summary>
        [JsonPropertyName("preview_listing")]
        public bool PreviewListing { get; set; }
        /// <summary>
        /// ["<c>public_notice</c>"] Public notice
        /// </summary>
        [JsonPropertyName("public_notice")]
        public string PublicNotice { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>additional_notices</c>"] Additional notices
        /// </summary>
        [JsonPropertyName("additional_notices")]
        public string[] AdditionalNotice { get; set; } = Array.Empty<string>();
        /// <summary>
        /// ["<c>localization</c>"] Name in different languages
        /// </summary>
        [JsonPropertyName("localization")]
        public Dictionary<string, string> Localization { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// ["<c>description</c>"] Description in different languages
        /// </summary>
        [JsonPropertyName("description")]
        public Dictionary<string, string> Description { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// ["<c>links</c>"] Links
        /// </summary>
        [JsonPropertyName("links")]
        public CoinGeckoLinks Links { get; set; } = null!;
        /// <summary>
        /// ["<c>image</c>"] Images
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoImages Image { get; set; } = null!;
        /// <summary>
        /// ["<c>country_origin</c>"] Country of origin
        /// </summary>
        [JsonPropertyName("country_origin")]
        public string CountryOrigin { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>genesis_date</c>"] Genesis block date
        /// </summary>
        [JsonPropertyName("genesis_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? GenesisDate { get; set; }
        /// <summary>
        /// ["<c>sentiment_votes_up_percentage</c>"] Sentiment up votes percentage
        /// </summary>
        [JsonPropertyName("sentiment_votes_up_percentage")]
        public decimal? SentimentVotesUpPercentage { get; set; }
        /// <summary>
        /// ["<c>sentiment_votes_down_percentage</c>"] Sentiment down votes percentage
        /// </summary>
        [JsonPropertyName("sentiment_votes_down_percentage")]
        public decimal? SentimentVotesDownPercentage { get; set; }
        /// <summary>
        /// ["<c>watchlist_portfolio_users</c>"] Watchlist portfolio users
        /// </summary>
        [JsonPropertyName("watchlist_portfolio_users")]
        public int? WatchListPortfolioUsers { get; set; }
        /// <summary>
        /// ["<c>market_cap_rank</c>"] Market cap rank
        /// </summary>
        [JsonPropertyName("market_cap_rank")]
        public int? MarketCapRank { get; set; }
        /// <summary>
        /// ["<c>market_data</c>"] Market data
        /// </summary>
        [JsonPropertyName("market_data")]
        public CoinGeckoMarketData? MarketData { get; set; }
        /// <summary>
        /// ["<c>status_updates</c>"] Status updates
        /// </summary>
        [JsonPropertyName("status_updates")]
        public CoinGeckoStatusUpdate[] StatusUpdates { get; set; } = Array.Empty<CoinGeckoStatusUpdate>();
        /// <summary>
        /// ["<c>community_data</c>"] Community data
        /// </summary>
        [JsonPropertyName("community_data")]
        public CoinGeckoCommunityData? CommunityData { get; set; }
        /// <summary>
        /// ["<c>developer_data</c>"] Developer data
        /// </summary>
        [JsonPropertyName("developer_data")]
        public CoinGeckoDeveloperData? DeveloperData { get; set; }
        /// <summary>
        /// ["<c>last_updated</c>"] Last updated
        /// </summary>
        [JsonPropertyName("last_updated")]
        public DateTime? LastUpdated { get; set; }
        /// <summary>
        /// ["<c>tickers</c>"] Tickers
        /// </summary>
        [JsonPropertyName("tickers")]
        public CoinGeckoTicker[] Tickers { get; set; } = Array.Empty<CoinGeckoTicker>();
    }
}
