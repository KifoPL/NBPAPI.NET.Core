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
        public void GetCurrenciesAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetCurrenciesAsync(NBPAPI.TableCode.A, "EUR", 3).Result.Contains("code"));
        }

        [TestMethod()]
        public void GetCurrencyAsyncAtDateTest()
        {
            Assert.IsTrue(NBPAPI.GetCurrencyAsync(NBPAPI.TableCode.A, "EUR", new DateTime(2021, 07, 12)).Result.Contains("code"));
        }
    }
}