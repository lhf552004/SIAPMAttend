using Sensing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAPM.Entities
{
    public enum ExceptionType
    {
        TempBreak =0,
        DinnerBreak =1,
        AttendException = 2
    }
    public class AttendExceptionLog : EntityBase
    {
        public DateTime OutClock { get; set; }
        public DateTime InClock { get; set; }
        public ExceptionType ExceptionType { get; set; }
        public string EmployeeID { get; set; }
        
    }
}
