using Arq.Application.Features.Users.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Arq.DependencyInjection.UseCases;

internal static class UserUseCasesInjection
{
    public static IServiceCollection AddUserUseCases(this IServiceCollection services)
      => services
                .AddScoped<RegisterUserUseCase>()
      ;
}




