//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Musique.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class UDbTable
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public System.DateTime LastLogin { get; set; }
        public string LasIP { get; set; }
        public bool AdminLevel { get; set; }
    
        public virtual ArtistDbTable ArtistDbTable { get; set; }
        public virtual MusicDbTable MusicDbTable { get; set; }
    }
}
