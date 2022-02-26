using System;
using NBPAPI.NET.Core.Enums;
using NBPAPI.NET.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net;

namespace NBPAPI.NET.Core
{
	public static partial class NbpApi
	{
		/// <summary>
		/// Gets current gold price asynchronously.
		/// </summary>
		/// <param name="fromToday"><c>true</c> if you want table specifically from today (may return null), <c>false</c> if currently effective.</param>
		/// <returns>Gold price.</returns>
		public static async Task<GoldRate?> GetGoldPriceAsync(bool fromToday = false)
		{
			string getpath = Uri + $"cenyzlota/{(fromToday ? "/today" : "")}";

			try { return (await HttpClient.GetFromJsonAsync<IEnumerable<GoldRate>>(getpath))?.FirstOrDefault(); }
			catch (HttpRequestException e)
			{
				if (e.StatusCode is HttpStatusCode.NotFound)
					return null;
				throw;
			}
		}

		/// <summary>
		/// Gets the gold price published at <paramref name="date"/> asynchronously.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <returns>Gold price, or null</returns>
		public static async Task<GoldRate?> GetGoldPriceAsync(DateTime date)
		{
			string getpath = Uri + $"cenyzlota/{date:yyyy-MM-dd}";

			try { return (await HttpClient.GetFromJsonAsync<IEnumerable<GoldRate>>(getpath))?.FirstOrDefault(); }
			catch (HttpRequestException e)
			{
				if (e.StatusCode is HttpStatusCode.NotFound)
					return null;
				throw;
			}
		}

		/// <summary>
		/// Gets the gold prices asynchronously.
		/// </summary>
		/// <param name="topCount">The top count.</param>
		/// <returns>List of gold prices.</returns>
		public static async Task<IEnumerable<GoldRate>?> GetGoldPricesAsync(int topCount)
		{
			string getpath = Uri + $"cenyzlota/last/{topCount}";

			try { return await HttpClient.GetFromJsonAsync<IEnumerable<GoldRate>>(getpath); }
			catch (HttpRequestException e)
			{
				if (e.StatusCode is HttpStatusCode.NotFound)
					return null;
				throw;
			}
		}

		/// <summary>
		/// Gets the gold prices asynchronously.
		/// </summary>
		/// <param name="startDate">The start date.</param>
		/// <param name="endDate">The end date.</param>
		/// <returns>List of gold prices.</returns>
		public static async Task<IEnumerable<GoldRate>?> GetGoldPricesAsync(DateTime startDate, DateTime endDate)
		{
			string getpath = Uri + $"cenyzlota/{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}";

			try { return await HttpClient.GetFromJsonAsync<IEnumerable<GoldRate>>(getpath); }
			catch (HttpRequestException e)
			{
				if (e.StatusCode is HttpStatusCode.NotFound)
					return null;
				throw;
			}
		}
	}
}