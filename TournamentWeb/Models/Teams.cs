using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentWeb.Models
{
    public class Teams
    {
        public string TeamId { get; set; }
        public string TeamName { get; set; }
        public List<Attendees> Attendees { get; set; }
        public string MatchPattern { get; set; }
        public int MatchWins { get; set; }
        public bool LostGame { get; set; }

        public void AddMatchPattern(string matchPattern)
        {
            MatchPattern += matchPattern;
        }

        public void AddStatus( Attendees user, string status) // to users
        {
            Attendees userFound = Attendees.FirstOrDefault(u => u.UserId == user.UserId);
            userFound.UserStatus = status;

        }
    }
}
