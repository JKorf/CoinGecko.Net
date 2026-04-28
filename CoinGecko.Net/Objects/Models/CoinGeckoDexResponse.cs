using System.Text.Json.Serialization;
using CoinGecko.Net.Objects.Models;

namespace CoinGecko.Net.Objects
{
    /// <summary>
    /// Dex response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexResponse<TData>
        where TData : CoinGeckoDexItem
    {
        /// <summary>
        /// ["<c>data</c>"] Data
        /// </summary>
        [JsonPropertyName("data")]
        public TData[] Data { get; set; } = [];
    }


    /// <summary>
    /// Dex response with included items
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexResponse<TData, TInclude> : CoinGeckoDexResponse<TData>
        where TData : CoinGeckoDexItem
        where TInclude : CoinGeckoDexItem
    {
        /// <summary>
        /// ["<c>included</c>"] Included items
        /// </summary>
        [JsonPropertyName("included")]
        public TInclude[] Included { get; set; } = [];
    }

    /// <summary>
    /// Paged dex response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexResponsePaged<TData> : CoinGeckoDexResponse<TData>
        where TData : CoinGeckoDexItem
    {
        /// <summary>
        /// ["<c>links</c>"] Page links
        /// </summary>
        [JsonPropertyName("links")]
        public CoinGeckoDexPageLinks PageLinks { get; set; } = new();
    }

    /// <summary>
    /// Paged dex response with included items
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexResponsePaged<TData, TInclude> : CoinGeckoDexResponse<TData, TInclude>
        where TData : CoinGeckoDexItem
        where TInclude : CoinGeckoDexItem
    {
        /// <summary>
        /// ["<c>links</c>"] Page links
        /// </summary>
        [JsonPropertyName("links")]
        public CoinGeckoDexPageLinks PageLinks { get; set; } = new();
    }
}
