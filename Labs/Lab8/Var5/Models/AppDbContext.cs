using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Var5.Models
{
	public class AppDbContext : DbContext
	{
		public DbSet<Request> Requests { get; set; }
		public DbSet<ProductType> ProductsTypes { get; set; }
		public DbSet<Provider> Providers { get; set; }
		public DbSet<RequestStatus> RequestStatuses { get; set; }
		
		public AppDbContext()
		{
			Database.EnsureCreated();
		}

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data source=./app.db");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Provider>().HasData(
					new Provider { Id = 1, Name = "Stepan" },
					new Provider { Id = 2, Name = "Maxim" },
					new Provider { Id = 3, Name = "Anastasia" }
			);
			modelBuilder.Entity<RequestStatus>().HasData(
				   new RequestStatus { Id = 1, Name = "On the way" },
				   new RequestStatus { Id = 2, Name = "in stock" },
				   new RequestStatus { Id = 3, Name = "delivered" }
		   );

			modelBuilder.Entity<ProductType>().HasData(
				new ProductType { Id = 1, Name = "Laptops", Weight = 5, Volume = 10 },
				new ProductType { Id = 2, Name = "Phone", Weight = 2, Volume = 15 },
				new ProductType { Id = 3, Name = "Controllers", Weight = 1, Volume = 10 }
		   );


		}
	}
}
