using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Primitive_Auto_Mapping.Models;
namespace Primitive_Auto_Mapping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        public OrderController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet("{id}")]
        public ActionResult<OrderDTO> GetOrder(int id)
        {
            var order = new Order
            {
                OrderId = id,
                OrderDate = DateTime.Now,
                CustomerName = "Pranay",
                Items = new List<OrderItem>
                {
                    new OrderItem { ProductName = "Product 1", Price = 100m, Quantity = 2 },
                    new OrderItem { ProductName = "Product 2", Price = 50m, Quantity = 1 }
                }
            };
            var orderDto = _mapper.Map<OrderDTO>(order);
            return Ok(orderDto);
        }
    }
}