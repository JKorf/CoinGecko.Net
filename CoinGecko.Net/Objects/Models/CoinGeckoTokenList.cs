using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Token List
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenList
    {
        /// <summary>
        /// ["<c>name</c>"] Token list name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>logoURI</c>"] Token list logo URL
        /// </summary>
        [JsonPropertyName("logoURI")]
        public string LogoUri { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>keywords</c>"] Token list keywords
        /// </summary>
        [JsonPropertyName("keywords")]
        public string[] Keywords { get; set; } = [];
        /// <summary>
        /// ["<c>timestamp</c>"] Token list generation timestamp
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// ["<c>tokens</c>"] List of tokens
        /// </summary>
        [JsonPropertyName("tokens")]
        public CoinGeckoTokenListToken[] Tokens { get; set; } = [];
        /// <summary>
        /// ["<c>version</c>"] Token list version
        /// </summary>
        [JsonPropertyName("version")]
        public CoinGeckoTokenListVersion Version { get; set; } = new();
    }

    /// <summary>
    /// Token List Token
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenListToken
    {
        /// <summary>
        /// ["<c>chainId</c>"] Chainlist's chain ID
        /// </summary>
        [JsonPropertyName("chainId")]
        public int ChainId { get; set; }
        /// <summary>
        /// ["<c>address</c>"] Token contract address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] Token name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Token symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>decimals</c>"] Token decimals
        /// </summary>
        [JsonPropertyName("decimals")]
        public int Decimals { get; set; }
        /// <summary>
        /// ["<c>logoURI</c>"] Token image URL
        /// </summary>
        [JsonPropertyName("logoURI")]
        public string LogoUri { get; set; } = string.Empty;
    }

    /// <summary>
    /// Token List Version
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenListVersion
    {
        /// <summary>
        /// ["<c>major</c>"] Major version
        /// </summary>
        [JsonPropertyName("major")]
        public int? Major { get; set; }
        /// <summary>
        /// ["<c>minor</c>"] Minor version
        /// </summary>
        [JsonPropertyName("minor")]
        public int? Minor { get; set; }
        /// <summary>
        /// ["<c>patch</c>"] Patch version
        /// </summary>
        [JsonPropertyName("patch")]
        public int? Patch { get; set; }
    }
}
