using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Nft Ticker
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNftTicker
    {
        /// <summary>
        /// ["<c>tickers</c>"] Tickers
        /// </summary>
        [JsonPropertyName("tickers")]
        public CoinGeckoNftTickerTicker[] Tickers { get; set; } = [];
    }

    /// <summary>
    /// Nft Ticker Ticker
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNftTickerTicker
    {
        /// <summary>
        /// ["<c>floor_price_in_native_currency</c>"] NFT collection floor price in native currency
        /// </summary>
        [JsonPropertyName("floor_price_in_native_currency")]
        public decimal FloorPriceInNativeCurrency { get; set; }
        /// <summary>
        /// ["<c>h24_volume_in_native_currency</c>"] NFT collection volume in 24 hours in native currency
        /// </summary>
        [JsonPropertyName("h24_volume_in_native_currency")]
        public decimal H24VolumeInNativeCurrency { get; set; }
        /// <summary>
        /// ["<c>native_currency</c>"] NFT collection native currency
        /// </summary>
        [JsonPropertyName("native_currency")]
        public string NativeCurrency { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>native_currency_symbol</c>"] NFT collection native currency symbol
        /// </summary>
        [JsonPropertyName("native_currency_symbol")]
        public string NativeCurrencySymbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>updated_at</c>"] Last updated time
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        /// <summary>
        /// ["<c>nft_marketplace_id</c>"] NFT marketplace ID
        /// </summary>
        [JsonPropertyName("nft_marketplace_id")]
        public string NftMarketplaceId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] NFT marketplace name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>image</c>"] NFT marketplace image URL
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>nft_collection_url</c>"] NFT collection URL in the NFT marketplace
        /// </summary>
        [JsonPropertyName("nft_collection_url")]
        public string NftCollectionUrl { get; set; } = string.Empty;
    }
}
