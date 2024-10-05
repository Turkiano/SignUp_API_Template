using AutoMapper;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Mapper;

//01. Inherit the AutoMapper class [Profile]
public class Mapper : Profile
{

    public Mapper() //a constructor for AutoMapper Configuration
    {

        CreateMap<User, UserReadDto>();//for mapping User class into UserReadDto class
        CreateMap<UserReadDto, User>();//for mapping UserReadDto class into User class

        CreateMap<UserCreateDto, User>();//for mapping UserCreateDto class into User class


        CreateMap<Product, ProductReadDto>();
        CreateMap<ProductCreateDto, Product>();

        CreateMap<ProductUpdateDto, Product>();



        CreateMap<Category, CategoryReadDto>();
        CreateMap<CategoryCreateDto, Category>();

        CreateMap<CategoryCreateDto, Category>();


        CreateMap<Order, OrderReadDto>();
        CreateMap<OrderCreateDto, Order>();

        CreateMap<OrderUpdateDto, Order>();


        CreateMap<OrderItem, OrderItemReadDto>();
        CreateMap<OrderItemCreateDto, OrderItem>();

        CreateMap<OrderItemCreateDto, OrderItem>();


        CreateMap<Review, ReviewReadDto>();
        CreateMap<ReviewReadDto, Review>();

        CreateMap<ReviewCreateDto, Review>();









    }



}