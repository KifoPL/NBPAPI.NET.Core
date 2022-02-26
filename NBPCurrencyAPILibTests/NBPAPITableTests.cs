using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using NBPAPI.NET.Core;
using NBPAPI.NET.Core.Enums;
using NBPAPI.NET.Core.Models;
using Xunit;

namespace NBPCurrencyAPILibTests
{
	public class NbpApiTableTests
	{
		public static IEnumerable<object[]> TableTypes => Enum.GetValues<TableType>().Select(x => new object[] { x });

		public static IEnumerable<object[]> TableTypeAndNumber1To10
		{
			get
			{
				foreach (var type in Enum.GetValues<TableType>())
					for (int i = 1; i <= 10; i++)
						yield return new object[] { type, i };
			}
		}
		private static void AssertTable(TableType tableType, ExchangeRates.Table table)
		{
			Assert.NotNull(table);
			Assert.Equal(tableType.ToString(), table.TableName);
			Assert.NotNull(table.No);
			Assert.NotNull(table.Rates);
			Assert.True(table.Rates?.Any());

			if (tableType == TableType.C)
				Assert.NotNull(table.TradingDate);
		}


		[Theory]
		[MemberData(nameof(TableTypes))]
		public async Task GetTableAsyncTest(TableType tableType)
		{
			var result = await NbpApi.GetTableAsync(tableType);
			AssertTable(tableType, result);
		}

		[Theory]
		[MemberData(nameof(TableTypeAndNumber1To10))]
		public async Task GetTableAtGivenDateAsyncTest(TableType tableType, int days)
		{
			var date = DateTime.Now.AddDays(-1 * days);

			var result = await NbpApi.GetTableAsync(tableType, date);
			if (result is not null)
				AssertTable(tableType, result);
		}

		[Theory]
		[MemberData(nameof(TableTypeAndNumber1To10))]
		public async Task GetLastNumberOfTablesTest(TableType tableType, int count)
		{
			var result = await NbpApi.GetTablesAsync(tableType, count);

			Assert.NotNull(result);

			var resultArr = result?.ToArray();
			Assert.Equal(count, resultArr?.Length);

			foreach (var table in resultArr)
			{
				AssertTable(tableType, table);
			}
		}

		[Theory]
		[MemberData(nameof(TableTypes))]
		public async Task GetTablesInDateRangeTest(TableType type)
		{
			var result = await NbpApi.GetTablesAsync(type,
				DateTime.Now.AddDays(-30),
				DateTime.Now.AddDays(-1));

			Assert.NotNull(result);
			Assert.NotEmpty(result);

			foreach (var table in result)
			{
				AssertTable(type, table);
			}
		}
	}
}