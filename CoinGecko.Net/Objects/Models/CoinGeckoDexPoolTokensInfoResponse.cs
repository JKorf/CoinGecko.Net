using System.Text.Json.Serialization;
using CoinGecko.Net.Objects;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex Pool Tokens Info Response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolTokensInfoResponse
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoDexPoolTokenInfo[] Data { get; set; } = [];
        /// <summary>
        /// ["<c>included</c>"] Included pool data, present when include=pool is specified
        /// </summary>
        [JsonPropertyName("included")]
        public CoinGeckoDexPoolTokensInfoResponseIncludedItem[]? Included { get; set; }
    }

    /// <summary>
    /// Token metadata with its associated pool
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolTokenInfo : CoinGeckoTokenInfoItem
    {
        /// <summary>
        /// ["<c>relationships</c>"] Associated pool relationship
        /// </summary>
        [JsonPropertyName("relationships")]
        public CoinGeckoDexPoolTokenRelationships? Relationships { get; set; }
    }

    /// <summary>
    /// Pool token relationships
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolTokenRelationships
    {
        /// <summary>
        /// ["<c>pool</c>"] Pool identifier and resource type
        /// </summary>
        [JsonPropertyName("pool")]
        public CoinGeckoDexPoolRelationShipItem? Pool { get; set; }
    }

    /// <summary>
    /// Dex Pool Tokens Info Response Included Item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolTokensInfoResponseIncludedItem
    {
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        /// <summary>
        /// ["<c>type</c>"] Type
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// ["<c>attributes</c>"] Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public CoinGeckoDexPoolTokensInfoResponseIncludedItemAttributes? Attributes { get; set; }
    }

    /// <summary>
    /// Dex Pool Tokens Info Response Included Item Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolTokensInfoResponseIncludedItemAttributes
    {
        /// <summary>
        /// ["<c>base_token_address</c>"] Base token contract address
        /// </summary>
        [JsonPropertyName("base_token_address")]
        public string? BaseTokenAddress { get; set; }
        /// <summary>
        /// ["<c>quote_token_address</c>"] Quote token contract address
        /// </summary>
        [JsonPropertyName("quote_token_address")]
        public string? QuoteTokenAddress { get; set; }
        /// <summary>
        /// ["<c>quote_token_addresses</c>"] Quote token contract addresses, present for pools with more than 2 tokens
        /// </summary>
        [JsonPropertyName("quote_token_addresses")]
        public string[]? QuoteTokenAddresses { get; set; }
        /// <summary>
        /// ["<c>sentiment_vote_positive_percentage</c>"] GeckoTerminal community positive sentiment vote percentage
        /// </summary>
        [JsonPropertyName("sentiment_vote_positive_percentage")]
        public decimal? SentimentVotePositivePercentage { get; set; }
        /// <summary>
        /// ["<c>sentiment_vote_negative_percentage</c>"] GeckoTerminal community negative sentiment vote percentage
        /// </summary>
        [JsonPropertyName("sentiment_vote_negative_percentage")]
        public decimal? SentimentVoteNegativePercentage { get; set; }
        /// <summary>
        /// ["<c>community_sus_report</c>"] GeckoTerminal community suspicious reports count
        /// </summary>
        [JsonPropertyName("community_sus_report")]
        public long? CommunitySusReport { get; set; }
    }
}
