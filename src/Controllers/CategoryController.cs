using Coffee_Shop_API_Server.src.Abstractions;
using Coffee_Shop_App.src.Controller;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_API_Server;

public class Category : BaseController
{

    private ICategoryService? _categoryService; //to talk to the service

    public Category(ICategoryService? categoryService) //The constructor
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public List<Category> FindAll()
    {

        return _categoryService.FindAll();
    }

}