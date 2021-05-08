using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentWeb.Models;
using TournamentWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace TournamentWeb.Controllers
{
    public class TournamentsController : Controller
    {
        private readonly TournamentWebContext _context;

        private UserManager<AppUser> userManager;

        public TournamentsController(TournamentWebContext context, UserManager<AppUser> userMgr)
        {
            _context = context;
            userManager = userMgr;
        }


        //public async Task<IActionResult> Leave(int? id, int? TeamId)
        //{

        //}




        // GET: Movies/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var movie = await _context.Movie
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(movie);
        //}

        // POST: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id, int? TeamId)
        {
            if (id == null)
            {
                return NotFound();
            }
            var TTournament = await _context.Tournament.Include(u => u.Teams)
                .ThenInclude(u => u.Attendees)
                .FirstOrDefaultAsync(u => u.TournamentId == id.Value);



            //var Tteams = TTournament.Teams.FirstOrDefault(u => u.TeamId == TeamId.Value);


            var TTeam = TTournament.Teams.FirstOrDefault(u => u.TeamId == TeamId.Value);


            if (TTeam == null)
            {
                return NotFound();
            }
 

            TTournament.Teams.Remove(TTeam);


            // Dosnt delete in database only "unlinks" / fix with query string delete where id = NULL or something
            _context.SaveChanges();
            return RedirectToAction("Details", new { id = id });
        }


        [Authorize]
        public async Task<IActionResult> Join(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }


            AppUser user = await CurrentUser;
            var Attendee = new Attendees(
                "TeamLeader",
                 user.UserName,
                 user.Id
            );
            List<Attendees> AttendeesList = new List<Attendees>();
            AttendeesList.Add(Attendee);

            Teams Team = new Teams(
                "placeholderTeamName",
                AttendeesList,
                0,
                false
            );

            List<Teams> TeamList = new List<Teams>();
            TeamList.Add(Team);

            var TournamentToUpdate = await _context.Tournament.FirstOrDefaultAsync(i => i.TournamentId == id.Value);


            TournamentToUpdate.Teams = TeamList;
            _context.SaveChanges();

            return RedirectToAction("Details", new { id = id });
        }




        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Tournament = await _context.Tournament.Include(i => i.Teams)
                .ThenInclude(u => u.Attendees)
                .FirstOrDefaultAsync(i => i.TournamentId == id.Value)
                ;
            if (Tournament == null)
            {
                return NotFound();
            }
            return View(Tournament);
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var Tournaments = from m in _context.Tournament
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                Tournaments = Tournaments.Where(s => s.TournamentName.Contains(searchString));
            }

            return View(await Tournaments.ToListAsync());
        }

        private Task<AppUser> CurrentUser =>
        userManager.FindByNameAsync(HttpContext.User.Identity.Name);
    }
}
