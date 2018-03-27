using Sensing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAPM.Entities
{
    public class AttendLog : EntityBase
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }
        public string EmployeeID { get; set; }
        public DateTime EarlyIn { get; set; }
        public DateTime LastOut { get; set; }
        public AttendStatus AttendStatus { get; set; }
        public double LateMinute { get; set; }
        public double Overtime { get; set; }
        public double EarlyLeaveMinute { get; set; }
    }
}
