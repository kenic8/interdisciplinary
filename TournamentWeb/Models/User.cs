using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentWeb.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int Points { get; set; }
        public string Discord { get; set; }
        public User(int userId, string userName, string userPassword, int points, string discord)
        {
            UserId = userId;
            UserName = userName;
            UserPassword = userPassword;
            Points = points;
            Discord = discord;
        }
      
    }
}
