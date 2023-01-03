namespace Bybit.Net.Objects
{
    /// <summary>
    /// Api addresses usable for the CoinGecko client
    /// </summary>
    public class CoinGeckoApiAddresses
    {
        /// <summary>
        /// The address used by the BybitClient for the Spot rest API
        /// </summary>
        public string SpotRestClientAddress { get; set; } = "";


        /// <summary>
        /// The default addresses to connect to the Bybit.com API
        /// </summary>
        public static CoinGeckoApiAddresses Default = new CoinGeckoApiAddresses
        {
            SpotRestClientAddress = "https://api.coingecko.com/"
        };
    }
}
