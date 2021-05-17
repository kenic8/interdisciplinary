using TournamentWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TournamentWeb.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace TournamentWeb.Controllers
{
    public class LandingController : Controller
    {
        public Tournament Tournament;
        public List<int> Attendeecount { get; } = new List<int>();

        private TournamentWebContext _context;

        public LandingController(TournamentWebContext context)
        {
            _context = context;

        }

        public IActionResult Landingpage()
        {
            // tournaments first 8 sorted by date


            if (User.Identity.IsAuthenticated)
            {
                var queryT = _context.Tournament.Include(b => b.Teams).ThenInclude(u => u.Attendees).Take(8).OrderByDescending(c => c.TimeFrame.Date).ThenBy(c => c.TimeFrame.TimeOfDay).ToList();

                foreach (var T in queryT)
                {
                    foreach (var att in T.Teams)
                    {

                        T.ParticipantsAmount += att.Attendees.Count;
                       
                    }
                }
                // tournaments first 20 of all

                var queryF = _context.Tournament.Include(b => b.Teams).ThenInclude(u => u.Attendees).Take(20).ToList();

                foreach (var P in queryF)
                {
                    P.ParticipantsAmount = 0;
                    foreach (var fatt in P.Teams)
                    {
                        

                        P.ParticipantsAmount += fatt.Attendees.Count;

                    }
                }



                ViewBag.NewT = queryT;
                ViewBag.NewF = queryF;




                return View("LoggedInLanding", ViewBag);
            }
            else
            {
                return View();
            }
        }

    }
}
