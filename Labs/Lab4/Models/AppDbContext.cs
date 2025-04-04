﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab4.DataBase
{
    public class AppDbContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>().HasData(
                new Material { Id = 1, Name = "Plastic" },
                new Material { Id = 2, Name = "Metall" },
                new Material { Id = 3, Name = "Wood" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Bottle", Price = 200, MaterialId = 1 },
                new Product { Id = 2, Name = "Table", Price = 600, MaterialId = 3 },
                new Product { Id = 3, Name = "Chair", Price = 400, MaterialId = 2 },
                new Product { Id = 4, Name = "Polka", Price = 200, MaterialId = 3 }
                );
        }
    }
}
