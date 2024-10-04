namespace Primitive_Auto_Mapping.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public string Category {  get; set; }
    }
}