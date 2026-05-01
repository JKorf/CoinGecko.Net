namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex networks response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexNetworksResponse : CoinGeckoDexResponsePaged<CoinGeckoDexNetwork>
    { }
}
