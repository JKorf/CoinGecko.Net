using System.Text.Json.Serialization;
using CoinGecko.Net.Objects.Models;

namespace CoinGecko.Net.Objects
{
    /// <summary>
    /// Dex pool relationships
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolRelationShip
    {
        /// <summary>
        /// ["<c>base_token</c>"] Base token
        /// </summary>
        [JsonPropertyName("base_token")]
        public CoinGeckoDexPoolRelationShipItem BaseToken { get; set; }

        /// <summary>
        /// ["<c>quote_token</c>"] Quote token
        /// </summary>
        [JsonPropertyName("quote_token")]
        public CoinGeckoDexPoolRelationShipItem QuoteToken { get; set; }

        /// <summary>
        /// ["<c>dex</c>"] Dex
        /// </summary>
        [JsonPropertyName("dex")]
        public CoinGeckoDexPoolRelationShipItem Dex { get; set; }
    }

    /// <summary>
    /// Dex pool relationship item
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPoolRelationShipItem
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public CoinGeckoDexItem Data { get; set; }
    }
}
