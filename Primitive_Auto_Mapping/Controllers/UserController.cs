using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Primitive_Auto_Mapping.Models;
namespace Primitive_Auto_Mapping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }
        private List<User> listUsers = new List<User>()
        {
           new User { UserId = 1, Name="Pranaya", Email="Pranaya@Example.come",
                  Country = "India",
                  State = "Odisha",
                  City = "BBSR"
           },
           new User { UserId = 2, Name="Priyanka", 
               Email="Priyanka@Example.come",
                  Country = "India",
                  State = "Maharashtra",
                  City = "Mumbai"
           }
        };
        [HttpGet]
        public ActionResult<List<CategoryDTO>> GetAllUsers()
        {
            List<UserDTO> users = _mapper.Map<List<UserDTO>>(listUsers);
            return Ok(users);
        }
    }
}