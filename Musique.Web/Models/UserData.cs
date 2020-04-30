using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musique.Web.Models
{
    public class UserData
    {
        public string Username { get; set; }
        public List<string> Tracks { get; set; }
        public string SingleTrack { get; set; }
    }
}