using AutoMapper;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities; //02. Import the AutoMapper package.

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
        CreateMap<ProductReadDto, Product>();
        
        CreateMap<ProductCreateDto, Product>();


        CreateMap<Category, CategoryReadDto>();
        CreateMap<CategoryReadDto, Category>();

        CreateMap<CategoryCreateDto, Category>();





    }



}