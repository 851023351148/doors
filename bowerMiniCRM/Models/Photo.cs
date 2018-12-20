using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class Photo : BaseObject
    {
        public string Notes { get; set; }
        public string Name { get; set; }
        public Blob PhotoBlob { get; set; }
    }
}
