using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab4.Models;

namespace Lab4.Savices
{
    class AppDbContext : DbContext
    {
        public AppDbContext
            {

            }

        public DbSet<Products> Products { get; set; }
        public DbSet<Materials> Materials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Materials[] materials = [
                new(){Id = 1, Name = "Дерево"},
                new(){Id = 2, Name = "Кожа"},
                new(){Id = 3, Name = "Дерево"},
                new(){Id = 4, Name = "Дерево"},
                new(){Id = 5, Name = "Дерево"},
                ];

            Products[] products = [
                new(){Id = 1, Name ="Меч" },
                ];
        }
    }
}

