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
            return _appDbContext.Products.ToList();
        }
        public void SaveChanged()
        {
            _appDbContext.SaveChanges();
        }
    }
}
