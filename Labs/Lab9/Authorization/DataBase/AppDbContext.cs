using Microsoft.EntityFrameworkCore;

namespace Authorization.DataBase
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<FullName> FullName { get; set; }
        public DbSet<Role> Roles { get; set; }
       
        public AppDbContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=./app.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, RoleName = "admin" },
                new Role { Id = 2, RoleName = "user" },
                new Role { Id = 3, RoleName = "manager" },
                new Role { Id = 4, RoleName = "master" }
            );
            modelBuilder.Entity<FullName>().HasData(
                new FullName { Id = 1, FirstName = "Alexey", LastName= "Kozlov" },
                new FullName { Id = 2, FirstName = "Sanchez", LastName= "Barashkin" }
                
            );
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Login = "user", Password = "user", Email = "kozlov@mail.ru", FullNameId = 1, RoleId = 2 },                
                new User { Id = 2, Login = "san", Password = "san", Email = "barashkin@mail.ru", FullNameId = 2, RoleId = 1 }                
            );
        }        
    }
}
