using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.PocoData
{
    public class TmsContext:DbContext
    {
        public TmsContext(DbContextOptions<TmsContext> options)
                :base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}
