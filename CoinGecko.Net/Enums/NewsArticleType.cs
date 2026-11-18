using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace CoinGecko.Net.Enums
{
    /// <summary>
    /// Type of article
    /// </summary>
    [JsonConverter(typeof(EnumConverter<NewsArticleType>))]
    public enum NewsArticleType
    {
        /// <summary>
        /// News article
        /// </summary>
        [Map("news")]
        News,
        /// <summary>
        /// Guide
        /// </summary>
        [Map("guide")]
        Guide
    }
}
