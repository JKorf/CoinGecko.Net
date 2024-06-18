using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Trending searches
    /// </summary>
    public record CoinGeckoTrendingSearch
    {
        /// <summary>
        /// Trending assets
        /// </summary>
        [JsonProperty("coins")]
        public IEnumerable<ItemWrapper<CoinGeckoTrendingAsset>> Assets { get; set; } = Array.Empty<ItemWrapper<CoinGeckoTrendingAsset>>();
    }

    /// <summary>
    /// Trending asset
    /// </summary>
    public record CoinGeckoTrendingAsset
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Asset id
        /// </summary>
        [JsonProperty("coin_id")]
        public string AssetId { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
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
        /// Thumbnail image
        /// </summary>
        [JsonProperty("thumb")]
        public string? ThumbnailImage { get; set; }
        /// <summary>
        /// Small image
        /// </summary>
        [JsonProperty("small")]
        public string? SmallImage { get; set; }
        /// <summary>
        /// Large image
        /// </summary>
        [JsonProperty("large")]
        public string? LargeImage { get; set; }
        /// <summary>
        /// Slug
        /// </summary>
        public string? Slug { get; set; }
        /// <summary>
        /// Btc price
        /// </summary>
        [JsonProperty("price_btc")]
        public decimal? PriceBtc { get; set; }
        /// <summary>
        /// Score
        /// </summary>
        public int Score { get; set; }
    }

    /// <summary>
    /// Item
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public record ItemWrapper<T>
    {
        /// <summary>
        /// Item info
        /// </summary>
        public T Item { get; set; } = default!;
    }
}
