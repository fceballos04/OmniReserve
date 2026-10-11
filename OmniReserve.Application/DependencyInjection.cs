using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OmniReserve.Application.Common.Behaviors;
using System.Reflection;

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