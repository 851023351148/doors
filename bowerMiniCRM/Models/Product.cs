using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class Product : BaseObject
    {
        public string Notes { get; set; }
        public string Name { get; set; }
        public OpenType OpenType { get; set; }
        public MadeFrom MadeFrom { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public decimal PrimaryPrice { get; set; }
        public decimal Overpricing { get; set; }
        public decimal Taxes { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
