using Arq.DependencyInjection.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Arq.DependencyInjection;

public static class UseCasesInjection
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
      => services
                .AddUserUseCases();
}



