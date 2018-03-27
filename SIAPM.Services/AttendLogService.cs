using SIAPM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIAPM.Services
{
    public class AttendLogService : Service<AttendLog>
    {
        
        public AttendLogService(SIAPMContext sIAPMContext): base(sIAPMContext)
        {

        }

        public override IQueryable<AttendLog> Query(Expression<Func<AttendLog, bool>> query)
        {
            return _sIAPMContext.AttendLogs.Where(query);
        }
    }
}
