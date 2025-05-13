using CryptoExchange.Net.Converters.SystemTextJson;
using System;
using System.Collections.Generic;
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
        /// Assets found
        /// </summary>
        [JsonPropertyName("coins")]
        public CoinGeckoAssetResult[] Assets { get; set; } = Array.Empty<CoinGeckoAssetResult>();
        /// <summary>
        /// Exchanges found
        /// </summary>
        [JsonPropertyName("exchanges")]
        public CoinGeckoExchangeResult[] Exchanges { get; set; } = Array.Empty<CoinGeckoExchangeResult>();
        /// <summary>
        /// Categories found
        /// </summary>
        [JsonPropertyName("categories")]
        public CoinGeckoCategoryResult[] Categories { get; set; } = Array.Empty<CoinGeckoCategoryResult>();
        /// <summary>
        /// Nfts found
        /// </summary>
        [JsonPropertyName("nfts")]
        public CoinGeckoNftResult[] Nfts { get; set; } = Array.Empty<CoinGeckoNftResult>();
        /// <summary>
        /// Icos
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
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Api symbol
        /// </summary>
        [JsonPropertyName("api_symbol")]
        public string? ApiSymbol { get; set; }
        /// <summary>
        /// Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Market cap rank
        /// </summary>
        [JsonPropertyName("market_cap_rank")]
        public int? MarketCapRank { get; set; }
        /// <summary>
        /// Thumbnail
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? ThumbnailImage { get; set; }
        /// <summary>
        /// Large image
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
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Market type
        /// </summary>
        [JsonPropertyName("market_type")]
        public string MarketType { get; set; } = string.Empty;
        /// <summary>
        /// Thumbnail
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? ThumbnailImage { get; set; }
        /// <summary>
        /// Large image
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
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
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
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Thumbnail
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? ThumbnailImage { get; set; }
    }
}
