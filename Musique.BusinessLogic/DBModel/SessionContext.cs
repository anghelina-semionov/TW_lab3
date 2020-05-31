using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musique.Domain.Entities.User;

namespace Musique.BusinessLogic.DBModel
{
    class SessionContext : DbContext
    {
        public SessionContext() : base("name=AudioLibrary")
        {
        }

        public virtual DbSet<Session> Sessions { get; set; }
    }
}
