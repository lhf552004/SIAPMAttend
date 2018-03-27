using Sensing.Entities;
using Sensing.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAPM.Entities
{
    public class AttendType : EntityBase
    {
        
        public bool IsShift { get; set; }
        public string Name { get; set; }
        public int TargetHourIn { get; set; }
        public int TargetMinuteIn { get; set; }
        public int ShiftTime { get; set; }

        public int StartDinnerBreakHour { get; set; }
        public int StartDinnerBreakMinute { get; set; }
        public int DinnerBreakMinute { get; set; }
        public int TempBreakMinute { get; set; }

    }
}
