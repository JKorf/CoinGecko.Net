namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex token
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexToken : CoinGeckoDexItem<CoinGeckoDexTokenDetail>
    { }
}
