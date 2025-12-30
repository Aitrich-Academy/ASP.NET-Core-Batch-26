using HireMeNow_MVC_Application.Data;
using HireMeNow_MVC_Application.Interfaces;
using HireMeNow_MVC_Application.Repositories;
using HireMeNow_MVC_Application.Services;
using Microsoft.EntityFrameworkCore;

namespace HireMeNow_MVC_Application.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IPublicService, PublicService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMappaerProfiles));
            services.AddSession();

            return services;

        }
    }
}
