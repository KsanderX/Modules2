using Microsoft.EntityFrameworkCore;

namespace Navigation.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Material> Materials { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>().HasData
            (
                new Material { Id = 1, Name = "Дерево" },
                new Material { Id = 2, Name = "Металл" },
                new Material { Id = 3, Name = "Пластик" }
            );
            modelBuilder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = 1,
                    Name = "Стул",
                    Description = "Деревянный стул с мягким сиденьем",
                    DateOfCreation = new DateTime(2025, 1, 15),
                    MaterialId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Стол",
                    Description = "Обеденный стол на 6 персон",
                    DateOfCreation = new DateTime(2024, 11, 10),
                    MaterialId = 2
                },
                new Product
                {
                    Id = 3,
                    Name = "Кресло",
                    Description = "Удобное офисное кресло с регулировкой высоты",
                    DateOfCreation = new DateTime(2023, 7, 25),
                    MaterialId = 3
                }
            );
        }
    }
}
