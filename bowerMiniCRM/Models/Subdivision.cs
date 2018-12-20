using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class Subdivision : BaseObject
    {
        public Contact Owner { get; set; }
        public Contact SubOwner { get; set; }
        public string Notes { get; set; }
        public string Name { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
