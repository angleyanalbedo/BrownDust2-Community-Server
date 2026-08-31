using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Bd2.Server.Config;

public static class ServiceSetup
{
    public static void RegisterApiServices(this IServiceCollection services)
    {
        var apiAssembly = Assembly.GetExecutingAssembly();

        var serviceTypes = apiAssembly.GetTypes()
            .Where(t =>
                t.IsClass &&
                !t.IsAbstract &&
                t.Namespace != null &&
                t.Namespace.StartsWith("Bd2.Server.Services") &&
                t.GetInterfaces().Any(i => i.Name == "I" + t.Name))
            .ToList();

        foreach (var serviceType in serviceTypes)
        {
            var interfaceType = serviceType.GetInterfaces().First(i => i.Name == "I" + serviceType.Name);
            if (interfaceType != null)
            {
                services.AddScoped(interfaceType, serviceType);
            }
        }
    }
}