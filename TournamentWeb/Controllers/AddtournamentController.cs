using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TournamentWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using TournamentWeb.Data;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using System.Linq;

namespace TournamentWeb.Controllers
{
    public class AddtournamentController : Controller
    {


        private readonly TournamentWebContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public AddtournamentController(TournamentWebContext context,IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }

        [Authorize]
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
                if (objT.TournamentImageFile != null)
                {
                    DateTime now = DateTime.Now;
                    string time = now.ToString("dd MMMM yyyy hh:mm:ss tt");
                    string Timetrimmed = String.Concat(time.Where(c => !Char.IsWhiteSpace(c))).Replace(":","t");
                    string folderProj = "/images/tournaments/";
                    string UniqueName = Timetrimmed + objT.TournamentImageFile.FileName.ToString();
                    folderProj += UniqueName;
                    string serverFolder = _webHostEnviroment.WebRootPath+ folderProj;
                    objT.TournamentImageFile.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

                    objT.TournamentImage = UniqueName;

                    objT.Teams = new System.Collections.Generic.List<Teams>();
                    _context.Add(objT);
                    _context.SaveChanges();
                    return RedirectToAction("Addtournament");
                }
              
                objT.Teams = new System.Collections.Generic.List<Teams>();
                _context.Add(objT);
                _context.SaveChanges();
                return RedirectToAction("Addtournament");
            }
            
            return View();
        }
    }
}


