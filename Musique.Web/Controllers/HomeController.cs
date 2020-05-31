using Musique.Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;

namespace Musique.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Stream()
        {

            return View();
        }

        [Authorize]
        public ActionResult Library()
        {
            UserData u = new UserData();
            u.Username = "User";
            u.LibraryTracks = new List<Tracks>
            {
                new Tracks() { TrackTitle = "Into The Unknown", ArtistName = "Simon Chylinski", CoverImage = "/images/ost.jpg", FilePath = "/audio/Subnautica Soundtrack Into The Unknown.mp3" },
                new Tracks() { TrackTitle = "Colored Engine", ArtistName = "Joel Schoch", CoverImage = "/images/far-ost.jpg", FilePath = "/audio/joel-schoch-colored-edgine.mp3" }
            };

            return View(u);

        }
        public ActionResult DeleteTrack(string btn, UserData u)
        {
            var single = u.LibraryTracks.Find(id => id.TrackTitle == btn);
            u.LibraryTracks.Remove(single);
            return View("Library", u);
        }
        public ActionResult LikeTrack(Tracks track)
        {
            //u.FavouriteTracks.Add(
            //    new Tracks() { TrackTitle = "Colored Engine", ArtistName = "Joel Schoch", CoverImage = "/images/far-ost.jpg", FilePath = "/audio/joel-schoch-colored-edgine.mp3" }
            //
            //track);
            UserData u = new UserData();
            u.Username = "User";
            u.FavouriteTracks.Add(track);
            return View("Favourite", u);
        }

        //http://localhost:31843/Home/Product?p=JORA
        // [HttpPost]
        //public ActionResult Titre(string btn)
        //{
        //    return Json(new { RedirectUrl = Url.Action("Titre", new { p = btn }) });
        //}
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();

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
        public ActionResult Favourite()
        {
            UserData u = new UserData();
            u.Username = "User";
            u.FavouriteTracks = new List<Tracks>
            {
                new Tracks() { TrackTitle = "Into The Unknown", ArtistName = "Simon Chylinski", CoverImage = "/images/ost.jpg", FilePath = "/audio/Subnautica Soundtrack Into The Unknown.mp3" },
            };

            return View(u);
        }
        public ActionResult UnlikeTrack(Tracks track)
        {
            UserData u = new UserData();
            u.Username = "User";
            var single = u.LibraryTracks.Find(id => id == track);
            u.FavouriteTracks.Remove(single);
            return View("Favourite", u);
        }
        public ActionResult Following()
        {
            UserData u = new UserData();
            u.Username = "User";
            u.FollowArtist = new List<Artists>
            {
                new Artists() { ArtistName = "Simon Chylinski", ArtistId = 1, ArtistImage = "/images/Simon Chylinski.jpg"}
            };

            return View(u);
        }
        public ActionResult UnFollow(Artists artist)
        {
            UserData u = new UserData();
            u.Username = "User";
            var single = u.FollowArtist.Find(id => id == artist);
            u.FollowArtist.Remove(single);
            return View("Following", u);
        }
        public ActionResult _SideBar(string btn)
        {
            UserData u = new UserData();
            u.Username = "User";
            u.FollowArtist = new List<Artists>
            {
                new Artists() { ArtistName = "Simon Chylinski", ArtistId = 1, ArtistImage = "/images/Simon Chylinski.jpg"}
            };

            return View(u);
        }
        public ActionResult Parameters()
        {
            return View();
        }
    }
}