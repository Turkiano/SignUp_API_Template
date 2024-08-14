
using Coffee_Shop_API_Server.src.Abstractions;
using Coffee_Shop_App.src.Controller;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_API_Server.src.Controllers;


public class ProductController : BaseController
{

    private IProductService? _productService;

    public ProductController(IProductService? productService)
    {
        _productService = productService;
    }



    [HttpGet("{productId}")]
    // [ProducesResponseType(StatusCodes.Status400BadRequest)]
    // [ProducesResponseType(StatusCodes.Status200OK)]
    public Product? FindOne(string productId)
    {

        
        return _productService.FindOne(productId);
    }


    [HttpGet]
    public List<Product> FindAll()
    {

        return _productService.FindAll();
    }


    // [HttpPost]
    // public List<Product> CreateOne([FromBody] Product product)
    // {

    //     throw new NotImplementedException();
    // }

}
