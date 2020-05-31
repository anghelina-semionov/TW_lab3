using Musique.Domain.Entities.User;
using System;
using System.Data.Entity;

namespace Musique.BusinessLogic.Core
{
    public class UserContext :  DbContext
    {
        public UserContext() :
            base("name=Musique") // connectionstring name define in your web.config
        {
        }

        public virtual DbSet<UDbTable> UDbTables { get; set; }
        
    }
}