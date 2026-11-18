using System.Text.Json;
using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Token Info Item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenInfoItem
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
        public CoinGeckoTokenInfoItemAttributes Attributes { get; set; } = new();
    }

    /// <summary>
    /// Token Info Item Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenInfoItemAttributes
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
        /// ["<c>image</c>"] Token image URLs in different sizes
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoTokenInfoItemAttributesImage Image { get; set; } = new();
        /// <summary>
        /// ["<c>banner_image_url</c>"] Token banner image URL
        /// </summary>
        [JsonPropertyName("banner_image_url")]
        public string? BannerImageUrl { get; set; }
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
        public decimal GtScore { get; set; }
        /// <summary>
        /// ["<c>gt_score_details</c>"] GeckoTerminal trust score breakdown
        /// </summary>
        [JsonPropertyName("gt_score_details")]
        public CoinGeckoTokenInfoItemAttributesGtScoreDetails GtScoreDetails { get; set; } = new();
        /// <summary>
        /// ["<c>gt_verified</c>"] Whether the token is verified on GeckoTerminal
        /// </summary>
        [JsonPropertyName("gt_verified")]
        public bool GtVerified { get; set; }
        /// <summary>
        /// ["<c>categories</c>"] Token categories
        /// </summary>
        [JsonPropertyName("categories")]
        public string[] Categories { get; set; } = [];
        /// <summary>
        /// ["<c>gt_category_ids</c>"] GeckoTerminal category IDs
        /// </summary>
        [JsonPropertyName("gt_category_ids")]
        public string[] GtCategoryIds { get; set; } = [];
        /// <summary>
        /// ["<c>holders</c>"] Token holder information
        /// </summary>
        [JsonPropertyName("holders")]
        public CoinGeckoTokenInfoItemAttributesHolders Holders { get; set; } = new();
        /// <summary>
        /// ["<c>mint_authority</c>"] Mint authority status
        /// </summary>
        [JsonPropertyName("mint_authority")]
        public string? MintAuthority { get; set; }
        /// <summary>
        /// ["<c>freeze_authority</c>"] Freeze authority status
        /// </summary>
        [JsonPropertyName("freeze_authority")]
        public string? FreezeAuthority { get; set; }
        /// <summary>
        /// ["<c>is_honeypot</c>"] Whether the token is a honeypot (boolean or 'unknown')
        /// </summary>
        [JsonPropertyName("is_honeypot")]
        public JsonElement IsHoneypot { get; set; }
        /// <summary>
        /// ["<c>is_nsfw</c>"] Whether the token's name or symbol matches the GeckoTerminal NSFW keyword list
        /// </summary>
        [JsonPropertyName("is_nsfw")]
        public bool IsNsfw { get; set; }
        /// <summary>
        /// ["<c>developer_address</c>"] Developer wallet address
        /// </summary>
        [JsonPropertyName("developer_address")]
        public string? DeveloperAddress { get; set; }
        /// <summary>
        /// ["<c>developer_holding_percentage</c>"] Developer holding as a percentage of total supply
        /// </summary>
        [JsonPropertyName("developer_holding_percentage")]
        public decimal? DeveloperHoldingPercentage { get; set; }
        /// <summary>
        /// ["<c>launchpad_details</c>"] Launchpad details for pump-style tokens
        /// </summary>
        [JsonPropertyName("launchpad_details")]
        public CoinGeckoTokenInfoItemAttributesLaunchpadDetails? LaunchpadDetails { get; set; }
    }

    /// <summary>
    /// Token Info Item Attributes Image
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenInfoItemAttributesImage
    {
        /// <summary>
        /// ["<c>thumb</c>"] Thumb
        /// </summary>
        [JsonPropertyName("thumb")]
        public string? Thumb { get; set; }
        /// <summary>
        /// ["<c>small</c>"] Small
        /// </summary>
        [JsonPropertyName("small")]
        public string? Small { get; set; }
        /// <summary>
        /// ["<c>large</c>"] Large
        /// </summary>
        [JsonPropertyName("large")]
        public string? Large { get; set; }
    }

    /// <summary>
    /// Token Info Item Attributes Gt Score Details
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenInfoItemAttributesGtScoreDetails
    {
        /// <summary>
        /// ["<c>pool</c>"] Pool
        /// </summary>
        [JsonPropertyName("pool")]
        public decimal? Pool { get; set; }
        /// <summary>
        /// ["<c>transaction</c>"] Transaction
        /// </summary>
        [JsonPropertyName("transaction")]
        public decimal? Transaction { get; set; }
        /// <summary>
        /// ["<c>creation</c>"] Creation
        /// </summary>
        [JsonPropertyName("creation")]
        public decimal? Creation { get; set; }
        /// <summary>
        /// ["<c>info</c>"] Info
        /// </summary>
        [JsonPropertyName("info")]
        public decimal? Info { get; set; }
        /// <summary>
        /// ["<c>holders</c>"] Holders
        /// </summary>
        [JsonPropertyName("holders")]
        public decimal? Holders { get; set; }
    }

    /// <summary>
    /// Token Info Item Attributes Holders
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenInfoItemAttributesHolders
    {
        /// <summary>
        /// ["<c>count</c>"] Number of holders
        /// </summary>
        [JsonPropertyName("count")]
        public long? Count { get; set; }
        /// <summary>
        /// ["<c>distribution_percentage</c>"] Holder distribution percentage (keys vary by chain, e.g. top_10, 11_30, 31_50, rest)
        /// </summary>
        [JsonPropertyName("distribution_percentage")]
        public Dictionary<string, decimal>? DistributionPercentage { get; set; }
        /// <summary>
        /// ["<c>last_updated</c>"] Last updated timestamp
        /// </summary>
        [JsonPropertyName("last_updated")]
        public DateTime? LastUpdated { get; set; }
    }

    /// <summary>
    /// Token Info Item Attributes Launchpad Details
    /// </summary>
    [SerializationModel]
    public record CoinGeckoTokenInfoItemAttributesLaunchpadDetails
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
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// ["<c>migrated_destination_pool_address</c>"] MigratedDestinationPoolAddress
        /// </summary>
        [JsonPropertyName("migrated_destination_pool_address")]
        public string? MigratedDestinationPoolAddress { get; set; }
    }
}
