using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var1.DataBase
{
    class AppDbContext : DbContext
    {
        public DbSet<Request> Requests { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> Users { get; set; }

        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=./app.db");
        }

    }
}
