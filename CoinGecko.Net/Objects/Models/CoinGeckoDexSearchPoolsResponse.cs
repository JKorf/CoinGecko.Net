namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex search pools response
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexSearchPoolsResponse : CoinGeckoDexResponse<CoinGeckoDexPool, CoinGeckoDexToken>
    { }
}
