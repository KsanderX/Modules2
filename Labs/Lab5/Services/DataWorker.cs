using Lab5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Services
{
    public class DataWorker : IDbWorker
    {
        public IEnumerable<Material> GetMaterials()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Materials.ToList();
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Products.Include(p => p.Materials).ToList();
            }
        }
        public void SaveChanged()
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.SaveChanges();
            }
        }
    }
}
