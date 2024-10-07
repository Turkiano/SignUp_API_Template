using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Controllers;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
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
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<IEnumerable<CategoryReadDto>> FindAll([FromQuery(Name = "limit")] int limit, [FromQuery(Name = "offset")] int offset)
    {


        return Ok(_categoryService!.FindAll(limit, offset));
    }



    [HttpGet("{categoryId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<CategoryReadDto?> findOne(Guid categoryId)
    {
        CategoryReadDto category = _categoryService.findOne(categoryId);
        if (category is null) return NotFound();
        return Ok(category);
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
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public ActionResult<CategoryReadDto?> UpdateOne(Guid CategoryId, [FromBody] CategoryCreateDto updatedCategory)
    {
        CategoryReadDto category = _categoryService!.UpdateOne(CategoryId, updatedCategory);
        if (category is null) return NotFound();

        return Accepted(category);
    }


    [HttpDelete(":categoryId")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<IActionResult> DeleteOne(Guid categoryId)
    {

        try
        {
            bool result = await _categoryService.DeleteOneAsync(categoryId);
            if (result)
            {
                return Ok(new { message = "Category is successfully deleted." });
            }
            else
            {
                return NotFound(new { message = $"Category with ID {categoryId} not found." });
            }
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
        catch (Exception)
        {
            return StatusCode(500, new { message = "An error occurred while deleting the Category" });
        }

    }

}