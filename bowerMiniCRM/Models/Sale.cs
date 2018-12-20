using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class Sale : BaseObject
    {
        public Contact Author { get; set; }
        public Contact Owner { get; set; }
        public string Notes { get; set; }
        public bool NeedRequest { get; set; }
        public Request Request { get; set; }
        public SaleStatus SaleStatus { get; set; }
        public Contact ClientContact { get; set; }
    }
}
