namespace Primitive_Auto_Mapping.Models
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public string OrderDate { get; set; } 
        public string CustomerName { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderItemDTO> Items { get; set; }
            = new List<OrderItemDTO>();
    }
}