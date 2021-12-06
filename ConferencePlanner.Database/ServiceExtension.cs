using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePlanner.Database
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDBContext>(
                options => options.UseSqlite("Data Source=conferences.db"),
                ServiceLifetime.Transient);
        }


    }
}
