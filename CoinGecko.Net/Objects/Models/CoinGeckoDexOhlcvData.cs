namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Dex OHLCV data wrapper
    /// </summary>
    [SerializationModel]
    public record CoinGeckoDexOhlcvData : CoinGeckoDexItem<CoinGeckoDexOhlcvAttributes>
    { }
}
