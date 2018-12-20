using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class Store : BaseObject
    {
        public Contact Author { get; set; }
        public Contact Owner { get; set; }
        public string Notes { get; set; }
        public string Name { get; set; }
        public StoreType StoreTypeId { get; set; }
        public string Address { get; set; }
    }
}
