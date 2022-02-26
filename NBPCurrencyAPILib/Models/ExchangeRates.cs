using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NBPAPI.NET.Core.Models
{
	/// <summary>
	/// Class containing definitions of 
	/// </summary>
	public class ExchangeRates
	{
		/// <summary>
		/// Definition of exchange rate table
		/// </summary>
		public class Table
		{
			[JsonPropertyName("Table")]
			public string? TableName { get; init; }
			public string? No { get; init; }
			public DateTime EffectiveDate { get; init; }
			public DateTime? TradingDate { get; init; }
			public IEnumerable<TableRate>? Rates { get; init; }

		}

		/// <summary>
		/// Definition of single-currency exchange rate table
		/// </summary>
		public class Rate
		{
			[JsonPropertyName("Table")]
			public string? TableName { get; init; }
			public string? Country { get; init; }
			public string? Symbol { get; init; }
			public string? Currency { get; init; }
			public string? Code { get; init; }
			public IEnumerable<CurrencyRate>? Rates { get; init; }
		}
	}
}