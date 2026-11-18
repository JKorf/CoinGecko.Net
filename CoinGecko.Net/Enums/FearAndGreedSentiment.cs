using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Fear and Greed Index sentiment
    /// </summary>
    [JsonConverter(typeof(EnumConverter<FearAndGreedSentiment>))]
    public enum FearAndGreedSentiment
    {
        /// <summary>
        /// Extreme fear
        /// </summary>
        [Map("extreme_fear")]
        ExtremeFear,
        /// <summary>
        /// Fear
        /// </summary>
        [Map("fear")]
        Fear,
        /// <summary>
        /// Neutral
        /// </summary>
        [Map("neutral")]
        Neutral,
        /// <summary>
        /// Greed
        /// </summary>
        [Map("greed")]
        Greed,
        /// <summary>
        /// Extreme greed
        /// </summary>
        [Map("extreme_greed")]
        ExtremeGreed
    }
}
