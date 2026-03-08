using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Exchange info
    /// </summary>
    [SerializationModel]
    public record CoinGeckoExchangeDerivative
    {
        /// <summary>
        /// ["<c>name</c>"] Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>open_interest_btc</c>"] Open interest in btc
        /// </summary>
        [JsonPropertyName("open_interest_btc")]
        public decimal? OpenInterestBtc { get; set; }
        /// <summary>
        /// ["<c>trade_volume_24h_btc</c>"] Trade volume in btc
        /// </summary>
        [JsonPropertyName("trade_volume_24h_btc")]
        public decimal? TradeVolume24hBtc { get; set; }
        /// <summary>
        /// ["<c>number_of_perpetual_pairs</c>"] Number of perpetual pairs
        /// </summary>
        [JsonPropertyName("number_of_perpetual_pairs")]
        public int NumberOfPerpetualPairs { get; set; }
        /// <summary>
        /// ["<c>number_of_futures_pairs</c>"] Number of futures pairs
        /// </summary>
        [JsonPropertyName("number_of_futures_pairs")]
        public int NumberOfFuturesPairs { get; set; }
        /// <summary>
        /// ["<c>image</c>"] Image
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>year_established</c>"] Year established
        /// </summary>
        [JsonPropertyName("year_established")]
        public int? YearEstablished { get; set; }
        /// <summary>
        /// ["<c>country</c>"] Country
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        /// <summary>
        /// ["<c>description</c>"] Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>url</c>"] Url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>tickers</c>"] Tickers
        /// </summary>
        [JsonPropertyName("tickers")]
        public CoinGeckoDerivativeTicker[]? Tickers { get; set; }
    }
}
