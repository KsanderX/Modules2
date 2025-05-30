using Navigation.Models;

namespace Navigation.Services
{
    public interface IDbWork
    {
        public IEnumerable<Product> GetAllProducts();
        public IEnumerable<Material> GetAllMaterials();
        public Product GetProductById(int id);
        public Material GetMaterialById(int id);
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int id);
        public void SaveChanges();
    }
}
