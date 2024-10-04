using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Primitive_Auto_Mapping.Models;
namespace Primitive_Auto_Mapping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        public ProductController(IMapper mapper)
        {
            _mapper = mapper;
        }
        private List<Product>listProducts=new List<Product>()
        {
            new Product{Id=1001,Name="Laptop", Category="Electronics", Price = 1000, InStock = true},
            new Product { Id = 1002, Name="T-Shirt", Category="Merchandise", Price = 2000, InStock = false},
            new Product { Id = 1003, Name="Desktop", Category="Electronics", Price = 1000, InStock = false},
            new Product { Id = 1003, Name="Jacket", Category="Merchandise", Price = 2000, InStock = false}
        };
        [HttpGet]
        public ActionResult<ProductDTO> GetProdcuts()
        {
            var productDTO = _mapper.Map<List<ProductDTO>>(listProducts);
            return Ok(productDTO);
        }
    }
}