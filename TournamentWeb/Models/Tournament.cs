using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace TournamentWeb.Models
{
    public class Tournament
    {
        [Required]
        public int TournamentId { get; set; }
        [Required]
        public string TournamentName { get; set; }
        [Required]
        public string TournamentImage { get; set; }
        [Required]
        public string TournamentInfo { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public DateTime TimeFrame { get; set; }
        public int ParticipantsAmount { get; set; }
        public string UserId { get; set; }
        [Required]
        public int Bracketsize { get; set; }
        public ICollection<Teams> Teams { get; set; } = new List<Teams>();
        public Tournament()
        {
        }
    }
}

