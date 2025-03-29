using Lab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Services
{
    public interface IDataService
    {
        public List<Material> GetMaterials();
        public List<Product> GetProducts();
        public void SaveChanges();
    }
}
