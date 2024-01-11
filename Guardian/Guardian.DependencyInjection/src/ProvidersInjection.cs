using Microsoft.Extensions.DependencyInjection;
using Guardian.DependencyInjection.Providers;

namespace Guardian.DependencyInjection;

public static class ProvidersInjection
{
    public static IServiceCollection AddProviders(this IServiceCollection services, bool isDev)
    {
        return services
                      .AddCryptography(isDev);
    }
}

