using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Nft Market Chart
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNftMarketChart
    {
        /// <summary>
        /// ["<c>floor_price_usd</c>"] NFT collection floor price in USD as [timestamp, price] pairs
        /// </summary>
        [JsonPropertyName("floor_price_usd")]
        public CoinGeckoMarketChartValue[] FloorPriceUsd { get; set; } = [];
        /// <summary>
        /// ["<c>floor_price_native</c>"] NFT collection floor price in native currency as [timestamp, price] pairs
        /// </summary>
        [JsonPropertyName("floor_price_native")]
        public CoinGeckoMarketChartValue[] FloorPriceNative { get; set; } = [];
        /// <summary>
        /// ["<c>h24_volume_usd</c>"] NFT collection 24h volume in USD as [timestamp, volume] pairs
        /// </summary>
        [JsonPropertyName("h24_volume_usd")]
        public CoinGeckoMarketChartValue[] H24VolumeUsd { get; set; } = [];
        /// <summary>
        /// ["<c>h24_volume_native</c>"] NFT collection 24h volume in native currency as [timestamp, volume] pairs
        /// </summary>
        [JsonPropertyName("h24_volume_native")]
        public CoinGeckoMarketChartValue[] H24VolumeNative { get; set; } = [];
        /// <summary>
        /// ["<c>market_cap_usd</c>"] NFT collection market cap in USD as [timestamp, market_cap] pairs
        /// </summary>
        [JsonPropertyName("market_cap_usd")]
        public CoinGeckoMarketChartValue[] MarketCapUsd { get; set; } = [];
        /// <summary>
        /// ["<c>market_cap_native</c>"] NFT collection market cap in native currency as [timestamp, market_cap] pairs
        /// </summary>
        [JsonPropertyName("market_cap_native")]
        public CoinGeckoMarketChartValue[] MarketCapNative { get; set; } = [];
    }
}
