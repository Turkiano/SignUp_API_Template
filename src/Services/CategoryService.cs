using Coffee_Shop_API_Server.src.Abstractions;

namespace Coffee_Shop_API_Server;

public class CategoryService : ICategoryService {


public ICategoryRepository _categoryRepository;

    public List<Category> FindAll()
    {
        return _categoryRepository.FindAll();
    }
}