using Microsoft.Extensions.DependencyInjection;
using Arq.DependencyInjection.Providers;

namespace Arq.DependencyInjection;

public static class ProvidersInjection
{
    public static IServiceCollection AddProviders(this IServiceCollection services, bool isDev)
    {
        return services
                      .AddCryptography(isDev);
    }
}

