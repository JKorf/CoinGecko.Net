using CryptoExchange.Net.Attributes;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Exchange Derivatives Order
    /// </summary>
    public enum ExchangeDerivativesOrder
    {
        /// <summary>
        /// <c>name_asc</c>
        /// </summary>
        [Map("name_asc")]
        NameAsc,
        /// <summary>
        /// <c>name_desc</c>
        /// </summary>
        [Map("name_desc")]
        NameDesc,
        /// <summary>
        /// <c>open_interest_btc_asc</c>
        /// </summary>
        [Map("open_interest_btc_asc")]
        OpenInterestBtcAsc,
        /// <summary>
        /// <c>open_interest_btc_desc</c>
        /// </summary>
        [Map("open_interest_btc_desc")]
        OpenInterestBtcDesc,
        /// <summary>
        /// <c>trade_volume_24h_btc_asc</c>
        /// </summary>
        [Map("trade_volume_24h_btc_asc")]
        TradeVolume24hBtcAsc,
        /// <summary>
        /// <c>trade_volume_24h_btc_desc</c>
        /// </summary>
        [Map("trade_volume_24h_btc_desc")]
        TradeVolume24hBtcDesc
    }
}
