using System.Collections.Generic;

namespace NBPAPI.NET.Core.Models
{
    public class ExchangeRatesSeries
    {
        public string Table { get; set; }
        public string Currency { get; set; }
        public string Code { get; set; }
        public IEnumerable<Rate> Rates { get; set; }
    }
}
