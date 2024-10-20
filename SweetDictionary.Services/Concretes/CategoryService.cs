using AutoMapper;
using Core.Entities;
using SweetDictionary.Models.Entities;
using SweetDictionary.Models.Entities.Categories;
using SweetDictionary.Repositories.Repositories.Abstracts;
using SweetDictionary.Services.Abstracts;

namespace SweetDictionary.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }


        public ReturnModel<CategoryResponseDto> Add(CreateCategoryRequestDto dto)
        {
            var createdCategory = _mapper.Map<Category>(dto);
            var category = _categoryRepository.Add(createdCategory);
            var response = _mapper.Map<CategoryResponseDto>(category);
            return new ReturnModel<CategoryResponseDto>
            {
                Data = response,
                Success = true,
                Status = 200,
                Message = "Category Eklendi."
            };
        }

        public ReturnModel<string> Delete(int id)
        {
            Category category = _categoryRepository.GetById(id);
            Category deletedCategory = _categoryRepository.Delete(category);
            return new ReturnModel<string>
            {
                Data = $"UserName: {deletedCategory.Name}",
                Message = "Category Silindi",
                Success = true,
                Status = 204
            };
        }

        public ReturnModel<List<CategoryResponseDto>> GetAll()
        {
            var categories = _categoryRepository.GetAll();
            List<CategoryResponseDto> response = _mapper.Map<List<CategoryResponseDto>>(categories);
            return new ReturnModel<List<CategoryResponseDto>>
            {
                Data = response,
                Success = true,
                Status = 200,
                Message = "Categoryler Getirildi."
            };
        }

        public ReturnModel<CategoryResponseDto> GetById(int id)
        {
            var category = _categoryRepository.GetById(id);
            CategoryResponseDto response = _mapper.Map<CategoryResponseDto>(category);
            return new ReturnModel<CategoryResponseDto>
            {
                Data = response,
                Success = true,
                Status = 200,
                Message = "Category getirildi."
            };
        }

        public ReturnModel<CategoryResponseDto> Update(UpdateCategoryRequestDto dto)
        {
            var category = _mapper.Map<Category>(dto);
            var response = _mapper.Map<CategoryResponseDto>(category);
            return new ReturnModel<CategoryResponseDto>
            {
                Data = response,
                Success = true,
                Status = 200,
                Message = "Category güncellendi."
            };
        }
    }
}