using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    [SerializationModel]
    internal record CoinGeckoGlobalDefiDataWrapper
    {
        [JsonPropertyName("data")]
        public CoinGeckoGlobalDefiData? Data { get; set; }
    }

    /// <summary>
    /// Global defi data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoGlobalDefiData
    {
        /// <summary>
        /// ["<c>defi_market_cap</c>"] Defi market cap
        /// </summary>
        [JsonPropertyName("defi_market_cap")]
        public decimal? DefiMarketCap { get; set; }
        /// <summary>
        /// ["<c>eth_market_cap</c>"] Eth market cap
        /// </summary>
        [JsonPropertyName("eth_market_cap")]
        public decimal? EthMarketCap { get; set; }
        /// <summary>
        /// ["<c>defi_to_eth_ratio</c>"] Defi to eth ratio
        /// </summary>
        [JsonPropertyName("defi_to_eth_ratio")]
        public decimal? DefiToEthRatio { get; set; }
        /// <summary>
        /// ["<c>trading_volume_24h</c>"] Trading volume 24h
        /// </summary>
        [JsonPropertyName("trading_volume_24h")]
        public decimal? TradingVolume24h { get; set; }
        /// <summary>
        /// ["<c>defi_dominance</c>"] Defi dominance
        /// </summary>
        [JsonPropertyName("defi_dominance")]
        public decimal? DefiDominance { get; set; }
        /// <summary>
        /// ["<c>top_coin_name</c>"] Top asset name
        /// </summary>
        [JsonPropertyName("top_coin_name")]
        public string TopAssetName { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>top_coin_defi_dominance</c>"] Top defi asset dominance
        /// </summary>
        [JsonPropertyName("top_coin_defi_dominance")]
        public decimal? TopAssetDefiDominance { get; set; }
    }
}
