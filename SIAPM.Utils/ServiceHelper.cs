using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using SIAPM.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAPM.Utils
{
    public class ServiceHelper
    {
        public static IConfigurationRoot Configuration { get; set; }
        //AutofacModule autofacModule;
        public static IServiceProvider Container { get; private set; }
        private void InitializeServices()
        {
            const string ConnectionString = @"Data Source=ISCNPF0ZHB9X\SQLEXPRESS;Initial Catalog=SIAPMCos;Integrated Security=True";

            var services = new ServiceCollection();
            services.AddTransient<AttendLogService>();
            services.AddTransient<AttendTypeService>();
            services.AddTransient<EmployeeService>();

            services.AddDbContext<SIAPMContext>(options =>
                options.UseSqlServer(ConnectionString));


            Container = services.BuildServiceProvider();
        }
        public static TService getService<TService>()
        {
            return Container.GetService<TService>();
        }
    }
}
