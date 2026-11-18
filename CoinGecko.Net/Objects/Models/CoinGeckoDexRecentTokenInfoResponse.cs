using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex Recent Token Info Response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexRecentTokenInfoResponse
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoDexRecentTokenInfoResponseData[] Data { get; set; } = [];
        /// <summary>
        /// ["<c>included</c>"] Included network data, present when include=network is specified
        /// </summary>
        [JsonPropertyName("included")]
        public CoinGeckoDexRecentTokenInfoResponseIncludedItem[]? Included { get; set; }
    }

    /// <summary>
    /// Dex Recent Token Info Response Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexRecentTokenInfoResponseData
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
        public CoinGeckoDexRecentTokenInfoResponseDataAttributes Attributes { get; set; } = new();
        /// <summary>
        /// ["<c>relationships</c>"] Relationships
        /// </summary>
        [JsonPropertyName("relationships")]
        public CoinGeckoDexRecentTokenInfoResponseDataRelationships Relationships { get; set; } = new();
    }

    /// <summary>
    /// Dex Recent Token Info Response Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexRecentTokenInfoResponseDataAttributes
    {
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
        /// ["<c>websites</c>"] Token websites
        /// </summary>
        [JsonPropertyName("websites")]
        public string[] Websites { get; set; } = [];
        /// <summary>
        /// ["<c>discord_url</c>"] Discord URL
        /// </summary>
        [JsonPropertyName("discord_url")]
        public string? DiscordUrl { get; set; }
        /// <summary>
        /// ["<c>farcaster_url</c>"] Farcaster URL
        /// </summary>
        [JsonPropertyName("farcaster_url")]
        public string? FarcasterUrl { get; set; }
        /// <summary>
        /// ["<c>zora_url</c>"] Zora URL
        /// </summary>
        [JsonPropertyName("zora_url")]
        public string? ZoraUrl { get; set; }
        /// <summary>
        /// ["<c>telegram_handle</c>"] Telegram handle
        /// </summary>
        [JsonPropertyName("telegram_handle")]
        public string? TelegramHandle { get; set; }
        /// <summary>
        /// ["<c>twitter_handle</c>"] Twitter handle
        /// </summary>
        [JsonPropertyName("twitter_handle")]
        public string? TwitterHandle { get; set; }
        /// <summary>
        /// ["<c>description</c>"] Token description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        /// <summary>
        /// ["<c>gt_score</c>"] GeckoTerminal trust score
        /// </summary>
        [JsonPropertyName("gt_score")]
        public decimal? GtScore { get; set; }
        /// <summary>
        /// ["<c>metadata_updated_at</c>"] Metadata last updated timestamp
        /// </summary>
        [JsonPropertyName("metadata_updated_at")]
        public DateTime MetadataUpdatedAt { get; set; }
    }

    /// <summary>
    /// Dex Recent Token Info Response Data Relationships
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexRecentTokenInfoResponseDataRelationships
    {
        /// <summary>
        /// ["<c>network</c>"] Network
        /// </summary>
        [JsonPropertyName("network")]
        public CoinGeckoDexRecentTokenInfoResponseDataRelationshipsNetwork? Network { get; set; }
    }

    /// <summary>
    /// Dex Recent Token Info Response Data Relationships Network
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexRecentTokenInfoResponseDataRelationshipsNetwork
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoDexRecentTokenInfoResponseDataRelationshipsNetworkData? Data { get; set; }
    }

    /// <summary>
    /// Dex Recent Token Info Response Data Relationships Network Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexRecentTokenInfoResponseDataRelationshipsNetworkData
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

    /// <summary>
    /// Dex Recent Token Info Response Included Item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexRecentTokenInfoResponseIncludedItem
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
        /// <summary>
        /// ["<c>attributes</c>"] Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public CoinGeckoDexRecentTokenInfoResponseIncludedItemAttributes? Attributes { get; set; }
    }

    /// <summary>
    /// Dex Recent Token Info Response Included Item Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexRecentTokenInfoResponseIncludedItemAttributes
    {
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// ["<c>coingecko_asset_platform_id</c>"] CoingeckoAssetPlatformId
        /// </summary>
        [JsonPropertyName("coingecko_asset_platform_id")]
        public string? CoingeckoAssetPlatformId { get; set; }
    }
}
