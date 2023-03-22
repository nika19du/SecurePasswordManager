using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingSalting
{
    public class AppDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=AppHashSaltingDB;Trusted_Connection=SSPI;Encrypt=false;Integrated Security=True;");

        }

        public DbSet<User> Users { get; set; }
    }
}
