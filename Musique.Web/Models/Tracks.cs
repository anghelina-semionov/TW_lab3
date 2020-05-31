using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musique.Web.Models
{
    public class Tracks
    {
        public string TrackTitle { get; set; }
        public string ArtistName { get; set; }
        public string CoverImage { get; set; }
        public string FilePath { get; set; }
    }
}