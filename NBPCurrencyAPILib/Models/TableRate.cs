namespace NBPAPI.NET.Core.Models
{
	/// <summary>
	/// Rate retrieved in tables request
	/// </summary>
	public class TableRate
	{
		public string? Currency { get; init; }
		public string? Code { get; init; }
		public decimal? Bid { get; init; }
		public decimal? Mid { get; init; }
		public decimal? Ask { get; init; }
	}
}