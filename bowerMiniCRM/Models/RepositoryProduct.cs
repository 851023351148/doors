using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class RepositoryProduct : BaseObject
    {
        public string Notes { get; set; }
        public Repository Repository { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public int Reserve { get; set; }
    }
}
