using Microsoft.EntityFrameworkCore;
using Razor_Workshop.Data;
using Razor_Workshop.Helper;
using Razor_Workshop.Repository;
using Razor_Workshop.Services;
using System.Runtime.CompilerServices;

namespace Razor_Workshop.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobServices, JobServices>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;
        }
    }
}
