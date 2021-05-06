using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace TournamentWeb.Models
{
    public class Tournament
    {
        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime TimeFrame { get; set; }
        public User Creator { get; set; }

        public Bracket Bracket { get; set; }

        public string Info { get; set; }

        public Tournament()
        {
        }

        public Tournament(int tournamentId, string tournamentName, DateTime starTime,
            DateTime timeFrame, User creator, int size)
        {
            TournamentId = tournamentId;
            TournamentName = tournamentName;
            CreationDate = DateTime.Now;
            TimeFrame = timeFrame;
            //Creator = creator;

        }
    }
}

