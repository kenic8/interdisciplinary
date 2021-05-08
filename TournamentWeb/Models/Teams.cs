using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentWeb.Models
{
    public class Teams
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public ICollection<Attendees> Attendees { get; set; } = new List<Attendees>();
        public int MatchWins { get; set; }
        public bool LostGame { get; set; }



        //public void AddStatus( Attendees user, string status) // to users
        //{
        //    Attendees userFound = Attendees.FirstOrDefault(u => u.UserId == user.UserId);
        //    userFound.UserStatus = status;

        //}
        public Teams()
        {

        }

        public Teams(string TeamName, List<Attendees> Attendees,
            int MatchWins, bool LostGame)
        {
            this.TeamName = TeamName;
            this.Attendees = Attendees;
            this.MatchWins = MatchWins;
            this.LostGame = LostGame;
        }
    }
}
