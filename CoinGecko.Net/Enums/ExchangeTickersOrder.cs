using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Exchange Tickers Order
    /// </summary>
    public enum ExchangeTickersOrder
    {
        /// <summary>
        /// <c>market_cap_asc</c>
        /// </summary>
        [Map("market_cap_asc")]
        MarketCapAsc,
        /// <summary>
        /// <c>market_cap_desc</c>
        /// </summary>
        [Map("market_cap_desc")]
        MarketCapDesc,
        /// <summary>
        /// <c>last_traded_at_desc</c>
        /// </summary>
        [Map("last_traded_at_desc")]
        LastTradedAtDesc,
        /// <summary>
        /// <c>last_traded_at_asc</c>
        /// </summary>
        [Map("last_traded_at_asc")]
        LastTradedAtAsc,
        /// <summary>
        /// <c>volume_desc</c>
        /// </summary>
        [Map("volume_desc")]
        VolumeDesc,
        /// <summary>
        /// <c>volume_asc</c>
        /// </summary>
        [Map("volume_asc")]
        VolumeAsc,
        /// <summary>
        /// <c>base_target</c>
        /// </summary>
        [Map("base_target")]
        BaseTarget
    }
}
