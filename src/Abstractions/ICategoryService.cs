

using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;

public interface ICategoryService
{
        public List<CategoryReadDto> FindAll();
    public CategoryReadDto? findOne(string categoryId);

        public Category CreateOne(Category category);


        public Category UpdateOne(string CategoryId, Category updatedCategory);




}
