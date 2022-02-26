using System;

namespace NBPAPI.NET.Core.Models
{
	/// <summary>
	/// Rate retrieved in single-currency rate requests.
	/// </summary>
	public class CurrencyRate
	{
		public string? No { get; init; }
		public DateTime EffectiveDate { get; init; }
		public decimal? Bid { get; init; }
		public decimal? Mid { get; init; }
		public decimal? Ask { get; init; }
	}
}