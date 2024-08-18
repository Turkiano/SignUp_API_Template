using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;


namespace Coffee_Shop_App.Repositories;


public class CategoryRepository : ICategoryRepository
{
    private List<Category> _categories;

    public CategoryRepository()
    {
        _categories = new DatabaseContext().categories;
    }

    public Category CreateOne(Category category)
    {
        _categories.Add(category);
        return category;
    }

    public List<Category> FindAll()
    {
        return _categories;
    }



    public Category findOne(string categoryId)
    {
        Category? category = _categories?.FirstOrDefault(category => category.CategoryId == categoryId); //lambda expression to compare Ids

        return category; //to get the desired user
        throw new NotImplementedException();
    }
}

