using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentWeb.Models
{
    public enum QualificationLevels
    {
        None, Basic, Advanced
    }
    [Table("AspNetUsers")]
    public class AppUser : IdentityUser
    {

        public QualificationLevels Qualifications { get; set; }
        public string UserDiscord { get; set; }
        public int Points { get; set; }

    }
}
