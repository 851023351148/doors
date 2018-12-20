using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class DoorForSale : BaseObject
    {
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
    }
}
