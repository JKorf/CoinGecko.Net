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
        /// Defi market cap
        /// </summary>
        [JsonPropertyName("defi_market_cap")]
        public decimal? DefiMarketCap { get; set; }
        /// <summary>
        /// Eth market cap
        /// </summary>
        [JsonPropertyName("eth_market_cap")]
        public decimal? EthMarketCap { get; set; }
        /// <summary>
        /// Defi to eth ratio
        /// </summary>
        [JsonPropertyName("defi_to_eth_ratio")]
        public decimal? DefiToEthRatio { get; set; }
        /// <summary>
        /// Trading volume 24h
        /// </summary>
        [JsonPropertyName("trading_volume_24h")]
        public decimal? TradingVolume24h { get; set; }
        /// <summary>
        /// Defi dominance
        /// </summary>
        [JsonPropertyName("defi_dominance")]
        public decimal? DefiDominance { get; set; }
        /// <summary>
        /// Top asset name
        /// </summary>
        [JsonPropertyName("top_coin_name")]
        public string TopAssetName { get; set; } = string.Empty;
        /// <summary>
        /// Top defi asset dominance
        /// </summary>
        [JsonPropertyName("top_coin_defi_dominance")]
        public decimal? TopAssetDefiDominance { get; set; }
    }
}
