using CryptoExchange.Net.Objects;
using CryptoExchange.Net.RateLimiting.Filters;
using CryptoExchange.Net.RateLimiting.Guards;
using CryptoExchange.Net.RateLimiting.Interfaces;
using CryptoExchange.Net.RateLimiting;
using System;
using System.Collections.Generic;
using System.Text;
using CryptoExchange.Net.SharedApis;
using CoinGecko.Net.Converters;

namespace CoinGecko.Net
{
    /// <summary>
    /// CoinGecko information and configuration
    /// </summary>
    public static class CoinGeckoApi
    {
        /// <summary>
        /// Url to the main website
        /// </summary>
        public static string Url { get; } = "https://www.coingecko.com";

        /// <summary>
        /// Urls to the API documentation
        /// </summary>
        public static string[] ApiDocsUrl { get; } = new[] {
            "https://docs.coingecko.com/"
            };

        internal static CoinGeckoSourceGenerationContext SerializationContext { get; } = new CoinGeckoSourceGenerationContext();

        /// <summary>
        /// Rate limiter configuration for the CoinGecko API
        /// </summary>
        public static CoinGeckoRateLimiters RateLimiter { get; } = new CoinGeckoRateLimiters();
    }

    /// <summary>
    /// Rate limiter configuration for the CoinGecko API
    /// </summary>
    public class CoinGeckoRateLimiters
    {
        /// <summary>
        /// Event for when a rate limit is triggered
        /// </summary>
        public event Action<RateLimitEvent> RateLimitTriggered;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        internal CoinGeckoRateLimiters()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            Initialize();
        }

        private void Initialize()
        {
            CoinGecko = new RateLimitGate("CoinGecko");
            CoinGecko.RateLimitTriggered += (x) => RateLimitTriggered?.Invoke(x);
        }

        internal IRateLimitGate CoinGecko { get; private set; }
    }
}
