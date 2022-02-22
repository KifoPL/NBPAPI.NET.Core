using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace NBPCurrencyAPILib.Tests
{
    [TestClass()]
    public class NBPAPICurrencyTests
    {
        [TestMethod()]
        public void GetCurrencyAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetCurrencyAsync('A', "EUR").Result.Contains("code"));
        }

        [TestMethod()]
        public void GetCurrencyTodayAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetCurrencyTodayAsync('A', "EUR").Result.Contains("code"));
        }

        [TestMethod()]
        public void GetCurrencyAsyncAtDateTest()
        {
            Assert.IsTrue(NBPAPI.GetCurrencyAsync('A', "EUR", new DateTime(2021, 07, 12)).Result.Contains("code"));
        }

        [TestMethod()]
        public void GetCurrenciesAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetCurrenciesAsync('A', "EUR", 3).Result.Currency.Any());
        }

        [TestMethod()]
        public void GetCurrenciesAsyncTestFromTo()
        {
            Assert.IsTrue(NBPAPI.GetCurrenciesAsync('A', "EUR", new DateTime(2021, 07, 21), new DateTime(2021, 07, 25)).Result.Currency.Any());
        }

    }
}