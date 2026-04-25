using Domain.Models;
using Domain.Service.Admin;
using Domain.Service.Admin.Interface;
using Domain.Service.Auth_User;
using Domain.Service.Auth_User.Interface;
using Domain.Service.Login;
using Domain.Service.Login.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices( this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<DbHireMeNowWebApiContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IAuthUserService, AuthUserService>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddHttpContextAccessor();
            return services;
        }
    }
}
