﻿
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Index info
    /// </summary>
    public record CoinGeckoIndex
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
        /// Market
        /// </summary>
        public string Market { get; set; } = string.Empty;
        /// <summary>
        /// Last
        /// </summary>
        public decimal? Last { get; set; }
        /// <summary>
        /// Is multi asset composite index
        /// </summary>
        [JsonPropertyName("is_multi_asset_composite")]
        public bool? IsMultiAssetComposite { get; set; }
    }
}
