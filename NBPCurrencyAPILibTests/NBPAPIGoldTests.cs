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
	public class NbpApiGoldTests
	{
		public static IEnumerable<object[]> Numbers1To50
		{
			get
			{
				for (var i = 1; i <= 50; i++)
					yield return new object[] { i };
			}
		}

		private static void AssertGold(GoldRate rate)
		{
			Assert.NotNull(rate);
			Assert.NotNull(rate?.Cena);
			Assert.NotNull(rate?.Data);
			Assert.True(rate?.Cena > 0);
		}


		[Fact]
		public async Task GetGoldPriceAsyncTest()
		{
			var result = await NbpApi.GetGoldPriceAsync();

			AssertGold(result);
		}

		[Theory]
		[MemberData(nameof(Numbers1To50))]
		public async Task GetGolPriceAtGivenDateAsyncTest(int days)
		{
			var date = DateTime.Now.AddDays(-1 * days);

			var result = await NbpApi.GetGoldPriceAsync(date);
			if (result is not null)
				AssertGold(result);
		}

		[Theory]
		[MemberData(nameof(Numbers1To50))]
		public async Task GetLastNumberOfGoldPricesTest(int count)
		{
			var result = await NbpApi.GetGoldPricesAsync(count);

			Assert.NotNull(result);

			var resultArr = result.ToArray();

			Assert.Equal(count, resultArr.Length);

			foreach (var goldRate in resultArr) AssertGold(goldRate);
		}

		[Fact]
		public async Task GetPricesInDateRangeTest()
		{
			var result = await NbpApi.GetGoldPricesAsync(DateTime.Now.AddDays(-30), DateTime.Now.AddDays(-1));

			if (result is not null)
			{
				Assert.NotEmpty(result);
				foreach (var goldRate in result)
				{
					AssertGold(goldRate);
				}
			}
		}
	}
}