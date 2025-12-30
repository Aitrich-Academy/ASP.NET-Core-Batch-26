using JobPortal_CompanyRegistration.Helper;
using JobPortal_CompanyRegistration.Models;
using JobPortal_CompanyRegistration.Repositories;
using JobPortal_CompanyRegistration.Services;
using Microsoft.EntityFrameworkCore;

namespace JobPortal_CompanyRegistration.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }

    }
}
