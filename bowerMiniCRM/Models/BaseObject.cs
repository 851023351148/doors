using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniCRM.Models
{
    public abstract class BaseObject
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public User CreatedBy { get; set; }
        public User ModifiedBy { get; set; }
    }
}
