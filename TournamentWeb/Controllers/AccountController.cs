using TournamentWeb.Models;
using TournamentWeb.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Net;
using System.Security.Claims;

namespace TournamentWeb.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnviroment;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IWebHostEnvironment webHostEnviroment)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            _webHostEnviroment = webHostEnviroment;
        }

        public UserManager<AppUser> UserManager { get; private set; }
        public SignInManager<AppUser> SignInManager { get; private set; }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    await SignInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result =
                        await SignInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToLocal(returnUrl);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }
            return View(model);
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {

                if (model.ProfileImageFile != null)
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



                var user = new AppUser() { 
                    UserName = model.UserName,
                    Email = model.Email,
                    UserDiscord = model.UserDiscord,
                    Points = model.Points,
                    ProfileImage = model.ProfileImage
                };

                var result = await UserManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await SignInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult Loginresult =
                        await SignInManager.PasswordSignInAsync(user, model.Password, false, false);
                    return RedirectToAction("Landingpage", "Landing");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }


        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {

            }
        }



        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Landingpage", "Landing");
            }
        }


        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("Landingpage", "Landing");
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}