namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex pool
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexPool : CoinGeckoDexItem<CoinGeckoDexPoolDetails, CoinGeckoDexPoolRelationShip>
    { }
}
