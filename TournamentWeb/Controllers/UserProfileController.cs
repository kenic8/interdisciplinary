using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using TournamentWeb.Data;
using TournamentWeb.Models;
using TournamentWeb.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace TournamentWeb.Controllers
{
    
    public class UserProfileController : Controller
    {

        private UserManager<AppUser> userManager;
        private readonly IWebHostEnvironment _webHostEnviroment;
        public UserProfileController(UserManager<AppUser> userMgr, IWebHostEnvironment webHostEnviroment)
        {
            userManager = userMgr;
            _webHostEnviroment = webHostEnviroment;
        }
        
        [Authorize]
        public async Task<IActionResult> Index()
        {
            AppUser user = await CurrentUser;

            UserProfileViewModel model = new UserProfileViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                //Password = user.PasswordHash,
                Points = user.Points,
                UserDiscord = user.UserDiscord,
                ProfileImage = user.ProfileImage,
                ProfileImageFile = user.ProfileImageFile
            };


            return View(model);
        }
        //Get
        //[Route("Edit")]
        public async Task<IActionResult> Edit()
        {
            AppUser user = await CurrentUser;
            UserProfileViewModel model = new UserProfileViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                //Password = user.PasswordHash,
                Points = user.Points,
                UserDiscord = user.UserDiscord,
                ProfileImage = user.ProfileImage,
                ProfileImageFile = user.ProfileImageFile
            };

            return View(model);
        }

        //Post
        [HttpPost]
        public async Task<IActionResult> Edit(UserProfileViewModel model)
        {
            AppUser user = await CurrentUser;

            if (ModelState.IsValid)
            {
                //Creating the IMG
                await ProcessUploadImgFile(model);

                if (user != null)
                {
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    //user.PasswordHash = model.Password;
                    user.UserDiscord = model.UserDiscord;
                    user.ProfileImage = model.ProfileImage;

                    IdentityResult result = await userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Register", "Account");
                }
            }
            return RedirectToAction("Index");
        }
        private async Task ProcessUploadImgFile(UserProfileViewModel model)
        {
            DateTime now = DateTime.Now;
            string time = now.ToString("dd MMMM yyyy hh:mm:ss tt");
            string Timetrimmed = String.Concat(time.Where(c => !Char.IsWhiteSpace(c))).Replace(":", "t");
            string folderProj = "/images/profile/";
            string UniqueName = Timetrimmed + model.ProfileImageFile.FileName.ToString();
            folderProj += UniqueName;
            string serverFolder = _webHostEnviroment.WebRootPath + folderProj;
            await model.ProfileImageFile.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            model.ProfileImage = UniqueName;
        }

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
