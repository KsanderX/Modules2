using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4.DataBase;

namespace Lab4.Service
{
    public interface IDataService
    {
        public List<Material> GetMaterials();
        public List<Product> GetProducts();
        public void SaveChanges();
    }
}
