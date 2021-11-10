using Hidromil.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hidromil.Models
{
    public enum Role
    {
        Admin,
        User
    }
    public class Inicijalizacija
    {
        public static async Task Initialize(ApplicationDBContext context, UserManager<Admin> userManager, RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();
            string AdminId = "";
            string password = "Admin!123";
            if (await roleManager.FindByNameAsync(Role.Admin.ToString()) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Role.Admin.ToString()));
            }
            if (await roleManager.FindByNameAsync(Role.User.ToString()) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Role.User.ToString()));
            }
            if (await userManager.FindByNameAsync("Admin123") == null)
            {
                var user = new Admin
                {
                    Name = "Sasa",
                    Lastname = "Milojkovic",
                    Email = "Admin123@hirdromil.rs"

                };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {

                    await userManager.AddToRoleAsync(user, Role.Admin.ToString());
                }
                await context.SaveChangesAsync();
                AdminId = user.Id;
            }
        }

    }
}
