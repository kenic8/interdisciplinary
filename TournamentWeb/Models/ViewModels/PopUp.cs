using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentWeb.Models.ViewModels
{
    public class PopUp
    {
        public int id1 { get; set; }
        public int id2 { get; set; }
        public int id3 { get; set; }
        public string PopupView { get; set; }

        public PopUp(int id1, int id2, int id3, string PopupView)
        {
            this.id1 = id1;
            this.id2 = id2;
            this.id3 = id3;
            this.PopupView = PopupView;
        }
    }
}
