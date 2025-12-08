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
        /// Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Base asset
        /// </summary>
        [JsonPropertyName("base")]
        public string Base { get; set; } = string.Empty;
        /// <summary>
        /// Target asset
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; } = string.Empty;
        /// <summary>
        /// Coin id
        /// </summary>
        [JsonPropertyName("coin_id")]
        public string? CoinId { get; set; }
        /// <summary>
        /// Target coin id
        /// </summary>
        [JsonPropertyName("target_coin_id")]
        public string? TargetCoinId { get; set; }
        /// <summary>
        /// Trade url
        /// </summary>
        [JsonPropertyName("trade_url")]
        public string TradeUrl { get; set; } = string.Empty;
        /// <summary>
        /// Contract type
        /// </summary>
        [JsonPropertyName("contract_type")]
        public string ContractType { get; set; } = string.Empty;
        /// <summary>
        /// Last price
        /// </summary>
        [JsonPropertyName("last")]
        public decimal LastPrice { get; set; }
        /// <summary>
        /// 24 hour percentage change
        /// </summary>
        [JsonPropertyName("h24_percentage_change")]
        public decimal H24PercentageChange { get; set; }
        /// <summary>
        /// Index price
        /// </summary>
        [JsonPropertyName("index")]
        public decimal IndexPrice { get; set; }
        /// <summary>
        /// Index basis percentage
        /// </summary>
        [JsonPropertyName("index_basis_percentage")]
        public decimal IndexBasisPercentage { get; set; }
        /// <summary>
        /// Bid ask spread
        /// </summary>
        [JsonPropertyName("bid_ask_spread")]
        public decimal BidAskSpread { get; set; }
        /// <summary>
        /// Funding rate
        /// </summary>
        [JsonPropertyName("funding_rate")]
        public decimal FundingRate { get; set; }
        /// <summary>
        /// Open interest usd
        /// </summary>
        [JsonPropertyName("open_interest_usd")]
        public decimal OpenInterestUsd { get; set; }
        /// <summary>
        /// 24 hour volume
        /// </summary>
        [JsonPropertyName("h24_volume")]
        public decimal H24Volume { get; set; }
        /// <summary>
        /// Converted volume
        /// </summary>
        [JsonPropertyName("converted_volume")]
        public Dictionary<string, decimal> ConvertedVolume { get; set; } = null!;
        /// <summary>
        /// Converted last
        /// </summary>
        [JsonPropertyName("converted_last")]
        public Dictionary<string, decimal> ConvertedLast { get; set; } = null!;
        /// <summary>
        /// Last trade time
        /// </summary>
        [JsonPropertyName("last_traded")]
        public DateTime LastTradeTime { get; set; }
        /// <summary>
        /// Expired time
        /// </summary>
        [JsonPropertyName("expired_at")]
        public DateTime? ExpireTime { get; set; }
    }
}
