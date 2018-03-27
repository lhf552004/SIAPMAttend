using Sensing.Entities;
using Sensing.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAPM.Entities
{
    public enum AttendStatus
    {
        Normal = 0,
        Absent = 1,
        AbNormal = 2,
        Late = 3,
        MissIn = 4,
        MissOut = 5,
        EarlyLeave = 6,
        OverTime = 7
    }
    public class Employee: EntityBase
    {
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public AttendType AttendType { get; set; }
        
      
    }
}
