using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Search results
    /// </summary>
    [SerializationModel]
    public record CoinGeckoSearchResult
    {
        /// <summary>
        /// ["<c>coins</c>"] Assets found
        /// </summary>
        [JsonPropertyName("coins")]
        public CoinGeckoAssetResult[] Assets { get; set; } = Array.Empty<CoinGeckoAssetResult>();
        /// <summary>
        /// ["<c>exchanges</c>"] Exchanges found
        /// </summary>
        [JsonPropertyName("exchanges")]
        public CoinGeckoExchangeResult[] Exchanges { get; set; } = Array.Empty<CoinGeckoExchangeResult>();
        /// <summary>
        /// ["<c>categories</c>"] Categories found
        /// </summary>
        [JsonPropertyName("categories")]
        public CoinGeckoCategoryResult[] Categories { get; set; } = Array.Empty<CoinGeckoCategoryResult>();
        /// <summary>
        /// ["<c>nfts</c>"] Nfts found
        /// </summary>
        [JsonPropertyName("nfts")]
        public CoinGeckoNftResult[] Nfts { get; set; } = Array.Empty<CoinGeckoNftResult>();
        /// <summary>
        /// ["<c>icos</c>"] Icos
        /// </summary>
        [JsonPropertyName("icos")]
        public string[] Icos { get; set; } = Array.Empty<string>();
    }

    /// <summary>
    /// Asset result
    /// </summary>
    [SerializationModel]
    public record CoinGeckoAssetResult
    {
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>api_symbol</c>"] Api symbol
        /// </summary>
        [JsonPropertyName("api_symbol")]
        public string? ApiSymbol { get; set; }
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>market_cap_rank</c>"] Market cap rank
        /// </summary>
        [JsonPropertyName("market_cap_rank")]
        public int? MarketCapRank { get; set; }
        /// <summary>
        /// ["<c>thumb</c>"] Thumbnail
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? ThumbnailImage { get; set; }
        /// <summary>
        /// ["<c>large</c>"] Large image
        /// </summary>
        [JsonPropertyName("large")]
        public string? LargeImage { get; set; }
    }

    /// <summary>
    /// Exchange search result
    /// </summary>
    [SerializationModel]
    public record CoinGeckoExchangeResult
    {
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>market_type</c>"] Market type
        /// </summary>
        [JsonPropertyName("market_type")]
        public string MarketType { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>thumb</c>"] Thumbnail
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? ThumbnailImage { get; set; }
        /// <summary>
        /// ["<c>large</c>"] Large image
        /// </summary>
        [JsonPropertyName("large")]
        public string? LargeImage { get; set; }
    }

    /// <summary>
    /// Category search result
    /// </summary>
    [SerializationModel]
    public record CoinGeckoCategoryResult
    {
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    /// <summary>
    /// Nft search result
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNftResult
    {
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>thumb</c>"] Thumbnail
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? ThumbnailImage { get; set; }
    }
}
