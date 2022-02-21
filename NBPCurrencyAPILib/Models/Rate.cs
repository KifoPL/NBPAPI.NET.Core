using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBPAPI.NET.Core.Models
{
    public class Rate
    {
        public string Currency { get; set; }
        public string No { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal Mid { get; set; }
        public decimal Bid { get; set; }
        public decimal Ask { get; set; }
    }
}
