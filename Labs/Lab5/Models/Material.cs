namespace Lab5.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new();
        public override string ToString()
        {
            return Name;
        }
    }
}
