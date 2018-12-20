using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class SaleProduct : BaseObject
    {
        public Product Product { get; set; }
        public string Note { get; set; }
        public decimal Discount { get; set; }
        public Sale Sale { get; set; }
        public int Amount { get; set; }
    }
}
