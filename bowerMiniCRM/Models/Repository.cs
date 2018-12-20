using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class Repository : BaseObject
    {
        public Contact Owner { get; set; }
        public string Notes { get; set; }
    }
}
