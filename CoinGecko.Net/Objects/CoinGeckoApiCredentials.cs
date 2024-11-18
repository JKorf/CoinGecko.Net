using CryptoExchange.Net.Authentication;

namespace CoinGecko.Net.Objects
{
    /// <summary>
    /// CoinGecko API credentials
    /// </summary>
    public class CoinGeckoApiCredentials : ApiCredentials
    {
        /// <summary>
        /// Wheter using a demo key
        /// </summary>
        public bool DemoKey { get; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="key">The API key</param>
        /// <param name="demoKey">Whether or not this is a demo key</param>
        public CoinGeckoApiCredentials(string key, bool demoKey = false) : base(key, "-")
        {
            DemoKey = demoKey;
        }

        /// <summary>
        /// Copy
        /// </summary>
        /// <returns></returns>
        public override ApiCredentials Copy()
        {
            return new CoinGeckoApiCredentials(Key, DemoKey);
        }
    }
}
