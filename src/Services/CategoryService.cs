using AutoMapper;
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Services;

public class CategoryService : ICategoryService
{


    public ICategoryRepository _categoryRepository;
    private IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository,  IMapper mapper )
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
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

    public List<CategoryReadDto> FindAll()
    {
        var category =  _categoryRepository.FindAll();
        var categoryRead = category.Select(_mapper.Map<CategoryReadDto>);
        return categoryRead.ToList();
    }

    public CategoryReadDto? findOne(string categoryId)
    {
        Category category = _categoryRepository.findOne(categoryId);
        CategoryReadDto categoryRead = _mapper.Map<CategoryReadDto>(category);


        return categoryRead ;
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