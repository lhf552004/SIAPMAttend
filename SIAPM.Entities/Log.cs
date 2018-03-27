using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAPM.Entities
{
    public enum EntryType
    {
        In = 0,
        Out = 1
    }
    public class Log
    {
        public string EmployeeID { get; set; }
        public EntryType EntryType { get; set; }
        public DateTime Clock { get; set; }
    }
}
