using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentWeb.Models.ViewModels;

namespace TournamentWeb.Controllers
{
    public class PopupController : Controller
    {
        [HttpPost]
        public ActionResult InitPopUp(int id1, int id2, int id3, string PopupView)
        {
            TempData["id1"] = id1;
            TempData["id2"] = id2;
            TempData["id3"] = id3;

            if (PopupView.Contains("Error")) {
                TempData["PopupView"] = "Error";
                TempData["ErrorMsg"] = "Error";
            } else
            {
                TempData["PopupView"] = PopupView;
            }
            return PartialView("PopUp");
        }

        //add return action intead of frontend
    }
}
