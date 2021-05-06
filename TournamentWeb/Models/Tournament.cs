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
        public string TournamentImage { get; set; }
        public string TournamentInfo { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime TimeFrame { get; set; }
        public int ParticipantsAmount { get; set; }
        public string UserId { get; set; }
        public int Bracketsize { get; set; }

        public ICollection<Teams> Teams { get; set; } = new List<Teams>();

        public Tournament()
        {
        }



    }
}

