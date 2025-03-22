using System;
using Microsoft.EntityFrameworkCore;
using Var1_Demo.Models;

namespace Var1_Demo
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=library.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Sanya", Email = "sanya@mail.ru" },
                new User { Id = 2, Name = "Sonic", Email = "sonic@mail.ru" });

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Harry Potter", Genre = "Fantasy", Description = " lllala", UserId = 1}
                );
        }
    }
}
