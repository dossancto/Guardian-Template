using Guardian.Application.Features.Users.Data;
using Guardian.Infra.Database.EF.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Guardian.DependencyInjection;

public static class RepositoriesInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, bool isDev)
    => services
              .AddScoped<IUserRepository, EFUserRepository>()
    ;
}


