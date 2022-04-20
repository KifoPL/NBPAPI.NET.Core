using NBPAPI.NET.Core.Models.Table;
using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace NBPCurrencyAPILib
{
    public static partial class NBPAPI
    {
        private static string ParseTableLetter(char tableCode)
        {
            var tableLetter = tableCode.ToString().ToUpper();

            if (!TableLetterCheck(tableLetter[0]))
                throw new ArgumentException("Incorrect table letter!");

            return tableLetter;
        }

        #region GetTable
        /// <summary>
        /// Gets current table of exchange rates (asynchronous).
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <returns>Exchange rates table.</returns>
        public static async Task<ExchangeRatesTable> GetTableAsync(char tableCode)
        {
            string getpath = uri + $"exchangerates/tables/{ParseTableLetter(tableCode)}?format=json";

            HttpResponseMessage result = httpClient.GetAsync(getpath).Result;

            if (!result.IsSuccessStatusCode) throw Error(result);

            return JsonSerializer.Deserialize<ExchangeRatesTable[]>(await result.Content.ReadAsStringAsync(), JsonOptions).SingleOrDefault();
        }
        /// <summary>
        /// Gets current table of exchange rates.
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <returns>Exchange rates table.</returns>
        public static ExchangeRatesTable GetTable(char tableCode)
        {
            return GetTableAsync(tableCode).Result;
        }

        /// <summary>
        /// Gets table of exchange rates from <paramref name="date"/> (asynchronous).
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="date"> the date.</param>
        /// <returns>Exchange rates table.</returns>
        public static async Task<ExchangeRatesTable> GetTableAsync(char tableCode, DateTime date)
        {
            string getpath = uri + $"exchangerates/tables/{ParseTableLetter(tableCode)}/{date:yyyy-MM-dd}?format=json";

            HttpResponseMessage result = httpClient.GetAsync(getpath).Result;

            if (!result.IsSuccessStatusCode) throw Error(result);

            return JsonSerializer.Deserialize<ExchangeRatesTable[]>(await result.Content.ReadAsStringAsync(), JsonOptions).SingleOrDefault();
        }
        /// <summary>
        /// Gets table of exchange rates from <paramref name="date"/>.
        /// </summary>
        /// <param name="date">The Date.</param>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <returns>Exchange rates table.</returns>
        public static ExchangeRatesTable GetTable(char tableCode, DateTime date)
        {
            return GetTableAsync(tableCode, date).Result;
        }


        /// <summary>
        /// Gets table of exchange rates published today (asynchronous).
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <returns>Exchange rates table.</returns>
        public static async Task<ExchangeRatesTable> GetTableTodayAsync(char tableCode)
        {
            string getpath = uri + $"exchangerates/tables/{ParseTableLetter(tableCode)}/today?format=json";

            HttpResponseMessage result = httpClient.GetAsync(getpath).Result;

            if (!result.IsSuccessStatusCode) throw Error(result);

            return JsonSerializer.Deserialize<ExchangeRatesTable[]>(await result.Content.ReadAsStringAsync(), JsonOptions).SingleOrDefault();
        }
        /// <summary>
        /// Gets table of exchange rates published today.
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <returns>Exchange rates table.</returns>
        public static ExchangeRatesTable GetTableToday(char tableCode)
        {
            return GetTableTodayAsync(tableCode).Result;
        }
        #endregion GetTable

        #region GetTables
        /// <summary>
        /// Gets last <paramref name="topCount"/> of tables (asynchronous).
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="topCount">Amount of tables to return.</param>
        /// <returns>Array of exchange rates tables.</returns>
        public static async Task<ExchangeRatesTable[]> GetTablesAsync(char tableCode, int topCount)
        {
            string getpath = uri + $"exchangerates/tables/{ParseTableLetter(tableCode)}/last/{topCount}?format=json";

            HttpResponseMessage result = httpClient.GetAsync(getpath).Result;

            if (!result.IsSuccessStatusCode) throw Error(result);

            return JsonSerializer.Deserialize<ExchangeRatesTable[]>(await result.Content.ReadAsStringAsync(), JsonOptions);
        }
        /// <summary>
        /// Gets last <paramref name="topCount"/> of tables.
        /// </summary>
        /// <param name="topCount">Amount of tables to return.</param>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <returns>Array of exchange rates tables.</returns>
        public static ExchangeRatesTable[] GetTables(char tableCode, int topCount)
        {
            return GetTablesAsync(tableCode, topCount).Result;
        }
        /// <summary>
        /// Gets tables from <paramref name="startDate"/> to <paramref name="endDate"/> (asynchronous).
        /// </summary>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <param name="startDate">Start date.</param>
        /// <param name="endDate">End date.</param>
        /// <returns>Array of exchange rates tables.</returns>
        public static async Task<ExchangeRatesTable[]> GetTablesAsync(char tableCode, DateTime startDate, DateTime endDate)
        {
            string getpath = uri + $"exchangerates/tables/{ParseTableLetter(tableCode)}/{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}?format=json";

            HttpResponseMessage result = httpClient.GetAsync(getpath).Result;

            if (!result.IsSuccessStatusCode) throw Error(result);

            return JsonSerializer.Deserialize<ExchangeRatesTable[]>(await result.Content.ReadAsStringAsync(), JsonOptions);
        }
        /// <summary>
        /// Gets tables from <paramref name="startDate"/> to <paramref name="endDate"/>.
        /// </summary>
        /// <param name="startDate">Start date.</param>
        /// <param name="endDate">End date.</param>
        /// <param name="tableCode">Table Code (Capital A-C).</param>
        /// <returns>Array of exchange rates tables.</returns>
        public static ExchangeRatesTable[] GetTables(char tableCode, DateTime startDate, DateTime endDate)
        {
            return GetTablesAsync(tableCode, startDate, endDate).Result;
        }
        #endregion GetTables
    }
}