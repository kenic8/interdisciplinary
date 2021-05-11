using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace TournamentWeb.Models
{
    public class CreateModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        
        [Required]
        public string UserDiscord { get; set; }

        public int Points { get; set; }


        [NotMapped]
        public IFormFile ProfileImageFile { get; set; }

        public string ProfileImage { get; set; }

    }

    public class LoginModel
    {
        [Required]
        [UIHint("email")]
        public string Email { get; set; }
        [Required]
        [UIHint("password")]
        public string Password { get; set; }
    }

}
