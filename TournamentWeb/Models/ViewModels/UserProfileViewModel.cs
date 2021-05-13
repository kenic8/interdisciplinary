using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace TournamentWeb.Models.ViewModels
{
    public class UserProfileViewModel
    {
        public string Id { get; set; }
        [MaxLength(50, ErrorMessage = "UserName cannot exceed 50 characters")]
        public string UserName { get; set; }
        public string Email { get; set; }
        //public string Password { get; set; }
        public int Points { get; set; }
        public string UserDiscord { get; set; }
        [NotMapped]
        public IFormFile ProfileImageFile { get; set; }

        public string ProfileImage { get; set; }

        public string ReturnUrl { get; set; }

    }
}