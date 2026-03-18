using CryptoExchange.Net.Authentication;
using System;

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

        internal ApiKeyCredential Credential { get; set; }

        public CoinGeckoCredentials() { }

        public CoinGeckoCredentials(string apiKey, bool demoKey = false)
        {
            Credential = new ApiKeyCredential(apiKey);
            DemoKey = demoKey;
        }

        /// <inheritdoc />
        public override ApiCredentials Copy() => new CoinGeckoCredentials { Credential = Credential };

        //        /// <summary>
        //        /// </summary>
        //        [Obsolete("Parameterless constructor is only for deserialization purposes and should not be used directly. Use parameterized constructor instead.")]
        //        public CoinGeckoCredentials() { }

        //        /// <summary>
        //        /// ctor
        //        /// </summary>
        //        /// <param name="apiKey">The API key</param>
        //        /// <param name="demoKey">Whether or not this is a demo key</param>
        //        public CoinGeckoCredentials(string apiKey, bool demoKey = false) : this(new ApiKeyCredential(apiKey))
        //        {
        //            DemoKey = demoKey;
        //        }

        //        /// <summary>
        //        /// ctor
        //        /// </summary>
        //        /// <param name="credential">The API key credentials</param>
        //        /// <param name="demoKey">Whether or not this is a demo key</param>
        //        public CoinGeckoCredentials(ApiKeyCredential credential, bool demoKey = false) : base(credential) { }

        //        /// <inheritdoc />
        //#pragma warning disable CS0618 // Type or member is obsolete
        //        public override ApiCredentials Copy() => new CoinGeckoCredentials { CredentialPairs = CredentialPairs };
        //#pragma warning restore CS0618 // Type or member is obsolete
    }
}
