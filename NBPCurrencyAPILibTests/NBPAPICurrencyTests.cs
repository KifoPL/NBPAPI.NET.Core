using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBPAPI.NET.Core;
using NBPAPI.NET.Core.Enums;
using NBPAPI.NET.Core.Models;
using Xunit;

namespace NBPCurrencyAPILibTests
{
	public class NbpApiCurrencyTests
	{
		private const string CurrencyCode = "EUR";

		public static IEnumerable<object[]> TableTypes => Enum.GetValues<TableType>().Select(x => new object[] { x });

		public static IEnumerable<object[]> TableTypeAndNumber1To10
		{
			get
			{
				foreach (var type in Enum.GetValues<TableType>())
					for (var i = 1; i <= 10; i++)
						yield return new object[] { type, i };
			}
		}

		private static void AssertRate(TableType tableType, ExchangeRates.Rate rate)
		{
			Assert.NotNull(rate);
			Assert.Equal(tableType.ToString(), rate.TableName);
			Assert.NotNull(rate.Code);
			Assert.NotNull(rate.Currency);
			Assert.NotNull(rate.Rates);
			Assert.True(rate.Rates?.Any());

			if (tableType != TableType.B) return;

			Assert.NotNull(rate.Symbol);
			Assert.NotNull(rate.Country);
		}


		[Theory]
		[MemberData(nameof(TableTypes))]
		public async Task GetCurrencyAsyncTest(TableType tableType)
		{
			var result = await NbpApi.GetCurrencyAsync(tableType, CurrencyCode);

			AssertRate(tableType, result);
		}

		[Theory]
		[MemberData(nameof(TableTypeAndNumber1To10))]
		public async Task GetCurrencyAtGivenDateAsyncTest(TableType tableType, int days)
		{
			var date = DateTime.Now.AddDays(-1 * days);

			var result = await NbpApi.GetCurrencyAsync(tableType, CurrencyCode, date);
			if (result is not null)
				AssertRate(tableType, result);
		}

		[Theory]
		[MemberData(nameof(TableTypeAndNumber1To10))]
		public async Task GetLastNumberOfCurrenciesTest(TableType tableType, int count)
		{
			var result = await NbpApi.GetCurrenciesAsync(tableType, CurrencyCode, count);

			Assert.NotNull(result);

			var resultArr = result.Rates.ToArray();
			Assert.Equal(count, resultArr?.Length);

			AssertRate(tableType, result);
		}

		[Theory]
		[MemberData(nameof(TableTypes))]
		public async Task GetCurrenciesInDateRangeTest(TableType type)
		{
			var result = await NbpApi.GetCurrenciesAsync(type,
				CurrencyCode,
				DateTime.Now.AddDays(-30),
				DateTime.Now.AddDays(-1));

			if (result is not null)
			{
				Assert.NotNull(result);
				Assert.NotEmpty(result.Rates);
				AssertRate(type, result);
			}
		}
	}
}