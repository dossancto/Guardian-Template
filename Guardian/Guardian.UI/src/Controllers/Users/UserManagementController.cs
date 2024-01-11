using Microsoft.AspNetCore.Mvc;
using Guardian.Application.Features.Users.UseCases;
using Guardian.Application.Features.Users.Entities;

namespace Guardian.UI.Controllers.Users;

public partial class UserController
{
    /// <summary>
    ///  Register User
    /// </summary>
    /// <remarks>Register a new User</remarks>
    /// <response code="202">Register a new User</response>
    /// <response code="500">Oops! Can't register a user now</response>
    [ProducesResponseType(typeof(User), 202)]
    [ProducesResponseType(500)]
    [HttpPost("register")]
    public async Task<ActionResult<User>> RegisterUser(RegisterUserDTO dto)
    {
        var user = await _register.Execute(dto);

        return Created("", user);
    }
}

