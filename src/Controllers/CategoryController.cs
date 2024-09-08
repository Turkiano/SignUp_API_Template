using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Controllers;
using Coffee_Shop_App.src.DTOs;
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
    public List<CategoryReadDto> FindAll()
    {


        return _categoryService.FindAll();
    }

    [HttpGet("{categoryId}")]
    public CategoryReadDto? findOne(Guid categoryId)
    {

        return _categoryService.findOne(categoryId);
    }


    [HttpPost] //POST, PUT, or PATCH use fromBody
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult<CategoryReadDto> CreateOne([FromBody] CategoryCreateDto category)
    {
        if (category is not null)
        {
            var newCategory = _categoryService!.CreateOne(category); //sendin request to service
            return CreatedAtAction(nameof(CreateOne), newCategory); //return value in ActionResult

        }
        return BadRequest(); //built-in method for validation




    }

    [HttpPatch("{CategoryId}")]
    public CategoryReadDto? UpdateOne(Guid CategoryId, [FromBody] CategoryCreateDto updatedCategory)
    {
        return _categoryService!.UpdateOne(CategoryId, updatedCategory);
    }
}