using AutoMapper;
using MongoDbEgitim.Dtos.CategoryDtos;
using MongoDbEgitim.Dtos.CustomerDtos;
using MongoDbEgitim.Dtos.OrderDtos;
using MongoDbEgitim.Dtos.ProductDtos;

using MongoDbEgitim.Entities;

namespace MongoDbEgitim.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() 
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategoryDto>().ReverseMap();

            CreateMap<Customer, CreateCustomerDto>().ReverseMap();
            CreateMap<Customer, UpdateCustomerDto>().ReverseMap();
            CreateMap<Customer, GetByIdCustomerDto>().ReverseMap();
            CreateMap<Customer, ResultCustomerDto>().ReverseMap();

            CreateMap<Order, CreateOrderDto>().ReverseMap();
            CreateMap<Order, UpdateOrderDto>().ReverseMap();
            CreateMap<Order, GetByIdOrderDto>().ReverseMap();
            CreateMap<Order, ResultOrderDto>().ReverseMap();
            CreateMap<Order, ResultOrderWithCustomerAndProductDto>().ReverseMap();
        }
    }
}
