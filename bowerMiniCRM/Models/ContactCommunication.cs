using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class ContactCommunication : Communication
    {
        public Contact Contact { get; set; }
    }
}
