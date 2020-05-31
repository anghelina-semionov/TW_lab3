using Musique.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musique.BusinessLogic.DBModel
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("name = Musique") // connectionstring name define in your web.config
        {
        }

        public virtual DbSet<UDbTable> UDbTables { get; set; }
        
    }
}
