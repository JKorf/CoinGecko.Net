using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Search results
    /// </summary>
    public class CoinGeckoSearchResult
    {
        /// <summary>
        /// Assets found
        /// </summary>
        [JsonProperty("coins")]
        public IEnumerable<CoinGeckoAssetResult> Assets { get; set; } = Array.Empty<CoinGeckoAssetResult>();
        /// <summary>
        /// Exchanges found
        /// </summary>
        public IEnumerable<CoinGeckoExchangeResult> Exchanges { get; set; } = Array.Empty<CoinGeckoExchangeResult>();
        /// <summary>
        /// Categories found
        /// </summary>
        public IEnumerable<CoinGeckoCategoryResult> Categories { get; set; } = Array.Empty<CoinGeckoCategoryResult>();
        /// <summary>
        /// Nfts found
        /// </summary>
        public IEnumerable<CoinGeckoNftResult> Nfts { get; set; } = Array.Empty<CoinGeckoNftResult>();
    }

    /// <summary>
    /// Asset result
    /// </summary>
    public class CoinGeckoAssetResult
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Api symbol
        /// </summary>
        [JsonProperty("api_symbol")]
        public string? ApiSymbol { get; set; }
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Market cap rank
        /// </summary>
        [JsonProperty("market_cap_rank")]
        public int? MarketCapRank { get; set; }
        /// <summary>
        /// Thumbnail
        /// </summary>
        [JsonProperty("thumb")]
        public string? ThumbnailImage { get; set; }
        /// <summary>
        /// Large image
        /// </summary>
        [JsonProperty("large")]
        public string? LargeImage { get; set; }
    }

    /// <summary>
    /// Exchange search result
    /// </summary>
    public class CoinGeckoExchangeResult
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Market type
        /// </summary>
        [JsonProperty("market_type")]
        public string MarketType { get; set; } = string.Empty;
        /// <summary>
        /// Thumbnail
        /// </summary>
        [JsonProperty("thumb")]
        public string? ThumbnailImage { get; set; }
        /// <summary>
        /// Large image
        /// </summary>
        [JsonProperty("large")]
        public string? LargeImage { get; set; }
    }

    /// <summary>
    /// Category search result
    /// </summary>
    public class CoinGeckoCategoryResult
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;        
    }

    /// <summary>
    /// Nft search result
    /// </summary>
    public class CoinGeckoNftResult
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Thumbnail
        /// </summary>
        [JsonProperty("thumb")]
        public string? ThumbnailImage { get; set; }
    }
}
