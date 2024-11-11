using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using CoinGecko.Net.Objects;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Clients;
using CryptoExchange.Net.Objects;

namespace CoinGecko.Net
{
    internal class CoinGeckoAuthenticationProvider : AuthenticationProvider<CoinGeckoApiCredentials>
    {
        /// <summary>
        /// Whether or not a demo key is configured
        /// </summary>
        public bool IsDemo => _credentials.DemoKey;

        public CoinGeckoAuthenticationProvider(CoinGeckoApiCredentials credentials) : base(credentials)
        {
        }

        public override void AuthenticateRequest(
            RestApiClient apiClient,
            Uri uri,
            HttpMethod method,
            ref IDictionary<string, object>? uriParameters,
            ref IDictionary<string, object>? bodyParameters,
            ref Dictionary<string, string>? headers,
            bool auth,
            ArrayParametersSerialization arraySerialization,
            HttpMethodParameterPosition parameterPosition,
            RequestBodyFormat requestBodyFormat)
        {
            uriParameters ??= new ParameterCollection();
            if (_credentials.DemoKey)
                uriParameters.Add("x_cg_demo_api_key", _credentials.Key);
            else
                uriParameters.Add("x_cg_pro_api_key", _credentials.Key);
        }
    }
}
