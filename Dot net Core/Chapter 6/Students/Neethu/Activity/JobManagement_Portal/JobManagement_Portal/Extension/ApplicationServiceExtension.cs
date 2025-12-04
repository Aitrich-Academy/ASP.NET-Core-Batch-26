using JobManagement_Portal.Helper;
using JobManagement_Portal.Interface;
using JobManagement_Portal.Models;
using JobManagement_Portal.Repository;
using JobManagement_Portal.Service;
using Microsoft.EntityFrameworkCore;

namespace JobManagement_Portal.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddScoped<IJobService,JobService>();
            services.AddScoped<IJobRepository, JobRepository>();


            return services;
        }
    }
}
