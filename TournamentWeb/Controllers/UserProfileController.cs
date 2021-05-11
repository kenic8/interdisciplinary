using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TournamentWeb.Data;
using TournamentWeb.Models;
using TournamentWeb.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace TournamentWeb.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly TournamentWebContext _context;
        private UserManager<AppUser> userManager;
        public UserProfileController(UserManager<AppUser> userMgr, TournamentWebContext context)
        {
            userManager = userMgr;
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            AppUser user = await CurrentUser;
            return View(user);
        }
        //Get
        public async Task<IActionResult> Edit()
        {
            AppUser user = await CurrentUser;
            if (user != null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        //Post
        [HttpPost]
        public async Task<IActionResult> Edit(AppUser model)
        {
            AppUser user = await CurrentUser;

            if (user != null)
            {
                user.UserName = model.UserName;
                user.Email = model.Email;
                user.Points = model.Points;
                user.UserDiscord = model.UserDiscord;
                //user.ProfileImage = model.ProfileImage;

                IdentityResult result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        //public void SaveUser(AppUser user)
        //{
        //    var userfound = _context.AppUsers.FindAsync(user.Id);
        //    USe
        //} 

        private Task<AppUser> CurrentUser =>
            userManager.FindByNameAsync(HttpContext.User.Identity.Name);
        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}
