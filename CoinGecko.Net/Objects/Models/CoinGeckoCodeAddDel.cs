

namespace CoinGecko.Net.Objects.Models
{
    /// <summary>
    /// Code additions/deletions
    /// </summary>
    public record CoinGeckoCodeAddDel
    {
        /// <summary>
        /// Lines added
        /// </summary>
        public int? Additions { get; set; }
        /// <summary>
        /// Lines deleted
        /// </summary>
        public int? Deletions { get; set; }
    }
}
