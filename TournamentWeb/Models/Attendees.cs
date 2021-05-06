using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentWeb.Models
{
    public class Attendees
    {
        public int ID { get; set; }
        public string UserStatus { get; set; }


        // Get from user class later
        public string UserName { get; set; }

        public Attendees()
        {

        }

        public Attendees(string UserStatus, string UserName)
        {
            this.UserStatus = UserStatus;
            this.UserName = UserName;
        }

        //public AppUser User = new AppUser();
    }
}
