namespace CoinGecko.Net.Objects
{
    /// <summary>
    /// Api addresses usable for the CoinGecko client
    /// </summary>
    public class CoinGeckoApiAddresses
    {
        /// <summary>
        /// The address used by the CoinGeckoRestClient for the public API
        /// </summary>
        public string RestClientAddressPublic { get; set; } = "";
        /// <summary>
        /// The address used by the CoinGeckoRestClient for the pro API
        /// </summary>
        public string RestClientAddressPro { get; set; } = "";


        /// <summary>
        /// The default addresses to connect to the Bybit.com API
        /// </summary>
        public static CoinGeckoApiAddresses Default = new CoinGeckoApiAddresses
        {
            RestClientAddressPublic = "https://api.coingecko.com/",
            RestClientAddressPro = "https://pro-api.coingecko.com/"
        };
    }
}
