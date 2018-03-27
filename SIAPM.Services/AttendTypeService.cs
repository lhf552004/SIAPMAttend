using SIAPM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIAPM.Services
{
    public class AttendTypeService : Service<AttendType>
    {
        
        public AttendTypeService(SIAPMContext sIAPMContext): base(sIAPMContext)
        {

        }
        public override IQueryable<AttendType> Query(Expression<Func<AttendType, bool>> query)
        {
            return _sIAPMContext.AttendTypes.Where(query);
        }

    }
}
