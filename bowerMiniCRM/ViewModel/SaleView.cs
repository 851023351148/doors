using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniCRM.Models;

namespace bowerMiniCRM.ViewModel
{
    public class SaleView : BaseObject
    {
        public Contact Owner { get; set; }
        public Request Request { get; set; }
        public SaleStatus SaleStatus { get; set; }
        public Contact ClientContact { get; set; }
        public Product Product { get; set; }
        public Delivery Delivery { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
    }
}
