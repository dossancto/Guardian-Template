using Microsoft.AspNetCore.Mvc;
using Guardian.Application.Features.Users.UseCases;

namespace Guardian.UI.Controllers.Users;

[ApiController]
[Route("[controller]")]
public partial class UserController : ControllerBase
{
    private readonly RegisterUserUseCase _register;
    private readonly LoginUserUseCase _login;

    public UserController(RegisterUserUseCase register, LoginUserUseCase login)
    {
        _register = register;
        _login = login;
    }
}
