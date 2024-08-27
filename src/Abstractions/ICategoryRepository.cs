

using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;

public interface ICategoryRepository
{
    public IEnumerable<Category> FindAll();

    public Category? findOne(string categoryId);

    public Category CreateOne(Category category);

    public Category UpdateOne(Category updateCategory);



}
