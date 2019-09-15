using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEat.Domain
{
    public class Deal
    {
        public string Description { get; set; }
        public string DiscountPercent { get; set; }
        public string QualifyingPrice { get; set; }
    }
}
