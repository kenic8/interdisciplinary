using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TournamentWeb.Models;

namespace TournamentWeb.Data
{

    public class TournamentWebContext : IdentityDbContext<AppUser>
    {
        public TournamentWebContext(DbContextOptions<TournamentWebContext> options) : base(options) { }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Tournament> Tournament { get; set; }

        public DbSet<Attendees> Attendees { get; set; }

        public DbSet<Teams> Teams { get; set; }


        public static async Task CreateAdminAccount(IServiceProvider serviceProvider, IConfiguration configuration)
        {

            ///dependency injection 
            UserManager<AppUser> userManager =
            serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> roleManager =
            serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();


            ///// settings for admin -  see config in startup cs
            string username = configuration["Data:AdminUser:Name"];
            string email = configuration["Data:AdminUser:Email"];
            string password = configuration["Data:AdminUser:Password"];
            string role = configuration["Data:AdminUser:Role"];


            ///  Functionalities from Depencies
            if (await userManager.FindByNameAsync(username) == null)
            {
                if (await roleManager.FindByNameAsync(role) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
                AppUser user = new AppUser
                {
                    UserName = username,
                    Email = email

                };
                IdentityResult result = await userManager.CreateAsync(user, password)
                    .ConfigureAwait(false);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }

    }
}
