using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab11.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public AppDbContext()
        {
            Database.EnsureDeleted();   
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Login = "admin", Password = "admin", Name = "Admin", RegistrationDate = DateTime.Now, PhoneNumber = "1234567890" },
                new User { Id = 2, Login = "user", Password = "user", Name = "User", RegistrationDate = DateTime.Now, PhoneNumber = "0987654321" }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "Book1", Genre = "Genre1", Description = "Description1", BookReleaseDate = DateTime.Now, UserId = 1, StatusId = 2 },
                new Book { Id = 2, Name = "Book2", Genre = "Genre2", Description = "Description2", BookReleaseDate = DateTime.Now, UserId = 1, StatusId = 3 }
            );
            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, Name = "В наличии" },
                new Status { Id = 2, Name = "Выдана" },
                new Status { Id = 3, Name = "На обслуживании" }
            );
        }
    }
}
