using Arq.Application.Features.Users.Data;
using Arq.Infra.Database.EF.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Arq.DependencyInjection;

public static class RepositoriesInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, bool isDev)
    => services
              .AddScoped<IUserRepository, EFUserRepository>()
    ;
}


