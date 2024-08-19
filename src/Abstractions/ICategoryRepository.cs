

using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;

public interface ICategoryRepository
{
    public List<Category> FindAll();

    public Category? findOne(string categoryId);

    public Category CreateOne(Category category);

    public Category UpdateOne(Product updateCategory);



}
