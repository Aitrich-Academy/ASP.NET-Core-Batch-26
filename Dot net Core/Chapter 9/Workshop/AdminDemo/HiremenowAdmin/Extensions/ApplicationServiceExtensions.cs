using Domain.Extensions;
using Domain.Models;
using Domain.Services.Admin.Interfaces;
using Domain.Services.Admin;
using Domain.Services.AuthUser.Interfaces;
using Domain.Services.AuthUser;
//using Domain.Services.Job.Interfaces;
//using Domain.Services.Job;
using Domain.Services.Login.Interfaces;
using Domain.Services.Login;
//using Domain.Services.Profile.Interfaces;
//using Domain.Services.Profile;
using Domain.Services.User.Interfaces;
using Domain.Services;
using Microsoft.EntityFrameworkCore;
using Domain.Services.User;

namespace HiremenowAdmin.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {

            //  services.AddApplicationServices1(config);
            services.AddDbContext<HireMeNowDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"),
                sqlOptions => sqlOptions.MigrationsAssembly("Domain"))
            );

            services.AddTransient<IEmailService, EmailService>();
            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();

            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IAuthUserService, AuthUserService>();
            
            services.AddScoped<IAuthUserService, AuthUserService>();
            services.AddHttpContextAccessor();
            
            services.AddScoped<IAdminServices, AdminServices>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IUserService, UserService>();



            return services;

            
        }
        }
}
