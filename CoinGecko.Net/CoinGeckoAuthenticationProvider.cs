using CoinGecko.Net.Objects;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Clients;
using CryptoExchange.Net.Objects;
using System.Collections.Generic;

namespace CoinGecko.Net
{
    internal class CoinGeckoAuthenticationProvider : AuthenticationProvider<CoinGeckoCredentials, ApiKeyCredential>
    {
        /// <summary>
        /// Whether or not a demo key is configured
        /// </summary>
        public bool IsDemo => ApiCredentials.DemoKey;

        public override ApiCredentialsType[] SupportedCredentialTypes => [ApiCredentialsType.HMAC];

        public CoinGeckoAuthenticationProvider(CoinGeckoCredentials credentials) : base(credentials)
        {
        }

        public override void ProcessRequest(RestApiClient apiClient, RestRequestConfiguration request)
        {
            request.QueryParameters ??= new Dictionary<string, object>();

            if (IsDemo)
                request.QueryParameters.Add("x_cg_demo_api_key", Credential.Key);
            else
                request.QueryParameters.Add("x_cg_pro_api_key", Credential.Key);
        }
    }
}
