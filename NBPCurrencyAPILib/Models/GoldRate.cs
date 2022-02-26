using System;

namespace NBPAPI.NET.Core.Models
{
	/// <summary>
	/// Price of 1 kg of gold in PLN
	/// </summary>
	public class GoldRate
	{
		public DateTime Data { get; init; }
		public decimal Cena { get; init; }
	}
}