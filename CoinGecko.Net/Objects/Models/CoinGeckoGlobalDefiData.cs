using Newtonsoft.Json;

namespace CoinGecko.Net.Objects.Models
{
    internal record CoinGeckoGlobalDefiDataWrapper
    {
        public CoinGeckoGlobalDefiData? Data { get; set; }
    }

    /// <summary>
    /// Global defi data
    /// </summary>
    public record CoinGeckoGlobalDefiData
    {
        /// <summary>
        /// Defi market cap
        /// </summary>
        [JsonProperty("defi_market_cap")]
        public decimal? DefiMarketCap { get; set; }
        /// <summary>
        /// Eth market cap
        /// </summary>
        [JsonProperty("eth_market_cap")]
        public decimal? EthMarketCap { get; set; }
        /// <summary>
        /// Defi to eth ratio
        /// </summary>
        [JsonProperty("defi_to_eth_ratio")]
        public decimal? DefiToEthRatio { get; set; }
        /// <summary>
        /// Trading volume 24h
        /// </summary>
        [JsonProperty("trading_volume_24h")]
        public decimal? TradingVolume24h { get; set; }
        /// <summary>
        /// Defi dominance
        /// </summary>
        [JsonProperty("defi_dominance")]
        public decimal? DefiDominance { get; set; }
        /// <summary>
        /// Top asset name
        /// </summary>
        [JsonProperty("top_coin_name")]
        public string TopAssetName { get; set; } = string.Empty;
        /// <summary>
        /// Top defi asset dominance
        /// </summary>
        [JsonProperty("top_coin_defi_dominance")]
        public decimal? TopAssetDefiDominance { get; set; }
    }
}
