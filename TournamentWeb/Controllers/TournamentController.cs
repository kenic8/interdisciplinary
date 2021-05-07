﻿using TournamentWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;


namespace TournamentWeb.Controllers
{
    public class TournamentController : Controller
    {
        ///get Current user from the context
        private Task<AppUser> CurrentUser =>
         userManager.FindByNameAsync(HttpContext.User.Identity.Name);

        private UserManager<AppUser> userManager;
        public TournamentController(UserManager<AppUser> userMgr)
        {
            userManager = userMgr;
        }
     
        ///check if user is logged in to create a tournament
        [Authorize]
        public async Task<IActionResult> UserCheck()
        {
            if (ModelState.IsValid)
            {
                AppUser user = await CurrentUser;

                await userManager.UpdateAsync(user);
                return View("AddTournament");
            }
            //return RedirectToAction("Accoount", "Login");
            return RedirectToAction("Landing", "Landingpage");

        }

       

    }
}
