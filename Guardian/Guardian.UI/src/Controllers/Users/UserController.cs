using Microsoft.AspNetCore.Mvc;
using Guardian.Application.Features.Users.UseCases;

namespace Guardian.UI.Controllers.Users;

[ApiController]
[Route("[controller]")]
public partial class UserController : ControllerBase
{
    private readonly RegisterUserUseCase _register;

    public UserController(RegisterUserUseCase register)
    {
        _register = register;
    }
}
