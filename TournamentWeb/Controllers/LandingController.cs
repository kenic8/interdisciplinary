using TournamentWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TournamentWeb.Controllers
{
    public class LandingController : Controller
    {

        public IActionResult Landingpage()
        {
          
            return View();
        }

    }
}
