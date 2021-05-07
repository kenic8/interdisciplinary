using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using TournamentWeb.Models;

namespace TournamentWeb.Controllers
{
    public class HomeController : Controller
    {
        

        private UserManager<AppUser> userManager;
        public HomeController(UserManager<AppUser> userMgr)
        {
            userManager = userMgr;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            AppUser user = await CurrentUser;
            return View(user);
        }



        private Task<AppUser> CurrentUser =>
            userManager.FindByNameAsync(HttpContext.User.Identity.Name);
    }
}

