using Core.Entities;
using SweetDictionary.Models.Entities.Categories;

namespace SweetDictionary.Services.Abstracts;
public interface ICategoryService
{
    ReturnModel<CategoryResponseDto> Add(CreateCategoryRequestDto dto);
    ReturnModel<List<CategoryResponseDto>> GetAll();
    ReturnModel<CategoryResponseDto> GetById(int id);
    ReturnModel<CategoryResponseDto> Update(UpdateCategoryRequestDto dto);
    ReturnModel<string> Delete(int id);
}