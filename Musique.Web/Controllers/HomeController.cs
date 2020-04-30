using Musique.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Musique.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Stream()
        {
            return View();
        }

        public ActionResult Library()
        {
            UserData u = new UserData();
            u.Username = "Utilisateur";
            u.Tracks = new List<string> { "Track #1", "Track #2" };

            return View(u);
            //return View();
        }
        public ActionResult Titre()
        {
            var track = Request.QueryString["p"];

            UserData u = new UserData();
            u.Username = "Utilisateur";
            u.SingleTrack = track;

            return View(u);
        }


        //http://localhost:31843/Home/Product?p=JORA
        [HttpPost]
        //public ActionResult Titre(string btn)
        //{
        //    return Json(new { RedirectUrl = Url.Action("Titre", new { p = btn }) });
        //}
        public ActionResult Titre(string btn)
        {
            return RedirectToAction("Titre", "Home", new { @p = btn });
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Recoverpw()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public new ActionResult Profile()
        {
            return View();
        }
        public ActionResult Favourite()
        {
            return View();
        }
        public ActionResult Following()
        {
            return View();
        }
        public ActionResult Parameters()
        {
            return View();
        }
    }
}