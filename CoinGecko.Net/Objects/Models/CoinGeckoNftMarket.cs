using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Nft Market
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNftMarket
    {
        /// <summary>
        /// ["<c>id</c>"] NFT collection ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>contract_address</c>"] NFT collection contract address
        /// </summary>
        [JsonPropertyName("contract_address")]
        public string? ContractAddress { get; set; }
        /// <summary>
        /// ["<c>asset_platform_id</c>"] NFT collection asset platform ID
        /// </summary>
        [JsonPropertyName("asset_platform_id")]
        public string AssetPlatformId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>name</c>"] NFT collection name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] NFT collection symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>image</c>"] NFT collection image URLs
        /// </summary>
        [JsonPropertyName("image")]
        public CoinGeckoNftMarketImage Image { get; set; } = new();
        /// <summary>
        /// ["<c>description</c>"] NFT collection description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
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
        /// ["<c>floor_price</c>"] NFT collection floor price
        /// </summary>
        [JsonPropertyName("floor_price")]
        public CoinGeckoNftMarketFloorPrice FloorPrice { get; set; } = new();
        /// <summary>
        /// ["<c>market_cap</c>"] NFT collection market cap
        /// </summary>
        [JsonPropertyName("market_cap")]
        public CoinGeckoNftMarketFloorPrice MarketCap { get; set; } = new();
        /// <summary>
        /// ["<c>volume_24h</c>"] NFT collection volume in 24 hours
        /// </summary>
        [JsonPropertyName("volume_24h")]
        public CoinGeckoNftMarketFloorPrice Volume24h { get; set; } = new();
        /// <summary>
        /// ["<c>floor_price_in_usd_24h_percentage_change</c>"] NFT collection floor price in USD 24 hours percentage change
        /// </summary>
        [JsonPropertyName("floor_price_in_usd_24h_percentage_change")]
        public decimal FloorPriceInUsd24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>floor_price_24h_percentage_change</c>"] NFT collection floor price 24 hours percentage change
        /// </summary>
        [JsonPropertyName("floor_price_24h_percentage_change")]
        public CoinGeckoNftMarketFloorPrice24hPercentageChange FloorPrice24hPercentageChange { get; set; } = new();
        /// <summary>
        /// ["<c>market_cap_24h_percentage_change</c>"] NFT collection market cap 24 hours percentage change
        /// </summary>
        [JsonPropertyName("market_cap_24h_percentage_change")]
        public CoinGeckoNftMarketFloorPrice24hPercentageChange MarketCap24hPercentageChange { get; set; } = new();
        /// <summary>
        /// ["<c>volume_24h_percentage_change</c>"] NFT collection volume in 24 hours percentage change
        /// </summary>
        [JsonPropertyName("volume_24h_percentage_change")]
        public CoinGeckoNftMarketFloorPrice24hPercentageChange Volume24hPercentageChange { get; set; } = new();
        /// <summary>
        /// ["<c>number_of_unique_addresses</c>"] Number of unique addresses owning the NFTs
        /// </summary>
        [JsonPropertyName("number_of_unique_addresses")]
        public decimal? NumberOfUniqueAddresses { get; set; }
        /// <summary>
        /// ["<c>number_of_unique_addresses_24h_percentage_change</c>"] Number of unique addresses 24 hours percentage change
        /// </summary>
        [JsonPropertyName("number_of_unique_addresses_24h_percentage_change")]
        public decimal NumberOfUniqueAddresses24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>volume_in_usd_24h_percentage_change</c>"] NFT collection volume in USD 24 hours percentage change
        /// </summary>
        [JsonPropertyName("volume_in_usd_24h_percentage_change")]
        public decimal VolumeInUsd24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>total_supply</c>"] NFT collection total supply
        /// </summary>
        [JsonPropertyName("total_supply")]
        public decimal? TotalSupply { get; set; }
        /// <summary>
        /// ["<c>one_day_sales</c>"] NFT collection one day sales
        /// </summary>
        [JsonPropertyName("one_day_sales")]
        public decimal? OneDaySales { get; set; }
        /// <summary>
        /// ["<c>one_day_sales_24h_percentage_change</c>"] NFT collection one day sales 24 hours percentage change
        /// </summary>
        [JsonPropertyName("one_day_sales_24h_percentage_change")]
        public decimal OneDaySales24hPercentageChange { get; set; }
        /// <summary>
        /// ["<c>one_day_average_sale_price</c>"] NFT collection one day average sale price
        /// </summary>
        [JsonPropertyName("one_day_average_sale_price")]
        public decimal? OneDayAverageSalePrice { get; set; }
        /// <summary>
        /// ["<c>one_day_average_sale_price_24h_percentage_change</c>"] NFT collection one day average sale price 24 hours percentage change
        /// </summary>
        [JsonPropertyName("one_day_average_sale_price_24h_percentage_change")]
        public decimal OneDayAverageSalePrice24hPercentageChange { get; set; }
    }

    /// <summary>
    /// Nft Market Image
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNftMarketImage
    {
        /// <summary>
        /// ["<c>small</c>"] Small
        /// </summary>
        [JsonPropertyName("small")]
        public string? Small { get; set; }
        /// <summary>
        /// ["<c>small_2x</c>"] Small2x
        /// </summary>
        [JsonPropertyName("small_2x")]
        public string? Small2x { get; set; }
    }

    /// <summary>
    /// Nft Market Floor Price
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNftMarketFloorPrice
    {
        /// <summary>
        /// ["<c>native_currency</c>"] NativeCurrency
        /// </summary>
        [JsonPropertyName("native_currency")]
        public decimal? NativeCurrency { get; set; }
        /// <summary>
        /// ["<c>usd</c>"] Usd
        /// </summary>
        [JsonPropertyName("usd")]
        public decimal? Usd { get; set; }
    }

    /// <summary>
    /// Nft Market Floor Price24h Percentage Change
    /// </summary>
    [SerializationModel]
    public record CoinGeckoNftMarketFloorPrice24hPercentageChange
    {
        /// <summary>
        /// ["<c>usd</c>"] Usd
        /// </summary>
        [JsonPropertyName("usd")]
        public decimal? Usd { get; set; }
        /// <summary>
        /// ["<c>native_currency</c>"] NativeCurrency
        /// </summary>
        [JsonPropertyName("native_currency")]
        public decimal? NativeCurrency { get; set; }
    }
}
