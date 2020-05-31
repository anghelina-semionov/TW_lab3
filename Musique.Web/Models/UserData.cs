using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musique.Web.Models
{
    public class UserData
    {
        public string Username { get; set; }
        public List<Tracks> LibraryTracks { get; set; }
        public List<Tracks> FavouriteTracks { get; set; }
        public List<Artists> FollowArtist { get; set; }
    }
}