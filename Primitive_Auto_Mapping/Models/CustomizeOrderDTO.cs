namespace Primitive_Auto_Mapping.Models
{
    public class CustomizeOrderDTO
    {
        public static string CustomizeOrderDate(DateTime orderDate)
        {
            return orderDate.ToString("dd-MM-yyyy");
        }
        public static void CalculateTotalPrice(Order source, OrderDTO destination)
        {
            destination.TotalPrice = source.Items.Sum(item => item.Price * item.Quantity);
        }
    }
}