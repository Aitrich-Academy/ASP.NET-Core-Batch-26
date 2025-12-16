using JobProvider_BlazorApp.Data;
using JobProvider_BlazorApp.Helpers;
using JobProvider_BlazorApp.Interface;
using JobProvider_BlazorApp.Repositories;
using JobProvider_BlazorApp.Services;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace JobProvider_BlazorApp.Extension
{
    public static class ApplicationServiceExtension
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration Config)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IJobProviderRepository, JobProviderRepository>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddScoped<ProtectedSessionStorage>();
            services.AddAutoMapper(typeof(MappingProfile));


            return services;
        }
    }
}
