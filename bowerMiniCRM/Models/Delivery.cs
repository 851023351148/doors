using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class Delivery : BaseObject
    {
        public User Author { get; set; }
        public User Owner { get; set; }
        public string Notes { get; set; }
        public bool NeedRequest { get; set; }
        public Request Request { get; set; }
        public SaleStatus SaleStatus { get; set; }
        public Contact ClientContact { get; set; }
    }
}
