using System.Collections.Generic;

namespace NBPAPI.NET.Core.Models.Table
{
    public class ExchangeRatesTable
    {
        public string Table { get; set; }
        public string No { get; set; }
        public string EffectiveDate { get; set; }
        public IEnumerable<Rate> Rates { get; set; }
    }
}
