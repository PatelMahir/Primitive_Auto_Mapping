namespace Primitive_Auto_Mapping.Models
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public AddressDTO Address { get; set; }
    }
}