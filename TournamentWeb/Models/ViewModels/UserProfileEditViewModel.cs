using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TournamentWeb.Models.ViewModels
{
    public class UserProfileEditViewModel
    {
        public string Id { get; set; }
        [MaxLength(50, ErrorMessage = "UserName cannot exceed 50 characters")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Points { get; set; }
        public string UserDiscord { get; set; }
        public string ProfileImage { get; internal set; }

        public string ReturnUrl { get; set; }

    }
}
