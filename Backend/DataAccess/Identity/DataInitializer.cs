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
        private readonly AppDbContext _dbContext;
        private readonly UserManager<User> _userManager;
    public DataInitializer (AppDbContext dbContext, UserManager<User> userManager)
    {
            _dbContext = dbContext;
            _userManager = userManager;
    }
        public void SeedData()
        {
              _dbContext.Database.Migrate();

            var roles = new List<string>
             {
                 RoleConstants.AdminRole,
                 RoleConstants.ModeratorRole
             };
            foreach (var role in roles)
            {
                if (_dbContext.Roles.Any(x => x.Name.ToLower() == role.ToLower()))
                    continue;

                _dbContext.Roles.Add(new IdentityRole(role));
                _dbContext.SaveChanges();
            }
            var user = new User
            {
                Email = "admin@cinemaplus.az",
                UserName = "Admin",
                FullName = "Admin Admin",
                

            };
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, "Admin@123");
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }
    }
}
