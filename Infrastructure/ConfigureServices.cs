using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddToDoDbContext(
            this IServiceCollection services,
            IConfiguration configuration
            )
        {
            services.AddDbContext<ToDoDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("ToDoDbContext")
                );
            });

            return services;
        }
    }
}
