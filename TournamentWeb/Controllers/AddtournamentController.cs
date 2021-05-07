using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TournamentWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using TournamentWeb.Data;

namespace TournamentWeb.Controllers
{
    public class AddtournamentController : Controller
    {

        private readonly TournamentWebContext _context;

        public AddtournamentController(TournamentWebContext context)
        {

            _context = context;
          
        }

        //private Task<AppUser> CurrentUser =>
        //userManager.FindByNameAsync(HttpContext.User.Identity.Name);


        //private UserManager<AppUser> userManager;
        //public AddtournamentController(UserManager<AppUser> userMgr)
        //{
        //    userManager = userMgr;
        //}


        public IActionResult AddTournament()
        {
            Tournament objT = new Tournament();

            return View(objT);
        }


        [HttpPost]
        public IActionResult AddTournament(Tournament objT)
        {
            if (ModelState.IsValid)
            {
                objT.Teams = new System.Collections.Generic.List<Teams>();
                _context.Add(objT);
                _context.SaveChanges();
                return RedirectToAction("Addtournament");
            }
            
            return View();
        }
    }
}


