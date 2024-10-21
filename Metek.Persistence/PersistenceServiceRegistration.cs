using Metek.Application.Services.Repositories;
using Metek.Persistence.Contexts;
using Metek.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Metek.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
//services.AddDbContext<BaseDbContext>(options => options.UseInMemoryDatabase("narchitecture"));
            services.AddScoped<IMesaiRepository, MesaiRepository>();

            return services;
        }
    }
}
