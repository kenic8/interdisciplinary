using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TournamentWeb.Data;
using TournamentWeb.Models;

namespace TournamentWeb.Components
{
    public class UserTournamentsViewComponent : ViewComponent
    {
        private  TournamentWebContext _context;
        private string h;

        public UserTournamentsViewComponent( TournamentWebContext context)
        {
            _context = context;  
        }

        public string f { get; private set; }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userId = claim.Value;



            //owned tournaments query
            var queryT = _context.Tournament.Include(b => b.Teams).ThenInclude(u => u.Attendees).Where(u => u.UserId == userId).ToList();
            ///



            //joined
            ////get all tournaments --> Teams --> attendees( id current-user) 
            var o = _context.Tournament.Include(u => u.Teams).ThenInclude(f => f.Attendees).Where(p => p.Teams.Any(i => i.Attendees.Any(s => s.UserID == userId))).ToList();
            
         




            ViewBag.joinedTournaments = o;
            ViewBag.CreatedTournaments = queryT;

            return View(ViewBag);
        }
    }
}



