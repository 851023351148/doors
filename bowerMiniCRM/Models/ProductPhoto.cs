using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class ProductPhoto : Photo
    {
        public Product Product { get; set; }
    }
}
