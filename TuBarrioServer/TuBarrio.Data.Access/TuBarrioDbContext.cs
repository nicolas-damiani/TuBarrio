using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityClient;
using TuBarrio.Entities;

namespace TuBarrio.Data.Access
{
  public class TuBarrioDbContext : DbContext
    {
        public TuBarrioDbContext() : base("TuBarrioDataBase")
        { }

        public DbSet<User> Users { get; set; }
        }


    }
}
