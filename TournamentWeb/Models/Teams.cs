using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string TeamImage { get; set; }
        [NotMapped]
        public IFormFile TeamImageFile { get; set; }

        public Teams()
        {

        }

        public Teams(string TeamName, List<Attendees> Attendees,
            int MatchWins, bool LostGame, string TeamImage, IFormFile TeamImageFile)
        {
            this.TeamName = TeamName;
            this.Attendees = Attendees;
            this.MatchWins = MatchWins;
            this.LostGame = LostGame;
            this.TeamImage = TeamImage;
            this.TeamImageFile = TeamImageFile;
        }
    }
}
