using System;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Ico information
    /// </summary>
    public record CoinGeckoIcoData
    {
        /// <summary>
        /// Ico start date
        /// </summary>
        [JsonPropertyName("ico_start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? IcoStartDate { get; set; }
        /// <summary>
        /// Ico end date
        /// </summary>
        [JsonPropertyName("ico_end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? IcoEndDate { get; set; }
        /// <summary>
        /// Short description
        /// </summary>
        [JsonPropertyName("short_desc")]
        public string ShortDescription { get; set; } = string.Empty;
        /// <summary>
        /// Description
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Soft cap currency
        /// </summary>
        [JsonPropertyName("softcap_currency")]
        public string? SoftcapCurrency { get; set; }
        /// <summary>
        /// Hard cap currency
        /// </summary>
        [JsonPropertyName("hardcap_currency")]
        public string? HardcapCurrency { get; set; }
        /// <summary>
        /// Total raised currency
        /// </summary>
        [JsonPropertyName("total_raised_currency")]
        public string? TotalRaisedCurrency { get; set; }
        /// <summary>
        /// Softcap
        /// </summary>
        [JsonPropertyName("softcap_amount")]
        public decimal? SoftcapAmount { get; set; }
        /// <summary>
        /// Hardcap amount
        /// </summary>
        [JsonPropertyName("hardcap_amount")]
        public decimal? HardcapAmount { get; set; }
        /// <summary>
        /// Total raised
        /// </summary>
        [JsonPropertyName("total_raised")]
        public decimal? TotalRaised { get; set; }
        /// <summary>
        /// Quote pre-sale currency
        /// </summary>
        [JsonPropertyName("quote_pre_sale_currency")]
        public string QuotePreSaleCurrency { get; set; } = string.Empty;
        /// <summary>
        /// Base pre sale amount
        /// </summary>
        [JsonPropertyName("base_pre_sale_amount")]
        public string BasePreSaleAmount { get; set; } = string.Empty;
        /// <summary>
        /// Quote pre sale amount
        /// </summary>
        [JsonPropertyName("quote_pre_sale_amount")]
        public decimal? QuotePreSaleAmount { get; set; }
        /// <summary>
        /// Quote public sale currency
        /// </summary>
        [JsonPropertyName("quote_public_sale_currency")]
        public string QuotePublicSaleCurrency { get; set; } = string.Empty;
        /// <summary>
        /// Base public sale amount
        /// </summary>
        [JsonPropertyName("base_public_sale_amount")]
        public decimal? BasePublicSaleAmount { get; set; }
        /// <summary>
        /// Quote public sale amount
        /// </summary>
        [JsonPropertyName("quote_public_sale_amount")]
        public decimal? QuotePublicSaleAmount { get; set; }
        /// <summary>
        /// Accepting currencies
        /// </summary>
        [JsonPropertyName("accepting_currencies")]
        public string AcceptingCurrencies { get; set; } = string.Empty;
        /// <summary>
        /// Country origin
        /// </summary>
        [JsonPropertyName("country_origin")]
        public string CountryOrigin { get; set; } = string.Empty;
        /// <summary>
        /// Pre sale start date
        /// </summary>
        [JsonPropertyName("pre_sale_start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? PreSaleStartDate { get; set; }
        /// <summary>
        /// Pre sale end date
        /// </summary>
        [JsonPropertyName("pre_sale_end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? PreSaleEndDate { get; set; }
        /// <summary>
        /// Whitelist url
        /// </summary>
        [JsonPropertyName("whitelist_url")]
        public string WhitelistUrl { get; set; } = string.Empty;
        /// <summary>
        /// Whitelist start date
        /// </summary>
        [JsonPropertyName("whitelist_start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? WhitelistStartDate { get; set; }
        /// <summary>
        /// Whitelist end date
        /// </summary>
        [JsonPropertyName("whitelist_end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? WhitelistEndDate { get; set; }
        /// <summary>
        /// Bounty detail url
        /// </summary>
        [JsonPropertyName("bounty_detail_url")]
        public string BountyDetailUrl { get; set; } = string.Empty;
        /// <summary>
        /// Amount for sale
        /// </summary>
        [JsonPropertyName("amount_for_sale")]
        public decimal? AmountForSale { get; set; }
        /// <summary>
        /// KYC required
        /// </summary>
        [JsonPropertyName("kyc_required")]
        public bool KycRequired { get; set; }
        /// <summary>
        /// Whitelist available
        /// </summary>
        [JsonPropertyName("whitelist_available")]
        public bool? WhitelistAvailable { get; set; }
        /// <summary>
        /// Pre sale ended
        /// </summary>
        [JsonPropertyName("pre_sale_ended")]
        public bool PreSaleEnded { get; set; }
    }
}
