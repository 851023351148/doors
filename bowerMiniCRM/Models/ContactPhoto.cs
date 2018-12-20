using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class ContactPhoto : Photo
    {
        public Sale Sale { get; set; }
    }
}
