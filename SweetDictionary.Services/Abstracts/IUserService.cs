using Core.Entities;
using SweetDictionary.Models.Entities.Users;

namespace SweetDictionary.Services.Abstracts;

public interface IUserService
{
    ReturnModel<UserResponseDto> Add(CreateUserRequestDto dto);
    ReturnModel<List<UserResponseDto>> GetAll();
    ReturnModel<UserResponseDto> GetById(long id);
    ReturnModel<UserResponseDto> Update(UpdateUserRequestDto dto);
    ReturnModel<string> Delete(long id);
}