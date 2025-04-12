using Microsoft.EntityFrameworkCore;


namespace Var1.DataBase
{
    public class AppDbContext : DbContext
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Request>().HasData(
                new Request
                {
                    ID = 1,
                    Number = "12314",
                    DateAdd = DateTime.Now,
                    TypeCar = "Cedan ",
                    ModelCar = "Toyota",
                    ProblemDescription = "Побитое крыло",
                    PhoneNumber = 894231345
                });
            modelBuilder.Entity<Role>().HasData(
                  new Role { Id = 1, Type = "Admin" },
                  new Role { Id = 2, Type = "Client" },
                  new Role { Id = 3, Type = "Mechanic" }
                );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Alexander Borodach",
                    Login = "login",
                    Password = "admin",
                    RoleId = 1
                },

                 new User
                 {
                     Id = 2,
                     Name = "Petya Borodach",
                     Login = "login",
                     Password = "admin",
                     RoleId = 2
                 }
                 );        
        }

    }
}
