using Lab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Services
{
    public class DataService : IDataService
    {
        private readonly AppDbContext _context;
        public DataService(AppDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        public List<Material> GetMaterials()
        {
            return _context.Materials.ToList();
        }
        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
