
using Coffee_Shop_API_Server.src.Abstractions;
using Coffee_Shop_App.src.Controller;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_API_Server.src.Controllers;

[Route("[controller]")]
public class ProductController : BaseController
{

    private IProductService? _productService;

    public ProductController(IProductService? productService)
    {
        _productService = productService;
    }



[HttpGet("{ProductId}")]
    public Product? findOne(string productId)
    {

        return _productService.findOne(productId);
    }


}
