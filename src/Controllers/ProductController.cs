
using System.Collections.Generic;
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Controllers;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.src.Controllers;


public class ProductController : BaseController
{

    private IProductService? _productService; //to talk to the service

    public ProductController(IProductService? productService) //this is the constructor
    {
        _productService = productService;
    }





    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<IEnumerable<ProductReadDto>> FindAll([FromQuery(Name = "limit")] int limit, [FromQuery(Name = "offset")] int offset)
    {
        Console.WriteLine($"LIMIT = {limit} OFFSET = {offset}"); //to test pagination
        return Ok(_productService!.FindAll(limit, offset));
    }





    [HttpPost] // (POST, PUT, or PATCH, Delete) use fromBody
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult CreateOne([FromBody] ProductCreateDto product)
    {
        if (product is not null)
        {
            var newProduct = _productService!.CreateOne(product);
            return CreatedAtAction(nameof(CreateOne), newProduct);
        }
        return BadRequest();
    }




    [HttpDelete(":productId")] // (POST, PUT, or PATCH) use fromBody
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult DeleteOne(Guid productId)
    {
        bool deletedProduct = _productService!.DeleteOne(productId);//to delete through the repo
        if (deletedProduct) return NoContent(); //when its delete, show (No Content)
        return NotFound();


    }




    [HttpPatch(":productId")] // (POST, PUT, or PATCH) use fromBody
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public ActionResult<ProductReadDto> UpdateOne(Guid productId, [FromBody] ProductUpdateDto updatedProduct)
    {
        ProductReadDto product = _productService!.UpdateOne(productId, updatedProduct);//to update through the service
        return Accepted(product);


    }





    [HttpGet("{productId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ProductReadDto> FindOne(Guid productId)
    {

        ProductReadDto product = _productService!.FindOne(productId);//to pass request the service
        if (product is null) return NotFound();

        return Ok(product);
    }





}
