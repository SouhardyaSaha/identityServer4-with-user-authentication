using IdentityServer.Core.Models;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Core.Data.Seed;

public static class Seed
{
    public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
    {
        if (!userManager.Users.Any())
        {
            var user = new AppUser
            {
                Email = "bob@ex.com",
                UserName = "bob@ex.com",
                EmailConfirmed = true
            };

            await userManager.CreateAsync(user, "P@$$w0rd");
        }
    }
}