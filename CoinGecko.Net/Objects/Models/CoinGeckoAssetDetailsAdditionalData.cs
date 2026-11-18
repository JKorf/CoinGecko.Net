using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Asset Details Categories Detail
    /// </summary>
    [SerializationModel]
    public record CoinGeckoAssetDetailsCategoriesDetail
    {
        /// <summary>
        /// ["<c>id</c>"] Category ID
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        /// <summary>
        /// ["<c>name</c>"] Category name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    /// <summary>
    /// Asset Details Ico Data
    /// </summary>
    [SerializationModel]
    public record CoinGeckoAssetDetailsIcoData
    {
        /// <summary>
        /// ["<c>ico_start_date</c>"] ICO start date
        /// </summary>
        [JsonPropertyName("ico_start_date")]
        public string? IcoStartDate { get; set; }
        /// <summary>
        /// ["<c>ico_end_date</c>"] ICO end date
        /// </summary>
        [JsonPropertyName("ico_end_date")]
        public string? IcoEndDate { get; set; }
        /// <summary>
        /// ["<c>short_desc</c>"] Short description
        /// </summary>
        [JsonPropertyName("short_desc")]
        public string? ShortDesc { get; set; }
        /// <summary>
        /// ["<c>description</c>"] Detailed description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        /// <summary>
        /// ["<c>links</c>"] ICO related links
        /// </summary>
        [JsonPropertyName("links")]
        public Dictionary<string, string>? Links { get; set; }
        /// <summary>
        /// ["<c>softcap_currency</c>"] Softcap currency
        /// </summary>
        [JsonPropertyName("softcap_currency")]
        public string? SoftcapCurrency { get; set; }
        /// <summary>
        /// ["<c>hardcap_currency</c>"] Hardcap currency
        /// </summary>
        [JsonPropertyName("hardcap_currency")]
        public string? HardcapCurrency { get; set; }
        /// <summary>
        /// ["<c>total_raised_currency</c>"] Total raised currency
        /// </summary>
        [JsonPropertyName("total_raised_currency")]
        public string? TotalRaisedCurrency { get; set; }
        /// <summary>
        /// ["<c>softcap_amount</c>"] Softcap amount
        /// </summary>
        [JsonPropertyName("softcap_amount")]
        public decimal? SoftcapAmount { get; set; }
        /// <summary>
        /// ["<c>hardcap_amount</c>"] Hardcap amount
        /// </summary>
        [JsonPropertyName("hardcap_amount")]
        public decimal? HardcapAmount { get; set; }
        /// <summary>
        /// ["<c>total_raised</c>"] Total raised amount
        /// </summary>
        [JsonPropertyName("total_raised")]
        public decimal? TotalRaised { get; set; }
        /// <summary>
        /// ["<c>quote_pre_sale_currency</c>"] Quote pre-sale currency
        /// </summary>
        [JsonPropertyName("quote_pre_sale_currency")]
        public string? QuotePreSaleCurrency { get; set; }
        /// <summary>
        /// ["<c>base_pre_sale_amount</c>"] Base pre-sale amount
        /// </summary>
        [JsonPropertyName("base_pre_sale_amount")]
        public decimal? BasePreSaleAmount { get; set; }
        /// <summary>
        /// ["<c>quote_pre_sale_amount</c>"] Quote pre-sale amount
        /// </summary>
        [JsonPropertyName("quote_pre_sale_amount")]
        public decimal? QuotePreSaleAmount { get; set; }
        /// <summary>
        /// ["<c>quote_public_sale_currency</c>"] Quote public sale currency
        /// </summary>
        [JsonPropertyName("quote_public_sale_currency")]
        public string? QuotePublicSaleCurrency { get; set; }
        /// <summary>
        /// ["<c>base_public_sale_amount</c>"] Base public sale amount
        /// </summary>
        [JsonPropertyName("base_public_sale_amount")]
        public decimal? BasePublicSaleAmount { get; set; }
        /// <summary>
        /// ["<c>quote_public_sale_amount</c>"] Quote public sale amount
        /// </summary>
        [JsonPropertyName("quote_public_sale_amount")]
        public decimal? QuotePublicSaleAmount { get; set; }
        /// <summary>
        /// ["<c>accepting_currencies</c>"] Accepting currencies
        /// </summary>
        [JsonPropertyName("accepting_currencies")]
        public string? AcceptingCurrencies { get; set; }
        /// <summary>
        /// ["<c>country_origin</c>"] Country of origin
        /// </summary>
        [JsonPropertyName("country_origin")]
        public string? CountryOrigin { get; set; }
        /// <summary>
        /// ["<c>pre_sale_start_date</c>"] Pre-sale start date
        /// </summary>
        [JsonPropertyName("pre_sale_start_date")]
        public string? PreSaleStartDate { get; set; }
        /// <summary>
        /// ["<c>pre_sale_end_date</c>"] Pre-sale end date
        /// </summary>
        [JsonPropertyName("pre_sale_end_date")]
        public string? PreSaleEndDate { get; set; }
        /// <summary>
        /// ["<c>whitelist_url</c>"] Whitelist URL
        /// </summary>
        [JsonPropertyName("whitelist_url")]
        public string? WhitelistUrl { get; set; }
        /// <summary>
        /// ["<c>whitelist_start_date</c>"] Whitelist start date
        /// </summary>
        [JsonPropertyName("whitelist_start_date")]
        public string? WhitelistStartDate { get; set; }
        /// <summary>
        /// ["<c>whitelist_end_date</c>"] Whitelist end date
        /// </summary>
        [JsonPropertyName("whitelist_end_date")]
        public string? WhitelistEndDate { get; set; }
        /// <summary>
        /// ["<c>bounty_detail_url</c>"] Bounty detail URL
        /// </summary>
        [JsonPropertyName("bounty_detail_url")]
        public string? BountyDetailUrl { get; set; }
        /// <summary>
        /// ["<c>amount_for_sale</c>"] Amount for sale
        /// </summary>
        [JsonPropertyName("amount_for_sale")]
        public decimal? AmountForSale { get; set; }
        /// <summary>
        /// ["<c>kyc_required</c>"] KYC required
        /// </summary>
        [JsonPropertyName("kyc_required")]
        public bool? KycRequired { get; set; }
        /// <summary>
        /// ["<c>whitelist_available</c>"] Whitelist available
        /// </summary>
        [JsonPropertyName("whitelist_available")]
        public bool? WhitelistAvailable { get; set; }
        /// <summary>
        /// ["<c>pre_sale_available</c>"] Pre-sale available
        /// </summary>
        [JsonPropertyName("pre_sale_available")]
        public bool? PreSaleAvailable { get; set; }
        /// <summary>
        /// ["<c>pre_sale_ended</c>"] Pre-sale ended
        /// </summary>
        [JsonPropertyName("pre_sale_ended")]
        public bool? PreSaleEnded { get; set; }
    }
}
