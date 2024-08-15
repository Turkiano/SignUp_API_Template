using Coffee_Shop_API_Server.src.Abstractions;

namespace Coffee_Shop_API_Server;


public class CategoryRepository : ICategoryRepository
{
private List<Cateogry> _category; //this to get users info as a list

    public CategoryRepository(List<Cateogry> category)
    {
        _category = category;
    }

    public List<Cateogry> FindAll()
    {
        return _category;
    }
}