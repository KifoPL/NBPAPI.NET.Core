using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace NBPCurrencyAPILib
{
    public static partial class NBPAPI
    {
        #region GetTable
        /// <summary>
        /// Gets current table of exchange rates (asynchronous).
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="isJSON"><c>true</c> if returned string will be JSON, <c>false</c> if XML.</param>
        /// <returns>Async XML/JSON result from NBP API.</returns>
        public static Task<string> GetTableAsync(TableCode tableCode, bool isJSON = true)
        {
            string tableLetter = TableLetter(tableCode);

            string getpath = uri + $"exchangerates/tables/{tableLetter}?format={(isJSON ? "json" : "xml")}";

            HttpResponseMessage result = httpClient.GetAsync(getpath).Result;

            if (!result.IsSuccessStatusCode) throw Error(result);

            return result.Content.ReadAsStringAsync();
        }
        /// <summary>
        /// Gets current table of exchange rates.
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="isJSON"><c>true</c> if returned string will be JSON, false if XML.</param>
        /// <returns>XML/JSON result from NBP API.</returns>
        public static string GetTable(TableCode tableCode, bool isJSON = true)
        {
            return GetTableAsync(tableCode, isJSON).Result;
        }


        /// <summary>
        /// Gets table of exchange rates from <paramref name="date"/> (asynchronous).
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="isJSON"><c>true</c> if returned string will be JSON, <c>false</c> if XML.</param>
        /// <param name="date"> the date.</param>
        /// <returns>Async XML/JSON result from NBP API.</returns>
        public static Task<string> GetTableAsync(TableCode tableCode, DateTime date, bool isJSON = true)
        {
            string tableLetter = TableLetter(tableCode);

            string getpath = uri + $"exchangerates/tables/{tableLetter}/{date:yyyy-MM-dd}?format={(isJSON ? "json" : "xml")}";

            HttpResponseMessage result = httpClient.GetAsync(getpath).Result;

            if (!result.IsSuccessStatusCode) throw Error(result);

            return result.Content.ReadAsStringAsync();
        }
        /// <summary>
        /// Gets table of exchange rates from <paramref name="date"/>.
        /// </summary>
        /// <param name="date">The Date.</param>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="isJSON"><c>true</c> if returned string will be JSON, false if XML.</param>
        /// <returns>XML/JSON result from NBP API.</returns>
        public static string GetTable(TableCode tableCode, DateTime date, bool isJSON = true)
        {
            return GetTableAsync(tableCode, date, isJSON).Result;
        }


        /// <summary>
        /// Gets table of exchange rates published today (asynchronous).
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="isJSON"><c>true</c> if returned string will be JSON, <c>false</c> if XML.</param>
        /// <returns>Async XML/JSON result from NBP API.</returns>
        public static Task<string> GetTableTodayAsync(TableCode tableCode, bool isJSON = true)
        {
            string tableLetter = TableLetter(tableCode);

            string getpath = uri + $"exchangerates/tables/{tableLetter}/today?format={(isJSON ? "json" : "xml")}";

            HttpResponseMessage result = httpClient.GetAsync(getpath).Result;

            if (!result.IsSuccessStatusCode) throw Error(result);

            return result.Content.ReadAsStringAsync();
        }
        /// <summary>
        /// Gets table of exchange rates published today.
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="isJSON"><c>true</c> if returned string will be JSON, false if XML.</param>
        /// <returns>XML/JSON result from NBP API.</returns>
        public static string GetTableToday(TableCode tableCode, bool isJSON = true)
        {
            return GetTableTodayAsync(tableCode, isJSON).Result;
        }
        #endregion GetTable



        #region GetTables
        /// <summary>
        /// Gets last <paramref name="topCount"/> of tables (asynchronous).
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="topCount">Amount of tables to return.</param>
        /// <param name="isJSON"><c>true</c> if returned string will be JSON, <c>false</c> if XML.</param>
        /// <returns>Async XML/JSON result from NBP API.</returns>
        public static Task<string> GetTablesAsync(TableCode tableCode, int topCount, bool isJSON = true)
        {
            string tableLetter = TableLetter(tableCode);

            string getpath = uri + $"exchangerates/tables/{tableLetter}/last/{topCount}?format={(isJSON ? "json" : "xml")}";

            HttpResponseMessage result = httpClient.GetAsync(getpath).Result;

            if (!result.IsSuccessStatusCode) throw Error(result);

            return result.Content.ReadAsStringAsync();
        }
        /// <summary>
        /// Gets last <paramref name="topCount"/> of tables.
        /// </summary>
        /// <param name="topCount">Amount of tables to return.</param>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="isJSON"><c>true</c> if returned string will be JSON, <c>false</c> if XML.</param>
        /// <returns>XML/JSON result from NBP API.</returns>
        public static string GetTables(TableCode tableCode, int topCount, bool isJSON = true)
        {
            return GetTablesAsync(tableCode, topCount, isJSON).Result;
        }
        /// <summary>
        /// Gets tables from <paramref name="startDate"/> to <paramref name="endDate"/> (asynchronous).
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="startDate">Start date.</param>
        /// <param name="endDate">End date.</param>
        /// <param name="isJSON"><c>true</c> if returned string will be JSON, <c>false</c> if XML.</param>
        /// <returns>Async XML/JSON result from NBP API.</returns>
        public static Task<string> GetTablesAsync(TableCode tableCode, DateTime startDate, DateTime endDate, bool isJSON = true)
        {
            string tableLetter = TableLetter(tableCode);

            string getpath = uri + $"exchangerates/tables/{tableLetter}/{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}?format={(isJSON ? "json" : "xml")}";

            HttpResponseMessage result = httpClient.GetAsync(getpath).Result;

            if (!result.IsSuccessStatusCode) throw Error(result);

            return result.Content.ReadAsStringAsync();
        }
        /// <summary>
        /// Gets tables from <paramref name="startDate"/> to <paramref name="endDate"/>.
        /// </summary>
        /// <param name="startDate">Start date.</param>
        /// <param name="endDate">End date.</param>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="isJSON"><c>true</c> if returned string will be JSON, <c>false</c> if XML.</param>
        /// <returns>XML/JSON result from NBP API.</returns>
        public static string GetTables(TableCode tableCode, DateTime startDate, DateTime endDate, bool isJSON = true)
        {
            return GetTablesAsync(tableCode, startDate, endDate, isJSON).Result;
        }
        #endregion GetTables
    }
}