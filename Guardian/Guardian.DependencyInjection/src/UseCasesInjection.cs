using Guardian.DependencyInjection.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Guardian.DependencyInjection;

public static class UseCasesInjection
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
      => services
                .AddUserUseCases();
}



