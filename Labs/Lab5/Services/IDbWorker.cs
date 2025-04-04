using Lab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Services
{
    public interface IDbWorker
    {
        public IEnumerable<Product> GetProducts();
        public IEnumerable<Material> GetMaterials();
        public void SaveChanged();
    }
}
