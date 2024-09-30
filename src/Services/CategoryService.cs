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


    public CategoryReadDto CreateOne(CategoryCreateDto category)
    {
        Category? foundCategory = _categoryRepository.findOne(category.CategoryId);//to avoid duplicated id
        if (foundCategory is not null)
        {
            return null;
        }

        Category mappedCategory = _mapper.Map<Category>(category);
        Category newCategory = _categoryRepository.CreateOne(mappedCategory);
        CategoryReadDto CategoryRead = _mapper.Map<CategoryReadDto>(newCategory);

        return  CategoryRead;


    }

    public IEnumerable<CategoryReadDto> FindAll(int limit, int offset)
    {
        IEnumerable<Category> category =  _categoryRepository.FindAll( limit,  offset);
        var categoryRead = category.Select(_mapper.Map<CategoryReadDto>);
        return categoryRead.ToList();
    }



    public CategoryReadDto findOne(Guid categoryId)
    {
        Category category = _categoryRepository.findOne(categoryId);
        CategoryReadDto categoryRead = _mapper.Map<CategoryReadDto>(category);


        return categoryRead ;
    }




    public CategoryReadDto UpdateOne(Guid CategoryId, CategoryCreateDto updatedCategory)
    {
        Category? category = _categoryRepository.findOne(CategoryId);
        if(category is not null)
        {
            category.Name = updatedCategory.Name;
            Category mappedCategory = _mapper.Map<Category>(category);
            Category newCategory = _categoryRepository.UpdateOne(mappedCategory);
            CategoryReadDto categoryRead= _mapper.Map<CategoryReadDto>(newCategory);
            return categoryRead;
        }
        return null;
    }
}