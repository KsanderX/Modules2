using Microsoft.EntityFrameworkCore;


namespace Var1.DataBase
{
    public class AppDbContext : DbContext
    {
        public DbSet<Request> Requests { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CarType> CarTypes { get; set; }    

        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=./app.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                  new Role { Id = 1, Type = "Admin" },
                  new Role { Id = 2, Type = "Client" },
                  new Role { Id = 3, Type = "Mechanic" }
                );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1, Name = "Alexander Borodach",
                    Login = "login", Password = "mechanic",
                    RoleId = 3
                },

                 new User
                 {
                     Id = 2, Name = "Petya Borodach",
                     Login = "login", Password = "admin",
                     RoleId = 2
                 }
                 );
            modelBuilder.Entity<CarType>().HasData(
                new CarType { Id = 1, Name = "Sedan" },
                new CarType { Id = 2, Name = "Coupe" },
                new CarType { Id = 3, Name = "Universal" }
                );
        }

    }
}
