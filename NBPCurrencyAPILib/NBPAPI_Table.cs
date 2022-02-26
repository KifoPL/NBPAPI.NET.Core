using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using NBPAPI.NET.Core.Enums;
using NBPAPI.NET.Core.Models;

namespace NBPAPI.NET.Core
{
	public static partial class NbpApi
	{
		#region GetTable

		/// <summary>
		/// Gets current table of exchange rates (asynchronous).
		/// </summary>
		/// <param name="tableCode">Table Code (Capital A-C).</param>
		/// <param name="fromToday"><c>true</c> if you want table specifically from today (may return null), <c>false</c> if currently effective.</param>
		/// <returns>Async XML/JSON result from NBP API.</returns>
		public static async Task<ExchangeRates.Table?> GetTableAsync(TableType tableCode, bool fromToday = false)
		{
			var tableLetter = tableCode.ToString();

			string getpath = Uri + $"exchangerates/tables/{tableLetter}{(fromToday ? "/today" : "")}";

			try { return (await HttpClient.GetFromJsonAsync<IEnumerable<ExchangeRates.Table>>(getpath))?.FirstOrDefault(); }
			catch (HttpRequestException e)
			{
				if (e.StatusCode is HttpStatusCode.NotFound)
					return null;
				throw;
			}
		}


		/// <summary>
		/// Gets table of exchange rates from <paramref name="date"/> (asynchronous).
		/// </summary>
		/// <param name="tableCode">Table Code (Capital A-C).</param>
		/// <param name="date"> the date.</param>
		/// <returns>Async XML/JSON result from NBP API.</returns>
		public static async Task<ExchangeRates.Table?> GetTableAsync(TableType tableCode, DateTime date)
		{
			var tableLetter = tableCode.ToString();

			string getpath = Uri + $"exchangerates/tables/{tableLetter}/{date:yyyy-MM-dd}";

			try { return (await HttpClient.GetFromJsonAsync<IEnumerable<ExchangeRates.Table>>(getpath))?.FirstOrDefault(); }
			catch (HttpRequestException e)
			{
				if (e.StatusCode is HttpStatusCode.NotFound)
					return null;
				throw;
			}
		}

		#endregion

		#region GetTables

		/// <summary>
		/// Gets last <paramref name="topCount"/> of tables (asynchronous).
		/// </summary>
		/// <param name="tableCode">Table Code (Capital A-C).</param>
		/// <param name="topCount">Amount of tables to return.</param>
		/// <returns>Async XML/JSON result from NBP API.</returns>
		public static async Task<IEnumerable<ExchangeRates.Table>?> GetTablesAsync(TableType tableCode, int topCount)
		{
			var tableLetter = tableCode.ToString();

			string getpath = Uri + $"exchangerates/tables/{tableLetter}/last/{topCount}";

			try { return await HttpClient.GetFromJsonAsync<IEnumerable<ExchangeRates.Table>>(getpath); }
			catch (HttpRequestException e)
			{
				if (e.StatusCode is HttpStatusCode.NotFound)
					return null;
				throw;
			}
		}

		/// <summary>
		/// Gets tables from <paramref name="startDate"/> to <paramref name="endDate"/> (asynchronous).
		/// </summary>
		/// <param name="tableCode">Table Code (Capital A-C).</param>
		/// <param name="startDate">Start date.</param>
		/// <param name="endDate">End date.</param>
		/// <returns>Async XML/JSON result from NBP API.</returns>
		public static async Task<IEnumerable<ExchangeRates.Table>?> GetTablesAsync(TableType tableCode,
			DateTime startDate,
			DateTime endDate)
		{
			string tableLetter = tableCode.ToString().ToUpper();

			string getpath = Uri
						   + $"exchangerates/tables/{tableLetter}/{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}";

			try { return await HttpClient.GetFromJsonAsync<IEnumerable<ExchangeRates.Table>>(getpath); }
			catch (HttpRequestException e)
			{
				if (e.StatusCode is HttpStatusCode.NotFound)
					return null;
				throw;
			}
		}

		#endregion GetTables
	}
}