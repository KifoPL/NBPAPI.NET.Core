using Microsoft.VisualStudio.TestTools.UnitTesting;
using NBPCurrencyAPILib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBPCurrencyAPILib.Tests
{
    [TestClass()]
    public class NBPAPITests
    {
        [TestMethod()]
        public void GetCurrencyAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetCurrencyAsync(NBPAPI.TableCode.A, "EUR").Result.Contains("code"));
        }

        [TestMethod()]
        public void GetCurrencyTodayAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetCurrencyTodayAsync(NBPAPI.TableCode.A, "EUR").Result.Contains("code"));
        }

        [TestMethod()]
        public void GetCurrencyAsyncAtDateTest()
        {
            Assert.IsTrue(NBPAPI.GetCurrencyAsync(NBPAPI.TableCode.A, "EUR", new DateTime(2021, 07, 12)).Result.Contains("code"));
        }

        [TestMethod()]
        public void GetCurrenciesAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetCurrenciesAsync(NBPAPI.TableCode.A, "EUR", 3).Result.Contains("code"));
        }

        [TestMethod()]
        public void GetCurrenciesAsyncTestFromTo()
        {
            Assert.IsTrue(NBPAPI.GetCurrenciesAsync(NBPAPI.TableCode.A, "EUR", new DateTime(2021, 07, 21), new DateTime(2021, 07, 25)).Result.Contains("code"));
        }

        [TestMethod()]
        public void GetTableAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetTableAsync(NBPAPI.TableCode.A).Result.Contains("EUR"));
        }

        [TestMethod()]
        public void GetTableAsyncTestAtDate()
        {
            Assert.IsTrue(NBPAPI.GetTableAsync(NBPAPI.TableCode.A, new DateTime(2021, 07, 20)).Result.Contains("EUR"));
        }

        [TestMethod()]
        public void GetTableTodayAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetTableTodayAsync(NBPAPI.TableCode.A).Result.Contains("EUR"));
        }

        [TestMethod()]
        public void GetTablesAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetTablesAsync(NBPAPI.TableCode.A, 3).Result.Contains("EUR"));
        }

        [TestMethod()]
        public void GetTablesAsyncTestFromTo()
        {
            Assert.IsTrue(NBPAPI.GetTablesAsync(NBPAPI.TableCode.A, new DateTime(2021, 07, 20), new DateTime(2021, 07, 26)).Result.Contains("EUR"));
        }
    }
}