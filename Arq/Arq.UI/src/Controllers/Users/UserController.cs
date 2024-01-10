using Microsoft.AspNetCore.Mvc;
using Arq.Application.Features.Users.UseCases;

namespace Arq.UI.Controllers.Users;

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
