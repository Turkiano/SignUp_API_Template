using Coffee_Shop_API_Server.src.Abstractions;

namespace Coffee_Shop_API_Server;

public class CategoryService : ICategoryService {


public ICategoryService _categoryService;

    public List<Cateogry> FindAll()
    {
        return _categoryService.FindAll();
    }
}