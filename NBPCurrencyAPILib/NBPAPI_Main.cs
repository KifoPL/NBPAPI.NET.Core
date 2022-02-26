using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text.Json;

namespace NBPAPI.NET.Core
{
	public static partial class NbpApi
	{
		private static HttpClient HttpClient => new()
		{
			DefaultRequestHeaders = { Accept = { new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json) } }
		};

		/// <summary>
		/// http://api.nbp.pl/api/
		/// </summary>
		private const string Uri = "http://api.nbp.pl/api/";
	}
}