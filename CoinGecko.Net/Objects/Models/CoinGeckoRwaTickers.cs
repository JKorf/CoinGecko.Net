using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Rwa Tickers
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaTickers
    {
        /// <summary>
        /// ["<c>name</c>"] RWA name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>tickers</c>"] List of tickers
        /// </summary>
        [JsonPropertyName("tickers")]
        public CoinGeckoRwaTickersTicker[] Tickers { get; set; } = [];
    }

    /// <summary>
    /// Rwa Tickers Ticker
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaTickersTicker
    {
        /// <summary>
        /// ["<c>base</c>"] Ticker base currency
        /// </summary>
        [JsonPropertyName("base")]
        public string Base { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>target</c>"] Ticker target currency
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>market</c>"] Exchange information
        /// </summary>
        [JsonPropertyName("market")]
        public CoinGeckoRwaTickersTickerMarket Market { get; set; } = new();
        /// <summary>
        /// ["<c>last</c>"] Last price
        /// </summary>
        [JsonPropertyName("last")]
        public decimal Last { get; set; }
        /// <summary>
        /// ["<c>volume</c>"] Trading volume
        /// </summary>
        [JsonPropertyName("volume")]
        public decimal Volume { get; set; }
        /// <summary>
        /// ["<c>cost_to_move_up_usd</c>"] Cost to move price up by 2% in USD
        /// </summary>
        [JsonPropertyName("cost_to_move_up_usd")]
        public decimal? CostToMoveUpUsd { get; set; }
        /// <summary>
        /// ["<c>cost_to_move_down_usd</c>"] Cost to move price down by 2% in USD
        /// </summary>
        [JsonPropertyName("cost_to_move_down_usd")]
        public decimal? CostToMoveDownUsd { get; set; }
        /// <summary>
        /// ["<c>converted_last</c>"] Converted last price
        /// </summary>
        [JsonPropertyName("converted_last")]
        public CoinGeckoRwaTickersTickerConvertedLast ConvertedLast { get; set; } = new();
        /// <summary>
        /// ["<c>converted_volume</c>"] Converted trading volume
        /// </summary>
        [JsonPropertyName("converted_volume")]
        public CoinGeckoRwaTickersTickerConvertedLast ConvertedVolume { get; set; } = new();
        /// <summary>
        /// ["<c>bid_ask_spread_percentage</c>"] Bid-ask spread percentage
        /// </summary>
        [JsonPropertyName("bid_ask_spread_percentage")]
        public decimal BidAskSpreadPercentage { get; set; }
        /// <summary>
        /// ["<c>timestamp</c>"] Ticker timestamp
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// ["<c>last_traded_at</c>"] Last traded timestamp
        /// </summary>
        [JsonPropertyName("last_traded_at")]
        public DateTime LastTradedAt { get; set; }
        /// <summary>
        /// ["<c>last_fetch_at</c>"] Last fetch timestamp
        /// </summary>
        [JsonPropertyName("last_fetch_at")]
        public DateTime LastFetchAt { get; set; }
        /// <summary>
        /// ["<c>is_anomaly</c>"] Whether ticker is anomalous
        /// </summary>
        [JsonPropertyName("is_anomaly")]
        public bool IsAnomaly { get; set; }
        /// <summary>
        /// ["<c>is_stale</c>"] Whether ticker is stale
        /// </summary>
        [JsonPropertyName("is_stale")]
        public bool IsStale { get; set; }
        /// <summary>
        /// ["<c>trade_url</c>"] Trade URL
        /// </summary>
        [JsonPropertyName("trade_url")]
        public string? TradeUrl { get; set; }
        /// <summary>
        /// ["<c>token_info_url</c>"] Token info URL
        /// </summary>
        [JsonPropertyName("token_info_url")]
        public string? TokenInfoUrl { get; set; }
        /// <summary>
        /// ["<c>coin_id</c>"] Base currency coin ID
        /// </summary>
        [JsonPropertyName("coin_id")]
        public string CoinId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>target_coin_id</c>"] Target currency coin ID
        /// </summary>
        [JsonPropertyName("target_coin_id")]
        public string? TargetCoinId { get; set; }
        /// <summary>
        /// ["<c>coin_mcap_usd</c>"] Coin market cap in USD
        /// </summary>
        [JsonPropertyName("coin_mcap_usd")]
        public decimal CoinMcapUsd { get; set; }
    }

    /// <summary>
    /// Rwa Tickers Ticker Market
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaTickersTickerMarket
    {
        /// <summary>
        /// ["<c>name</c>"] Exchange name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// ["<c>identifier</c>"] Exchange identifier
        /// </summary>
        [JsonPropertyName("identifier")]
        public string? Identifier { get; set; }
        /// <summary>
        /// ["<c>has_trading_incentive</c>"] Exchange trading incentive
        /// </summary>
        [JsonPropertyName("has_trading_incentive")]
        public bool? HasTradingIncentive { get; set; }
        /// <summary>
        /// ["<c>logo</c>"] Exchange logo URL
        /// </summary>
        [JsonPropertyName("logo")]
        public string? Logo { get; set; }
    }

    /// <summary>
    /// Rwa Tickers Ticker Converted Last
    /// </summary>
    [SerializationModel]
    public record CoinGeckoRwaTickersTickerConvertedLast
    {
        /// <summary>
        /// ["<c>btc</c>"] Btc
        /// </summary>
        [JsonPropertyName("btc")]
        public decimal? Btc { get; set; }
        /// <summary>
        /// ["<c>eth</c>"] Eth
        /// </summary>
        [JsonPropertyName("eth")]
        public decimal? Eth { get; set; }
        /// <summary>
        /// ["<c>usd</c>"] Usd
        /// </summary>
        [JsonPropertyName("usd")]
        public decimal? Usd { get; set; }
    }
}
