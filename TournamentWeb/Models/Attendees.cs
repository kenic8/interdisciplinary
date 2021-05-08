using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentWeb.Models
{
    public class Attendees
    {
        [Key]
        public int AttendeeID { get; set; }
        public string UserName { get; set; }
        public string UserStatus { get; set; }
        public string UserID { get; set; }


        public Attendees(string UserStatus, string UserName, string UserID)
        {
            this.UserStatus = UserStatus;
            this.UserName = UserName;
            this.UserID = UserID;
        }
    }
}
