using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Ticker Order
    /// </summary>
    public enum TickerOrder
    {
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
        VolumeAsc
    }
}
