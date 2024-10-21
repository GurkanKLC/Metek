using Metek.Application.Features.Mesai.Commands.Create;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Metek.Api.Extensions
{
    public static class MediaTrExtensions
    {
        public static IServiceCollection AddMediaTrServices(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()); // Metek.Api
                config.RegisterServicesFromAssembly(typeof(CreateMesaiCommand).Assembly); // Metek.Application gibi başka bir assembly
            });
            return services;
        }
    }
}
