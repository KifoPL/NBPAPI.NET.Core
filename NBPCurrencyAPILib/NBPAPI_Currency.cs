using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using NBPAPI.NET.Core.Enums;
using NBPAPI.NET.Core.Models;

namespace NBPAPI.NET.Core
{
	/// <summary>
	/// Entry point for interaction with the library.
	/// </summary>
	public static partial class NbpApi
	{
		#region GetCurrency

		/// <summary>
		/// Gets current Exchange rate from PLN to <paramref name="currencyCode"/> (asynchronous).
		/// </summary>
		/// <param name="tableCode">Table Code (Capital A-C).</param>
		/// <param name="currencyCode">ISO 4217 Currency Code.</param>
		/// <param name="fromToday"><c>true</c> if you want table specifically from today (may return null), <c>false</c> if currently effective.</param>
		/// <returns>Async result from NBP API.</returns>
		public static async Task<ExchangeRates.Rate?> GetCurrencyAsync(TableType tableCode,
																	   string currencyCode,
																	   bool fromToday = false)
		{
			currencyCode = currencyCode.ToUpper();

			var tableLetter = tableCode.ToString();

			string getpath = Uri + $"exchangerates/rates/{tableLetter}/{currencyCode}{(fromToday ? "/today" : "")}";

			try { return await HttpClient.GetFromJsonAsync<ExchangeRates.Rate>(getpath); }
			catch (HttpRequestException e)
			{
				if (e.StatusCode is HttpStatusCode.NotFound)
					return null;
				throw;
			}
		}

		/// <summary>
		/// Gets current Exchange rate from PLN to <paramref name="currencyCode"/> published at <paramref name="date"/> (asynchronous).
		/// </summary>
		/// <param name="tableCode">Table Code (Capital A-C).</param>
		/// <param name="currencyCode">ISO 4217 Currency Code.</param>
		/// <param name="date">The date.</param>
		/// <returns>Async XML/JSON result from NBP API.</returns>
		public static async Task<ExchangeRates.Rate?> GetCurrencyAsync(TableType tableCode,
																	   string currencyCode,
																	   DateTime date)
		{
			currencyCode = currencyCode.ToUpper();

			var tableLetter = tableCode.ToString();

			string getpath = Uri
						   + $"exchangerates/rates/{tableLetter}/{currencyCode}/{date:yyyy-MM-dd}";

			try { return await HttpClient.GetFromJsonAsync<ExchangeRates.Rate>(getpath); }
			catch (HttpRequestException e)
			{
				if (e.StatusCode is HttpStatusCode.NotFound)
					return null;
				throw;
			}
		}

		#endregion GetCurrency

		#region GetCurrencies

		/// <summary>
		/// Gets last <paramref name="topCount"/> exchange rates from PLN to <paramref name="currencyCode"/> (asynchronous).
		/// </summary>
		/// <param name="tableCode">Table Code (Capital A-C).</param>
		/// <param name="currencyCode">ISO 4217 Currency Code.</param>
		/// <param name="topCount">Amount of exchange rates to return.</param>
		/// <returns>Async XML/JSON result from NBP API.</returns>
		public static async Task<ExchangeRates.Rate?> GetCurrenciesAsync(TableType tableCode,
																		 string currencyCode,
																		 int topCount)
		{
			currencyCode = currencyCode.ToUpper();

			var tableLetter = tableCode.ToString();

			string getpath = Uri + $"exchangerates/rates/{tableLetter}/{currencyCode}/last/{topCount}";

			try { return await HttpClient.GetFromJsonAsync<ExchangeRates.Rate>(getpath); }
			catch (HttpRequestException e)
			{
				if (e.StatusCode is HttpStatusCode.NotFound)
					return null;
				throw;
			}
		}

		/// <summary>
		/// Gets exchange rates from PLN to <paramref name="currencyCode"/> from <paramref name="startDate"/> to <paramref name="endDate"/> (asynchronous).
		/// </summary>
		/// <param name="tableCode">Table Code (Capital A-C).</param>
		/// <param name="currencyCode">ISO 4217 Currency Code.</param>
		/// <param name="startDate">Start date.</param>
		/// <param name="endDate">End date.</param>
		/// <returns>Async XML/JSON result from NBP API.</returns>
		public static async Task<ExchangeRates.Rate?> GetCurrenciesAsync(TableType tableCode,
																		 string currencyCode,
																		 DateTime startDate,
																		 DateTime endDate)
		{
			currencyCode = currencyCode.ToUpper();

			var tableLetter = tableCode.ToString();

			string getpath = Uri
						   + $"exchangerates/rates/{tableLetter}/{currencyCode}/{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}";

			try { return await HttpClient.GetFromJsonAsync<ExchangeRates.Rate>(getpath); }
			catch (HttpRequestException e)
			{
				if (e.StatusCode is HttpStatusCode.NotFound)
					return null;
				throw;
			}
		}

		#endregion GetCurrencies
	}
}