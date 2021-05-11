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
using TournamentWeb.Data;
using Microsoft.EntityFrameworkCore;


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


        //UserManager<AppUser> UserManager;
        //private readonly TournamentWebContext _context;
        //public HomeController(TournamentWebContext context)
        //{
        //    _context = context;
        //}

        ////private UserManager<AppUser> userManager;
        ////public HomeController(UserManager<AppUser> userMgr)
        ////{
        ////    userManager = userMgr;
        ////}

        //[Authorize]
        //public async Task<IActionResult> Index()
        //{

        //    //var user = _context.Users.SingleOrDefault(u => u.UserName == User.Identity.Name)
        //    //    ;
        //    //if (user == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    //return View(user);





        //    AppUser user = await CurrentUser;
        //    return View(user);
        //}



        //private Task<AppUser> CurrentUser =>
        //    UserManager.FindByNameAsync(HttpContext.User.Identity.Name);
    }
}

