using Arq.Infra.Database;
using DotNetEnv;
using Microsoft.Extensions.DependencyInjection;

namespace Arq.DependencyInjection;

public static class EnvironmentInjection
{
    public static IServiceCollection AddEnvironment(this IServiceCollection services, bool isDev)
    {
        Env.TraversePath().Load();

        services.AddDatabase();

        return services;
    }

}
