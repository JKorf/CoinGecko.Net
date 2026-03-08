using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Category info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMarketDataCategory
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
        /// ["<c>market_cap</c>"] Total market cap
        /// </summary>
        [JsonPropertyName("market_cap")]
        public decimal? MarketCap { get; set; }
        /// <summary>
        /// ["<c>market_cap_change_24h</c>"] Market cap change last 24h
        /// </summary>
        [JsonPropertyName("market_cap_change_24h")]
        public decimal? MarketCapChange24h { get; set; }
        /// <summary>
        /// ["<c>content</c>"] Content
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>top_3_coins_id</c>"] Top 3 coin id
        /// </summary>
        [JsonPropertyName("top_3_coins_id")]
        public string[] Top3CoinIds { get; set; } = Array.Empty<string>();
        /// <summary>
        /// ["<c>top_3_coins</c>"] Top 3 coins
        /// </summary>
        [JsonPropertyName("top_3_coins")]
        public string[] Top3Coins { get; set; } = Array.Empty<string>();
        /// <summary>
        /// ["<c>volume_24h</c>"] Volume last 24h
        /// </summary>
        [JsonPropertyName("volume_24h")]
        public decimal? Volume24h { get; set; }
        /// <summary>
        /// Last updated
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("updated_at")]
        public DateTime? LastUpdated { get; set; }
    }
}
