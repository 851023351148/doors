using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public class Contact : BaseObject
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Note { get; set; }
        public string Appeal { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public Position Position { get; set; }
        public Guid SubdivisionId { get; set; }
        public Subdivision Subdivision { get; set; }
        public string IIN { get; set; }
        public string Experience { get; set; }
        public string Skills { get; set; }
    }
}
