using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TournamentWeb.Models
{
    public class Bracket
    {
        public int BracketId { get; set; }
        public int BracketSize { get; set; }
        public List<Match> MatchList { get; } = new List<Match>();
        public List<Attendees> ParticipationList { get; } = new List<Attendees>();

        public void AddAttendees(Attendees attendees)
        {
            ParticipationList.Add(attendees);
        }

        //public void AddMatches(Match match)
        //{
        //    MatchList.Add(match);
        //}

    }
}
