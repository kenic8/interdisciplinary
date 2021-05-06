using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentWeb.Models
{
    public class Attendees : User
    {
        public string UserStatus { get; set; }

        public Attendees(int userId, string userName, string userPassword, int points, string discord, string userStatus) 
            : base(userId, userName,userPassword, points, discord)
        {
            UserStatus = userStatus;
        }
    }
}
