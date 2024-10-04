using AutoMapper;
using Primitive_Auto_Mapping.Models;
namespace Primitive_Auto_Mapping.Models
{
    public class MyMappingProfile:Profile
    {
        public MyMappingProfile() 
        {
            //CreateMap<User, UserDTO>().ForMember(dest => dest.City, act => act.MapFrom(src => src.Address.City))
            //.ForMember(dest => dest.State, act => act.MapFrom(src => src.Address.State))
            //.ForMember(dest => dest.Country, act => act.MapFrom(src => src.Address.Country));
            CreateMap<User, UserDTO>()
               .ForMember(dest => dest.Address, act => act.MapFrom(src => new AddressDTO()
               {
                   City = src.City,
                   State = src.State,
                   Country = src.Country
               }));
            CreateMap<Product, ProductDTO>().ForMember(
                dest => dest.Price,
                opt =>
                {
                    opt.PreCondition(src => src.InStock);
                    opt.MapFrom(src => src.Price);
                });
            CreateMap<Product, ProductDTO>()
           .ForMember(dest => dest.Price, opt => {
               //Calling the ShouldMapPrice Static by passing the source object
               opt.PreCondition(src => CustomMappingLogic.ShouldMapPrice(src));
               opt.MapFrom(src => src.Price);
           });

            CreateMap<Product, ProductDTO>()
            .ForMember(dest => dest.Price, opt =>
            {
                opt.PreCondition(src => CustomMappingLogic.ShouldMapPrice(src.InStock, src.Category));
                opt.MapFrom(src => src.Price);
            });
            CreateMap<Order, OrderDTO>();
            CreateMap<Order, OrderDTO>()
            .AfterMap((src, dest) => CustomizeOrderDTO.CalculateTotalPrice(src, dest))
            //.AfterMap(CustomizeOrderDTO.CalculateTotalPrice)
            .AfterMap((src, dest) =>
            {
                dest.OrderDate = CustomizeOrderDTO.CustomizeOrderDate(src.OrderDate);
            });
            //Configure the Mappings Between OrderItem and OrderItemDTO
            CreateMap<OrderItem, OrderItemDTO>();
        }
    }
}