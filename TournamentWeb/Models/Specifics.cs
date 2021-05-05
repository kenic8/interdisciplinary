using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;


namespace TournamentWeb.Models
{
    public class Specifics : Tournament
    {
        public string TournamentImg { get; set; }
        public int TournamentSize { get; set; } = 0;
        public int CurrentAttendees { get; set; } = 0;
        public List<User> ParticipantList { get; } = new List<User>();
        public string Category { get; set; }
        public void AddImage(string img)
        {
            TournamentImg = img;
        }

        public void AddCurrentAttendees(User user )
        {
            ParticipantList.Add(user);
            CurrentAttendees += 1;
        }
    }
}
