namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Asset info
    /// </summary>
    public class CoinGeckoAsset
    {
        /// <summary>
        /// Id of the asset
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Symbol of the asset
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Name of the asset
        /// </summary>
        public string Name { get; set; } = string.Empty;
    }
}
