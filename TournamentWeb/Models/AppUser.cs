using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TournamentWeb.Models
{

    [Table("AspNetUsers")]
    public class AppUser : IdentityUser
    {
        public string UserDiscord { get; set; }
        public int Points { get; set; }
        [NotMapped]
        public IFormFile ProfileImageFile { get; set; }

        public string ProfileImage { get; set; }
    }
}