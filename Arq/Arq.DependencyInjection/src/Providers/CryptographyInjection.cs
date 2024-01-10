using Arq.Adapters.Cryptographies;
using Arq.Infra.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Arq.DependencyInjection.Providers;

internal static class CryptographyInjection
{
    public static IServiceCollection AddCryptography(this IServiceCollection services, bool isDev)
    {
        return services.AddScoped<ICryptographys, TheWorstCrypt>();
    }
}


