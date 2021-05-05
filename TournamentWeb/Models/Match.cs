using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentWeb.Models
{
    public class Match
    {
        public int MatchId { get; set; }
        public List<Teams> Attendees { get; set; }
        public DateTime TimeFrame { get; set; }
       

        public void AddResultManual(string teamId, bool win)
        {
            var team = Attendees.FirstOrDefault(t => t.TeamId == teamId);
            if (win)
            {
                team.MatchWins += 1;
            }
            else
            {
                team.LostGame = true;
            }
        }
    }
}
