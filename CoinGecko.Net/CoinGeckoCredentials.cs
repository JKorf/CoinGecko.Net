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
        public bool DemoKey { get; set; }

        /// <summary>
        /// API key credential
        /// </summary>
        public ApiKeyCredential Credential { get; set; }

        /// <summary>
        /// Create new credentials
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public CoinGeckoCredentials() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        /// <summary>
        /// Create new credentials providing Api key credentials
        /// </summary>
        /// <param name="credential">Api key credentials</param>
        public CoinGeckoCredentials(ApiKeyCredential credential)
        {
            Credential = credential;
        }

        /// <summary>
        /// Create new credentials providing Api key credentials
        /// </summary>
        /// <param name="key">The API key</param>
        /// <param name="demoKey">Whether this is a demo key</param>
        public CoinGeckoCredentials(string key, bool demoKey = false)
        {
            Credential = new ApiKeyCredential(key);
            DemoKey = demoKey;
        }

        /// <summary>
        /// Specify the ApiKey
        /// </summary>
        /// <param name="key">The API key</param>
        /// <param name="demoKey">Whether this is a demo key</param>
        public CoinGeckoCredentials WithApiKey(string key, bool demoKey = false)
        {
            if (Credential != null) throw new InvalidOperationException("Credentials already set");

            DemoKey = demoKey;
            Credential = new ApiKeyCredential(key);
            return this;
        }

        /// <inheritdoc />
        public override ApiCredentials Copy() => new CoinGeckoCredentials { Credential = Credential };

        /// <inheritdoc />
        public override void Validate()
        {
            if (Credential == null)
                throw new ArgumentException("Credential not set");

            Credential.Validate();
        }
    }
}
