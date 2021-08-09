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
    public class NBPAPITableTests
    {

        [TestMethod()]
        public void GetTableAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetTableAsync('A').Result.Contains("EUR"));
        }

        [TestMethod()]
        public void GetTableAsyncTestAtDate()
        {
            Assert.IsTrue(NBPAPI.GetTableAsync('A', new DateTime(2021, 07, 20)).Result.Contains("EUR"));
        }

        [TestMethod()]
        public void GetTableTodayAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetTableTodayAsync('A').Result.Contains("EUR"));
        }

        [TestMethod()]
        public void GetTablesAsyncTest()
        {
            Assert.IsTrue(NBPAPI.GetTablesAsync('A', 3).Result.Contains("EUR"));
        }

        [TestMethod()]
        public void GetTablesAsyncTestFromTo()
        {
            Assert.IsTrue(NBPAPI.GetTablesAsync('A', new DateTime(2021, 07, 20), new DateTime(2021, 07, 26)).Result.Contains("EUR"));
        }
    }
}