namespace Navigation.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfLastEdit { get; set; }
        public int? MaterialId { get; set; }
        public Material? Material { get; set; }
    }
}
