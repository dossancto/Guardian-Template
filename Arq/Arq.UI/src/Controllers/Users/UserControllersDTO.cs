using Arq.Application.Features.Users.Entities;
using System.ComponentModel.DataAnnotations;

namespace Arq.UI.Controllers.Users;

public record SafeUserResponse
{
    /// <summary>
    /// The full user name .
    /// </summary>
    /// <example>All Might</example>
    [Required]
    public string Name { get; set; } = default!;

    /// <summary>
    /// The user email, its a valid email address
    /// </summary>
    /// <example>allMight@ua.com</example>
    [Required]
    [EmailAddress]
    public string Email { get; set; } = default!;

    public static SafeUserResponse From(User x)
      => new()
      {
          Name = x.Name,
          Email = x.Email
      };
}

