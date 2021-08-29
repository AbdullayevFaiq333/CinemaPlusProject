using DataAccess.Concret;
using Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Identity
{
    public class DataInitializer
    {
        private readonly UserDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
    public DataInitializer (UserDbContext dbContext, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
    {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
    }
        public async Task SeedDataAsync()
        {
             await _dbContext.Database.MigrateAsync();

            var roles = new List<string>
             {
                 RoleConstants.AdminRole,
                 RoleConstants.ModeratorRole
             };
            foreach (var role in roles)
            {
                if (await _roleManager.RoleExistsAsync(role))
                    continue;

                await _roleManager.CreateAsync(new IdentityRole(role));          
            }
            var user = new User
            {
                Email = "admin@cinemaplus.az",
                UserName = "Admin",
                FullName = "Admin Admin",
                
            };
            if (await _userManager.FindByEmailAsync(user.Email) == null)
            {
                await _userManager.CreateAsync(user, "Admin@123");
                await _userManager.AddToRoleAsync(user, RoleConstants.AdminRole);

            }
            
        }
    }
}
