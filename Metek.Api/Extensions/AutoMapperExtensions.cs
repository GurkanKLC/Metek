using Metek.Application.Profiles.MesaiProfiles;
using Microsoft.Extensions.DependencyInjection;

namespace Metek.Api.Extensions
{
    public static class AutoMapperExtensions
    {
        public static IServiceCollection AddAutoMapperServices(this IServiceCollection services)
        {
            // Register AutoMapper with the assemblies where profiles are located
            services.AddAutoMapper(typeof(MesaiProfile)); // Or specify any other type in your assembly containing profiles
            return services;
        }
    }
}
