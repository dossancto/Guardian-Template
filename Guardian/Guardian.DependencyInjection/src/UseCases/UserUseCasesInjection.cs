using Guardian.Application.Features.Users.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Guardian.DependencyInjection.UseCases;

internal static class UserUseCasesInjection
{
    public static IServiceCollection AddUserUseCases(this IServiceCollection services)
      => services
                .AddScoped<RegisterUserUseCase>()
      ;
}




