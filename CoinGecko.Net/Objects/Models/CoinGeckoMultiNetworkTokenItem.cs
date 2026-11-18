using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Multi Network Token Item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMultiNetworkTokenItem
    {
        /// <summary>
        /// ["<c>id</c>"] Token identifier
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>type</c>"] Resource type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>attributes</c>"] Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public CoinGeckoMultiNetworkTokenItemAttributes Attributes { get; set; } = new();
        /// <summary>
        /// ["<c>relationships</c>"] Relationships
        /// </summary>
        [JsonPropertyName("relationships")]
        public CoinGeckoMultiNetworkTokenItemRelationships Relationships { get; set; } = new();
    }

    /// <summary>
    /// Multi Network Token Item Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMultiNetworkTokenItemAttributes
    {
        /// <summary>
        /// ["<c>network</c>"] Network ID of the token
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; } = string.Empty;
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
        public long Decimals { get; set; }
        /// <summary>
        /// ["<c>image_url</c>"] Token image URL
        /// </summary>
        [JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }
        /// <summary>
        /// ["<c>coingecko_coin_id</c>"] CoinGecko coin ID
        /// </summary>
        [JsonPropertyName("coingecko_coin_id")]
        public string? CoingeckoCoinId { get; set; }
        /// <summary>
        /// ["<c>total_supply</c>"] Token total supply
        /// </summary>
        [JsonPropertyName("total_supply")]
        public decimal TotalSupply { get; set; }
        /// <summary>
        /// ["<c>normalized_total_supply</c>"] Normalized token total supply
        /// </summary>
        [JsonPropertyName("normalized_total_supply")]
        public decimal NormalizedTotalSupply { get; set; }
        /// <summary>
        /// ["<c>price_usd</c>"] Token price in USD
        /// </summary>
        [JsonPropertyName("price_usd")]
        public decimal? PriceUsd { get; set; }
        /// <summary>
        /// ["<c>fdv_usd</c>"] Fully diluted valuation in USD
        /// </summary>
        [JsonPropertyName("fdv_usd")]
        public decimal? FdvUsd { get; set; }
        /// <summary>
        /// ["<c>total_reserve_in_usd</c>"] Total reserve in USD across all pools
        /// </summary>
        [JsonPropertyName("total_reserve_in_usd")]
        public string? TotalReserveInUsd { get; set; }
        /// <summary>
        /// ["<c>volume_usd</c>"] Volume in USD
        /// </summary>
        [JsonPropertyName("volume_usd")]
        public CoinGeckoMultiNetworkTokenItemAttributesVolumeUsd VolumeUsd { get; set; } = new();
        /// <summary>
        /// ["<c>market_cap_usd</c>"] Market cap in USD
        /// </summary>
        [JsonPropertyName("market_cap_usd")]
        public string? MarketCapUsd { get; set; }
        /// <summary>
        /// ["<c>last_trade_timestamp</c>"] Last trade timestamp in UNIX
        /// </summary>
        [JsonPropertyName("last_trade_timestamp")]
        public string? LastTradeTimestamp { get; set; }
        /// <summary>
        /// ["<c>launchpad_details</c>"] Launchpad details for pump-style tokens
        /// </summary>
        [JsonPropertyName("launchpad_details")]
        public CoinGeckoMultiNetworkTokenItemAttributesLaunchpadDetails? LaunchpadDetails { get; set; }
    }

    /// <summary>
    /// Multi Network Token Item Attributes Volume Usd
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMultiNetworkTokenItemAttributesVolumeUsd
    {
        /// <summary>
        /// ["<c>h24</c>"] H24
        /// </summary>
        [JsonPropertyName("h24")]
        public string? H24 { get; set; }
    }

    /// <summary>
    /// Multi Network Token Item Attributes Launchpad Details
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMultiNetworkTokenItemAttributesLaunchpadDetails
    {
        /// <summary>
        /// ["<c>graduation_percentage</c>"] GraduationPercentage
        /// </summary>
        [JsonPropertyName("graduation_percentage")]
        public decimal? GraduationPercentage { get; set; }
        /// <summary>
        /// ["<c>completed</c>"] Completed
        /// </summary>
        [JsonPropertyName("completed")]
        public bool? Completed { get; set; }
        /// <summary>
        /// ["<c>completed_at</c>"] CompletedAt
        /// </summary>
        [JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }
        /// <summary>
        /// ["<c>migrated_destination_pool_address</c>"] MigratedDestinationPoolAddress
        /// </summary>
        [JsonPropertyName("migrated_destination_pool_address")]
        public string? MigratedDestinationPoolAddress { get; set; }
    }

    /// <summary>
    /// Multi Network Token Item Relationships
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMultiNetworkTokenItemRelationships
    {
        /// <summary>
        /// ["<c>top_pools</c>"] TopPools
        /// </summary>
        [JsonPropertyName("top_pools")]
        public CoinGeckoMultiNetworkTokenItemRelationshipsTopPools? TopPools { get; set; }
    }

    /// <summary>
    /// Multi Network Token Item Relationships Top Pools
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMultiNetworkTokenItemRelationshipsTopPools
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoMultiNetworkTokenItemRelationshipsTopPoolsData[]? Data { get; set; }
    }

    /// <summary>
    /// Multi Network Token Item Relationships Top Pools Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoMultiNetworkTokenItemRelationshipsTopPoolsData
    {
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        /// <summary>
        /// ["<c>type</c>"] Type
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
