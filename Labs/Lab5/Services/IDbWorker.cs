using Lab5.Models;

namespace Lab5.Services
{
    public interface IDbWorker
    {
        public List<Product> GetProducts();
        public List<Material> GetMaterials();
        public Material GetMaterialId(int id);
        public List<Product> GetProductsMaterial(Material material);
        public void SaveChanged();
    }
}
