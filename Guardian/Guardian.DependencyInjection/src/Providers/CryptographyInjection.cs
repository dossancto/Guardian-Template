using Guardian.Adapters.Cryptographies;
using Guardian.Infra.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Guardian.DependencyInjection.Providers;

internal static class CryptographyInjection
{
    public static IServiceCollection AddCryptography(this IServiceCollection services, bool isDev)
    {
        return services.AddScoped<ICryptographys, TheWorstCrypt>();
    }
}


