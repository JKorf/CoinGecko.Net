using CoinGecko.Net;
using CoinGecko.Net.Clients;
using CoinGecko.Net.Interfaces;
using CoinGecko.Net.Objects.Options;
using CryptoExchange.Net.Clients;
using CryptoExchange.Net.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Net.Http;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extensions for DI
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add services such as the ICoinGeckoRestClient. Configures the services based on the provided configuration.
        /// </summary>
        /// <param name="services">The service collection</param>
        /// <param name="configuration">The configuration(section) containing the options</param>
        /// <returns></returns>
        public static IServiceCollection AddCoinGecko(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var options = new CoinGeckoRestOptions();
            configuration.Bind(options);

            var restEnvName = options.Environment?.Name ?? options.Environment?.Name ?? CoinGeckoEnvironment.Live.Name;
            options.Environment = CoinGeckoEnvironment.GetEnvironmentByName(restEnvName) ?? options.Environment!;
            options.ApiCredentials = options.ApiCredentials ?? options.ApiCredentials;

            services.AddSingleton(x => Options.Options.Create(options));

            return AddCoinGeckoCore(services);
        }

        /// <summary>
        /// Add services such as the ICoinGeckoRestClient. Services will be configured based on the provided options.
        /// </summary>
        /// <param name="services">The service collection</param>
        /// <param name="optionsDelegate">Set options for the CoinGecko services</param>
        /// <returns></returns>
        public static IServiceCollection AddCoinGecko(
            this IServiceCollection services,
            Action<CoinGeckoRestOptions>? optionsDelegate = null)
        {
            services.Configure<CoinGeckoRestOptions>((x) => { optionsDelegate?.Invoke(x); });

            return AddCoinGeckoCore(services);
        }

        private static IServiceCollection AddCoinGeckoCore(
            this IServiceCollection services)
        {
            services.AddHttpClient<ICoinGeckoRestClient, CoinGeckoRestClient>((client, serviceProvider) =>
            {
                var options = serviceProvider.GetRequiredService<IOptions<CoinGeckoRestOptions>>().Value;
                client.Timeout = options.RequestTimeout;
                return new CoinGeckoRestClient(client, serviceProvider.GetRequiredService<ILoggerFactory>(), serviceProvider.GetRequiredService<IOptions<CoinGeckoRestOptions>>());
            }).ConfigurePrimaryHttpMessageHandler((serviceProvider) => {
                var handler = new HttpClientHandler();
                try
                {
                    handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                }
                catch (PlatformNotSupportedException)
                { }

                var options = serviceProvider.GetRequiredService<IOptions<CoinGeckoRestOptions>>().Value;
                if (options.Proxy != null)
                {
                    handler.Proxy = new WebProxy
                    {
                        Address = new Uri($"{options.Proxy.Host}:{options.Proxy.Port}"),
                        Credentials = options.Proxy.Password == null ? null : new NetworkCredential(options.Proxy.Login, options.Proxy.Password)
                    };
                }
                return handler;
            });

            services.AddTransient<ICryptoRestClient, CryptoRestClient>();
            return services;
        }
    }
}
