using CryptoExchange.Net.Authentication;

namespace CoinGecko.Net
{
    /// <summary>
    /// CoinGecko credentials
    /// </summary>
    public class CoinGeckoCredentials : ApiCredentials
    {
        /// <summary>
        /// Whether using a demo key
        /// </summary>
        public bool DemoKey { get; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="apiKey">The API key</param>
        /// <param name="demoKey">Whether or not this is a demo key</param>
        public CoinGeckoCredentials(string apiKey, bool demoKey = false) : this(new ApiKeyCredential(apiKey))
        {
            DemoKey = demoKey;
        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="credential">The API key credentials</param>
        /// <param name="demoKey">Whether or not this is a demo key</param>
        public CoinGeckoCredentials(ApiKeyCredential credential, bool demoKey = false) : base(credential) { }

        /// <inheritdoc />
        public override ApiCredentials Copy() => new CoinGeckoCredentials(ApiKey!, DemoKey);
    }
}
