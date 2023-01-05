using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Status update
    /// </summary>
    public class CoinGeckoStatusUpdate
    {
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Category
        /// </summary>
        public string Category { get; set; } = string.Empty;
        /// <summary>
        /// Created time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// User name
        /// </summary>
        public string User { get; set; } = string.Empty;
        /// <summary>
        /// User title
        /// </summary>
        [JsonProperty("user_title")]
        public string UserTitle { get; set; } = string.Empty;
        /// <summary>
        /// Is pinned
        /// </summary>
        public bool Pin { get; set; }
        /// <summary>
        /// Project info
        /// </summary>
        public CoinGeckoProject? Project { get; set; }
    }

    /// <summary>
    /// Project info
    /// </summary>
    public class CoinGeckoProject
    {
        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Images
        /// </summary>
        public CoinGeckoImages? Image { get; set; }
    }
}
