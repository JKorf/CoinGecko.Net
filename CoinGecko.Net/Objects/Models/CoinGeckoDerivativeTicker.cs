using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Derivatives ticker
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDerivativeTicker
    {
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>base</c>"] Base asset
        /// </summary>
        [JsonPropertyName("base")]
        public string Base { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>target</c>"] Target asset
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>coin_id</c>"] Coin id
        /// </summary>
        [JsonPropertyName("coin_id")]
        public string? CoinId { get; set; }
        /// <summary>
        /// ["<c>target_coin_id</c>"] Target coin id
        /// </summary>
        [JsonPropertyName("target_coin_id")]
        public string? TargetCoinId { get; set; }
        /// <summary>
        /// ["<c>trade_url</c>"] Trade url
        /// </summary>
        [JsonPropertyName("trade_url")]
        public string TradeUrl { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>contract_type</c>"] Contract type
        /// </summary>
        [JsonPropertyName("contract_type")]
        public string ContractType { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>last</c>"] Last price
        /// </summary>
        [JsonPropertyName("last")]
        public decimal? LastPrice { get; set; }
        /// <summary>
        /// ["<c>h24_percentage_change</c>"] 24 hour percentage change
        /// </summary>
        [JsonPropertyName("h24_percentage_change")]
        public decimal? H24PercentageChange { get; set; }
        /// <summary>
        /// ["<c>index</c>"] Index price
        /// </summary>
        [JsonPropertyName("index")]
        public decimal? IndexPrice { get; set; }
        /// <summary>
        /// ["<c>index_basis_percentage</c>"] Index basis percentage
        /// </summary>
        [JsonPropertyName("index_basis_percentage")]
        public decimal? IndexBasisPercentage { get; set; }
        /// <summary>
        /// ["<c>bid_ask_spread</c>"] Bid ask spread
        /// </summary>
        [JsonPropertyName("bid_ask_spread")]
        public decimal? BidAskSpread { get; set; }
        /// <summary>
        /// ["<c>funding_rate</c>"] Funding rate
        /// </summary>
        [JsonPropertyName("funding_rate")]
        public decimal? FundingRate { get; set; }
        /// <summary>
        /// ["<c>open_interest_usd</c>"] Open interest usd
        /// </summary>
        [JsonPropertyName("open_interest_usd")]
        public decimal? OpenInterestUsd { get; set; }
        /// <summary>
        /// ["<c>h24_volume</c>"] 24 hour volume
        /// </summary>
        [JsonPropertyName("h24_volume")]
        public decimal? H24Volume { get; set; }
        /// <summary>
        /// ["<c>converted_volume</c>"] Converted volume
        /// </summary>
        [JsonPropertyName("converted_volume")]
        public Dictionary<string, decimal?> ConvertedVolume { get; set; } = null!;
        /// <summary>
        /// ["<c>converted_last</c>"] Converted last
        /// </summary>
        [JsonPropertyName("converted_last")]
        public Dictionary<string, decimal?> ConvertedLast { get; set; } = null!;
        /// <summary>
        /// ["<c>last_traded</c>"] Last trade time
        /// </summary>
        [JsonPropertyName("last_traded")]
        public DateTime LastTradeTime { get; set; }
        /// <summary>
        /// ["<c>expired_at</c>"] Expired time
        /// </summary>
        [JsonPropertyName("expired_at")]
        public DateTime? ExpireTime { get; set; }
    }
}
