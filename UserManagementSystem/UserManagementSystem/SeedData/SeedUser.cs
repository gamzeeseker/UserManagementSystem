using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.DataAccess.Context;
using UserManagementSystem.Domain.Entities;

namespace UserManagementSystem.WebUI.SeedData
{
    public class SeedUser
    {
        private readonly UserManager<UserEntity> userManager;
        private readonly AppDbContext appDbContext;

        public SeedUser(UserManager<UserEntity> userManager,
            AppDbContext appDbContext)
        {
            this.userManager = userManager;
            this.appDbContext = appDbContext;
        }
        public async Task AddDefaultDataAsync()
        {
            var rol = appDbContext.Roles.Where(c => c.Name == "ADMIN").FirstOrDefault();
            //var rol = await roleManager.FindByNameAsync("admin");
            if (rol == null)
            {
                var newRol = new RoleEntity()
                {
                    Name = "ADMIN",
                    Id = "1",
                    NormalizedName = "ADMIN"
                };
                appDbContext.Roles.Add(newRol);
                appDbContext.SaveChanges();

            }

            var adminUser = await userManager.FindByNameAsync("admin");
            if (adminUser == null)
            {
                var user = new UserEntity()
                {
                    UserName = "admin",
                    FirstName = "admin",
                    LastName = "admin",
                    Email = "admin@admin.com",
                    Birthday = DateTime.Now,
                    Id = Guid.NewGuid().ToString(),
                    PhoneNumber = "0555555555",
                };

                var password = userManager.PasswordHasher.HashPassword(user, "admin");
                user.PasswordHash = password;
                await userManager.CreateAsync(user);

                await userManager.AddToRoleAsync(user, "ADMIN");
            }

        }
    }
}
