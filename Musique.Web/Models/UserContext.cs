using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Musique.Web.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
           base("name = Musique") // connectionstring name define in your web.config
        {
        }

        public virtual DbSet<UserRegister> Users { get; set; }
    }
}