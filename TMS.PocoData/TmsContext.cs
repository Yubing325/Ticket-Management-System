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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                    new Role { RoleId = 1, Description = "Quality Assurance", RoleCode = "TMS-QA", IsClient = false, IsManagement = false },
                    new Role { RoleId = 2, Description = "Manager", RoleCode = "TMS-MA", IsClient = false, IsManagement = true },
                    new Role { RoleId = 3, Description = "Developer", RoleCode = "TMS-DEV", IsClient = false, IsManagement = false },
                    new Role { RoleId = 4, Description = "Customer Service", RoleCode = "TMS-SERVICE", IsClient = false, IsManagement = false },
                    new Role { RoleId = 5, Description = "Client", RoleCode = "TMS-CLIENT", IsClient = true, IsManagement = false },
                    new Role { RoleId = 6, Description = "Adminstrator", RoleCode = "TMS-ADMIN", IsClient = false, IsManagement = true }
                ) ;
        }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}
