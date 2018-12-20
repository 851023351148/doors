using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class Request : BaseObject
    {
        public Contact Author { get; set; }
        public Contact Owner { get; set; }
        public string Notes { get; set; }
        public string Name { get; set; }
        public Sale Sale { get; set; }
    }
}
