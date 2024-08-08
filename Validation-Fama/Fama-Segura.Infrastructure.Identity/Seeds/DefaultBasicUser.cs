﻿using Microsoft.AspNetCore.Identity;
using Fama_Segura.Core.Application.Enums;
using Fama_Segura.Infrastructure.Identity.Entities;


namespace Fama_Segura.Infrastructure.Identity.Seeds
{
    public static class DefaultBasicUser
    {
        public static async Task SeedAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            AppUser defaultUser = new();
            defaultUser.UserName = "lio";
            defaultUser.Email = "elionormal@email.com";
            defaultUser.Name = "Elio";
            defaultUser.LastName = "Ese no e tu ubel";
            defaultUser.EmailConfirmed = true;
            defaultUser.PhoneNumberConfirmed = true;
            defaultUser.Cedula = "12345678913";
            defaultUser.IsActive = true;

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word!");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Client.ToString());
                }
            }
        }

    }
}
