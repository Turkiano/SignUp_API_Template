using Coffee_Shop_API_Server.src.Abstractions;
using Coffee_Shop_App.src.Controller;

namespace Coffee_Shop_API_Server;

public class Cateogry : BaseController {

    private ICategoryService? _categoryService; //to talk to the service

    public Cateogry(ICategoryService? categoryService) //The constructor
    {
        _categoryService = categoryService;
    }


        public List<Cateogry> FindAll(){

            return _categoryService.FindAll();
        }

}