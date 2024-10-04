namespace Primitive_Auto_Mapping.Models
{
    public class CustomMappingLogic
    {
        public static bool ShouldMapPrice(Product source)
        {
            return source.InStock && source.Category == "Electronics";
        }
        public static bool ShouldMapPrice(bool InStock,
            string Category)
        {
            return InStock && Category == "Electronics";
        }
    }
}