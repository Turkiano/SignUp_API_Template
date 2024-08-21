using AutoMapper;
using Coffee_Shop_App.DTOs;
using Coffee_Shop_App.src.Entities; //02. Import the AutoMapper package.

namespace Coffee_Shop_App.src.Mapper;

//01. Inherit the AutoMapper class [Profile]
public class Mapper : Profile
{

    public Mapper() //a constructor for AutoMapper Configuration
    {

    CreateMap<User, UserReadDto>();//for mapping User class into UserDTO class
    CreateMap<UserReadDto, User>();//for mapping UserDto class into User class

    }



}