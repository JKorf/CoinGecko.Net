using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Rwa Issuer Details
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaIssuerDetails
    {
        /// <summary>
        /// ["<c>id</c>"] Issuer ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Issuer name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>market_cap</c>"] Issuer market cap in USD
        /// </summary>
        [JsonPropertyName("market_cap")]
        public decimal? MarketCap { get; set; }
        /// <summary>
        /// ["<c>market_cap_change_24h</c>"] 24-hour issuer market cap change in USD
        /// </summary>
        [JsonPropertyName("market_cap_change_24h")]
        public decimal? MarketCapChange24h { get; set; }
        /// <summary>
        /// ["<c>volume_24h</c>"] 24-hour issuer trading volume in USD
        /// </summary>
        [JsonPropertyName("volume_24h")]
        public decimal? Volume24h { get; set; }
        /// <summary>
        /// ["<c>image</c>"] Issuer image URLs
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoRwaIssuerDetailsImage? Image { get; set; }
        /// <summary>
        /// ["<c>tokens</c>"] Tokens issued by this issuer
        /// </summary>
        [JsonPropertyName("tokens")]
        public CoinGeckoRwaIssuerDetailsToken[]? Tokens { get; set; }
        /// <summary>
        /// ["<c>updated_at</c>"] Issuer last updated timestamp
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    /// <summary>
    /// Rwa Issuer Details Image
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaIssuerDetailsImage
    {
        /// <summary>
        /// ["<c>thumb</c>"] Thumbnail image URL
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? Thumb { get; set; }
        /// <summary>
        /// ["<c>small</c>"] Small image URL
        /// </summary>
        [JsonPropertyName("small")]
        public string? Small { get; set; }
        /// <summary>
        /// ["<c>large</c>"] Large image URL
        /// </summary>
        [JsonPropertyName("large")]
        public string? Large { get; set; }
    }

    /// <summary>
    /// Rwa Issuer Details Token
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaIssuerDetailsToken
    {
        /// <summary>
        /// ["<c>id</c>"] Token ID
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        /// <summary>
        /// ["<c>symbol</c>"] Token symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
        /// <summary>
        /// ["<c>name</c>"] Token name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// ["<c>platforms</c>"] Token asset platform and contract address
        /// </summary>
        [JsonPropertyName("platforms")]
        public Dictionary<string, string>? Platforms { get; set; }
    }
}
