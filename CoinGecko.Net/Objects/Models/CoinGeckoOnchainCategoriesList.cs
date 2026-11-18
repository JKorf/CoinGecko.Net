using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Onchain Categories List
    /// </summary>
    [SerializationModel]
    public record CoinGeckoOnchainCategoriesList
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoOnchainCategoriesListData[] Data { get; set; } = [];
    }

    /// <summary>
    /// Onchain Categories List Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoOnchainCategoriesListData
    {
        /// <summary>
        /// ["<c>id</c>"] Category ID
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
        public CoinGeckoOnchainCategoriesListDataAttributes Attributes { get; set; } = new();
    }

    /// <summary>
    /// Onchain Categories List Data Attributes
    /// </summary>
    [SerializationModel]
    public record CoinGeckoOnchainCategoriesListDataAttributes
    {
        /// <summary>
        /// ["<c>name</c>"] Category name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>description</c>"] Category description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>volume_change_percentage</c>"] Volume change percentage over various timeframes
        /// </summary>
        [JsonPropertyName("volume_change_percentage")]
        public CoinGeckoOnchainCategoriesListDataAttributesVolumeChangePercentage VolumeChangePercentage { get; set; } = new();
        /// <summary>
        /// ["<c>reserve_in_usd</c>"] Total reserve in USD
        /// </summary>
        [JsonPropertyName("reserve_in_usd")]
        public decimal ReserveInUsd { get; set; }
        /// <summary>
        /// ["<c>fdv_usd</c>"] Fully diluted valuation in USD
        /// </summary>
        [JsonPropertyName("fdv_usd")]
        public decimal FdvUsd { get; set; }
        /// <summary>
        /// ["<c>h24_volume_usd</c>"] 24hr volume in USD
        /// </summary>
        [JsonPropertyName("h24_volume_usd")]
        public decimal H24VolumeUsd { get; set; }
        /// <summary>
        /// ["<c>h24_tx_count</c>"] 24hr transaction count
        /// </summary>
        [JsonPropertyName("h24_tx_count")]
        public long H24TxCount { get; set; }
    }

    /// <summary>
    /// Onchain Categories List Data Attributes Volume Change Percentage
    /// </summary>
    [SerializationModel]
    public record CoinGeckoOnchainCategoriesListDataAttributesVolumeChangePercentage
    {
        /// <summary>
        /// ["<c>h1</c>"] H1
        /// </summary>
        [JsonPropertyName("h1")]
        public string? H1 { get; set; }
        /// <summary>
        /// ["<c>h6</c>"] H6
        /// </summary>
        [JsonPropertyName("h6")]
        public string? H6 { get; set; }
        /// <summary>
        /// ["<c>h12</c>"] H12
        /// </summary>
        [JsonPropertyName("h12")]
        public string? H12 { get; set; }
        /// <summary>
        /// ["<c>h24</c>"] H24
        /// </summary>
        [JsonPropertyName("h24")]
        public string? H24 { get; set; }
    }
}
