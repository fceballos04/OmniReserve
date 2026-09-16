using Microsoft.Extensions.DependencyInjection;
using System.Reflection; // Necesario para Assembly

namespace OmniReserve.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Se registra MediatR
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}