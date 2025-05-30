using Microsoft.EntityFrameworkCore;
using Navigation.Models;

namespace Navigation.Services
{
    public class DbWork : IDbWork
    {
        private readonly AppDbContext _context;
        public DbWork(AppDbContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null) 
            {
                _context.Products.Remove(product);
            }
        }

        public IEnumerable<Material> GetAllMaterials()
        {
            return _context.Materials.ToList();
        }

        public IEnumerable<Product> GetAllProducts()
        {
           return _context.Products.Include(p => p.Material).ToList();           
        }

        public Material? GetMaterialById(int id)
        {
            return _context.Materials.SingleOrDefault(m => m.Id == id);
        }

        public Product? GetProductById(int id)
        {
            return _context.Products.SingleOrDefault(p => p.Id == id);
        }
        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();                    
        }
    }
}
