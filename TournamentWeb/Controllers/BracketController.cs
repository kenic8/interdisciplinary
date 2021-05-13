using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TournamentWeb.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TournamentWeb.Models.ViewModels;
using System.Linq;
using System.Collections.Generic;

namespace TournamentWeb.Controllers
{
    public class BracketController : Controller
    {

        private readonly TournamentWebContext _context;


        public BracketController(TournamentWebContext context)
        {
            _context = context;
        }


        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> GetTournamentJson(int? id1)
        {
            var Tournament = await _context.Tournament.Include(i => i.Teams)
            .ThenInclude(i => i.Attendees)
            .FirstOrDefaultAsync(i => i.TournamentId == id1);
            return Json(Tournament);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateTeams(int? id1, string jsonstring)
        {

            JObject rss = JObject.Parse(jsonstring);
            IList<string> keys = rss.Properties().Select(p => p.Name).ToList();
            int[] keysToInt = keys.Select(int.Parse).ToArray();

            var TTournament = await _context.Tournament.Include(i => i.Teams)
            .ThenInclude(i => i.Attendees)
            .FirstOrDefaultAsync(i => i.TournamentId == id1);

            var Tteams = (from s in TTournament.Teams where keysToInt.Contains(s.TeamId) select s).ToList();


            for (int i = 0; i < Tteams.Count; i++)
            {
                if (rss["" + Tteams[i].TeamId + ""]["Out"] != null)
                {
                    bool value = rss["" + Tteams[i].TeamId + ""]["Out"].ToObject<bool>();
                    Tteams[i].LostGame = value;
                }
                if (rss["" + Tteams[i].TeamId + ""]["Matchwins"] != null)
                {
                    int value = rss["" + Tteams[i].TeamId + ""]["Matchwins"].ToObject<int>();
                    Tteams[i].MatchWins += value;
                }
            }

            _context.SaveChanges();

            return Json("http://" + "localhost:44881/Bracket/Index/" + id1 + "?wmode=transparent");
        }

    }
}
