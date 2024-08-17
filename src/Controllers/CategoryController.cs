using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Controllers;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.Controllers;

public class CategoryController : BaseController
{

    private ICategoryService? _categoryService; //to talk to the service

    public CategoryController(ICategoryService? categoryService) //The constructor
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public List<Category> FindAll()
    {

        return _categoryService.FindAll();
    }

}