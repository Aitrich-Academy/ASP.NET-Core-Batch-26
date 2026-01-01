using JWT_WebApi.Interface;
using JWT_WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JWT_WebApi.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();  
            services.AddScoped<ITok, Tok>();

            return services;
        }

    }
}
