using SIAPM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIAPM.Services
{
    public class EmployeeService : Service<Employee>
    {
        
        public EmployeeService(SIAPMContext sIAPMContext): base(sIAPMContext)
        {

        }

        public override IQueryable<Employee> Query(Expression<Func<Employee, bool>> query)
        {
            return _sIAPMContext.Employees.Where(query);
        }
    }
}
