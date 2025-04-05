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
        private AppDbContext _appDbContext;

        public DataWorker()
        {
            _appDbContext = new AppDbContext();
        }
        public List<Material> GetMaterials()
        {
            return _appDbContext.Materials.ToList();
        }

        public List<Product> GetProducts()
        {
            return _appDbContext.Products.Include(p => p.Materials).ToList();
        }
        public Material GetMaterialId(int id)
        {
            return _appDbContext.Materials.Where(m => m.Id == id).FirstOrDefault();
        }

        public List<Product> GetProductsMaterial(Material material)
        {
            if (material == null)
            {
                return new List<Product>();
            }
            return _appDbContext.Products.Where(p => p.MaterialId == material.Id).ToList();
        }
        public void SaveChanged()
        {
            _appDbContext.SaveChanges();
        }
    }
}
