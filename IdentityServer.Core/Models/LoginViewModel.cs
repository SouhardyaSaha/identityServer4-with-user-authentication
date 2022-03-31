using System.ComponentModel.DataAnnotations;

namespace IdentityServer.Core.Models;

public class LoginViewModel
{
    [Required] public string Email { get; set; } = string.Empty;

    [Required] public string Password { get; set; } = string.Empty;
    
    public bool RememberLogin { get; set; }
    
    public string ReturnUrl { get; set; } = string.Empty;
}