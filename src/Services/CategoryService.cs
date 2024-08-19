using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Services;

public class CategoryService : ICategoryService
{


    public ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public Category CreateOne(Category category)
    {
        Category? foundCategory = _categoryRepository.findOne(category.CategoryId);//to avoid duplicated emails
        if (foundCategory is not null)
        {
            return null;
        }
        return _categoryRepository.CreateOne(category);


    }

    public List<Category> FindAll()
    {
        return _categoryRepository.FindAll();
    }

    public Category? findOne(string categoryId)
    {
        return _categoryRepository.findOne(categoryId);
    }

    public Category UpdateOne(string CategoryId, Category updatedCategory)
    {
        Category? category = _categoryRepository.findOne(CategoryId);
        if(category is not null)
        {
            category.Name = updatedCategory.Name;
            return _categoryRepository.UpdateOne(category);
        }
        return null;
    }
}