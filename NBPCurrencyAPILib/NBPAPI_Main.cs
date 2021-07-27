using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace NBPCurrencyAPILib
{
    public static partial class NBPAPI
    {
        /// <summary>
        /// Table codes - A, B or C
        /// </summary>
        public enum TableCode
        {
            A,
            B,
            C
        }
        private static HttpClient httpClient = new();
        /// <summary>
        /// http://api.nbp.pl/api/
        /// </summary>
        private readonly static string uri = "http://api.nbp.pl/api/";

        /// <param name="tableCode">The table code.</param>
        /// <returns>Table Code as a letter</returns>
        /// <exception cref="ArgumentException">Incorrect table code.</exception>
        private static string TableLetter(TableCode tableCode)
        {
            return tableCode switch
            {
                TableCode.A => "A",
                TableCode.B => "B",
                TableCode.C => "C",
                _ => throw new ArgumentException("Incorrect table code!"),
            };
        }

        /// <param name="response">The response.</param>
        /// <returns>Error message with status code.</returns>
        private static HttpRequestException Error(HttpResponseMessage response)
        {
            return new HttpRequestException($"Error {response.StatusCode:D}: {response.ReasonPhrase}");
        }
    }
}