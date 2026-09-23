using CoinGecko.Net;
using CoinGecko.Net.Clients;
using CoinGecko.Net.Interfaces;
using CoinGecko.Net.Objects.Options;
using CryptoExchange.Net;
using CryptoExchange.Net.Clients;
using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Interfaces.Clients;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extensions for DI
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add services such as the ICoinGeckoRestClient. Configures the services based on the provided configuration.
        /// See <see href="https://github.com/JKorf/CoinGecko.Net/blob/main/Examples/example-config.json" /> for an example of how to set up the configuration.
        /// </summary>
        /// <param name="services">The service collection</param>
        /// <param name="configuration">The configuration(section) containing the options</param>
        /// <returns></returns>
        public static IServiceCollection AddCoinGecko(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var options = CoinGeckoRestOptions.CreateFromConfiguration(configuration);

            services.AddSingleton(Options.Options.Create(options));

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
            var options = CoinGeckoRestOptions.Create(optionsDelegate);

            services.AddSingleton(Options.Options.Create(options));

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
                var options = serviceProvider.GetRequiredService<IOptions<CoinGeckoRestOptions>>().Value;
                return LibraryHelpers.CreateHttpClientMessageHandler(options);
            }).SetHandlerLifetime(Timeout.InfiniteTimeSpan);

            return services;
        }
    }
}
