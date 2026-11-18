using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Market Data Categories Order
    /// </summary>
    public enum MarketDataCategoriesOrder
    {
        /// <summary>
        /// <c>market_cap_desc</c>
        /// </summary>
        [Map("market_cap_desc")]
        MarketCapDesc,
        /// <summary>
        /// <c>market_cap_asc</c>
        /// </summary>
        [Map("market_cap_asc")]
        MarketCapAsc,
        /// <summary>
        /// <c>name_desc</c>
        /// </summary>
        [Map("name_desc")]
        NameDesc,
        /// <summary>
        /// <c>name_asc</c>
        /// </summary>
        [Map("name_asc")]
        NameAsc,
        /// <summary>
        /// <c>market_cap_change_24h_desc</c>
        /// </summary>
        [Map("market_cap_change_24h_desc")]
        MarketCapChange24hDesc,
        /// <summary>
        /// <c>market_cap_change_24h_asc</c>
        /// </summary>
        [Map("market_cap_change_24h_asc")]
        MarketCapChange24hAsc
    }
}
