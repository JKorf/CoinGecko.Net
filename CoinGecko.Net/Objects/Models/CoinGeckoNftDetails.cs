using Newtonsoft.Json;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Nft info
    /// </summary>
    public record CoinGeckoNftDetails
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Contract address
        /// </summary>
        [JsonProperty("contract_address")]
        public string ContractAddress { get; set; } = string.Empty;
        /// <summary>
        /// Platform id
        /// </summary>
        [JsonProperty("asset_platform_id")]
        public string AssetPlatformId { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Images
        /// </summary>
        [JsonProperty("image")]
        public CoinGeckoImages? Images { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Native currency
        /// </summary>
        [JsonProperty("native_currency")]
        public string NativeCurrency { get; set; } = string.Empty;
        /// <summary>
        /// Floor price 24h change percentage in USD
        /// </summary>
        [JsonProperty("floor_price_in_usd_24h_percentage_change")]
        public decimal? FloorPriceInUsd24hPercentageChange { get; set; }
        /// <summary>
        /// Number of unique addresses
        /// </summary>
        [JsonProperty("number_of_unique_addresses")]
        public int? NumberOfUniqueAddresses { get; set; }
        /// <summary>
        /// Number of unique address 24h change percentage
        /// </summary>
        [JsonProperty("number_of_unique_addresses_24h_percentage_change")]
        public int? NumberOfUniqueAddresses24hChangePercentage { get; set; }
        /// <summary>
        /// Total supply
        /// </summary>
        [JsonProperty("total_supply")]
        public int TotalSupply { get; set; }
        /// <summary>
        /// Floor price
        /// </summary>
        [JsonProperty("floor_price")]
        public CoinGeckoNftValue? FloorPrice { get; set; }
        /// <summary>
        /// Floor price
        /// </summary>
        [JsonProperty("market_cap")]
        public CoinGeckoNftValue? MarketCap { get; set; }
        /// <summary>
        /// Floor price
        /// </summary>
        [JsonProperty("volume_24h")]
        public CoinGeckoNftValue? Volume24h { get; set; }
    }

    /// <summary>
    /// Nft value info
    /// </summary>
    public record CoinGeckoNftValue
    {
        /// <summary>
        /// In native currency
        /// </summary>
        [JsonProperty("native_currency")]
        public decimal? NativeCurrency { get; set; }
        /// <summary>
        /// In usd
        /// </summary>
        public decimal? Usd { get; set; }
    }
}
