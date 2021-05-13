using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using TournamentWeb.Models;
using TournamentWeb.Data;

namespace TournamentWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TournamentWebContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));


            services.AddIdentity<AppUser, IdentityRole>(opts => {
                opts.User.RequireUniqueEmail = true;
                //opts.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz";
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<TournamentWebContext>()
            .AddDefaultTokenProviders();

            //services.ConfigureApplicationCookie(opts => opts.LoginPath = "/Users/Login");

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Tournaments",
                    pattern: "Tournaments",
                    defaults: new { Controller = "Tournaments", Action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Profile",
                    pattern: "Profile",
                    defaults: new { Controller = "UserProfile", Action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Profile",
                    pattern: "Profile/{action}",
                    defaults: new { Controller = "UserProfile" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Landing}/{action=Landingpage}/{id?}");
            });

        }
    }
}
