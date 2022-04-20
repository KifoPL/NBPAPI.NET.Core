using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace NBPCurrencyAPILib.Tests
{
    [TestClass()]
    public class NBPAPITableTests
    {

        [TestMethod()]
        public void GetTableAsyncTest()
        {
            Assert.IsNotNull(NBPAPI.GetTable('A').Rates.SingleOrDefault(r => r.Code == "EUR"));
        }

        [TestMethod()]
        public void GetTableAsyncTestAtDate()
        {
            Assert.IsNotNull(NBPAPI.GetTable('A', new DateTime(2021, 07, 20)).Rates.SingleOrDefault(r => r.Code == "EUR"));
        }

        [TestMethod()]
        public void GetTableTodayAsyncTest()
        {
            Assert.IsNotNull(NBPAPI.GetTableToday('A').Rates.SingleOrDefault(r => r.Code == "EUR"));
        }

        [TestMethod()]
        public void GetTablesAsyncTest()
        {
            var table = NBPAPI.GetTables('A', 3);
            Assert.IsTrue(table.Count() == 3);
            Assert.IsNotNull(table.FirstOrDefault().Rates.SingleOrDefault(r => r.Code == "EUR"));
        }

        [TestMethod()]
        public void GetTablesAsyncTestFromTo()
        {
            Assert.IsNotNull(NBPAPI.GetTables('A', new DateTime(2021, 07, 20), new DateTime(2021, 07, 26)).FirstOrDefault().Rates.SingleOrDefault(r => r.Code == "EUR"));
        }
    }
}