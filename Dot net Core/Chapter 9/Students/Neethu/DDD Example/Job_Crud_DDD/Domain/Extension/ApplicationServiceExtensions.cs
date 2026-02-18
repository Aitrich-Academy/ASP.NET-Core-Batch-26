using Domain.Helper;
using Domain.Interfaces;
using Domain.Models;
using Domain.Repositories;
using Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extension
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IJobRepository,JobRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;
        }
    }
}
