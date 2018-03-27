using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using SIAPM.Entities;

namespace SIAPM.Services
{
    public class SIAPMContext : DbContext
    {
        public SIAPMContext(DbContextOptions<SIAPMContext> options)
            : base(options)
        {
        }
       // public DbSet<AttendLog> AttendLogs { get; set; }
        public DbSet<AttendType> AttendTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<AttendLog> AttendLogs { get; set; }
    }
}
