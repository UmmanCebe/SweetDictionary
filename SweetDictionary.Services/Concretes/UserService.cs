using Core.Entities;
using SweetDictionary.Models.Entities.Users;
using SweetDictionary.Services.Abstracts;
using SweetDictionary.Repositories.Repositories.Abstracts;
using AutoMapper;
using SweetDictionary.Models.Entities;
using SweetDictionary.Models.Entities.Posts;
using SweetDictionary.Services.Rules;

namespace SweetDictionary.Services.Concretes;
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public ReturnModel<UserResponseDto> Add(CreateUserRequestDto dto)
    {
        var createdUser = _mapper.Map<User>(dto);
        var user = _userRepository.Add(createdUser);
        var response = _mapper.Map<UserResponseDto>(user);
        return new ReturnModel<UserResponseDto>
        {
            Data = response,
            Success = true,
            Status = 200,
            Message = "User Eklendi."
        };
    }

    public ReturnModel<string> Delete(long id)
    {
        User user = _userRepository.GetById(id);
        User deletedUser = _userRepository.Delete(user);
        return new ReturnModel<string>
        {
            Data = $"UserName: {deletedUser.UserName}",
            Message = "User Silindi",
            Success = true,
            Status = 204
        };
    }

    public ReturnModel<List<UserResponseDto>> GetAll()
    {
        var users = _userRepository.GetAll();
        List<UserResponseDto> response = _mapper.Map<List<UserResponseDto>>(users);
        return new ReturnModel<List<UserResponseDto>>
        {
            Data = response,
            Success = true,
            Status = 200,
            Message = "Userlar Getirildi."
        };
    }

    public ReturnModel<UserResponseDto> GetById(long id)
    {
        try
        {
            var user = _userRepository.GetById(id);
            UserResponseDto response = _mapper.Map<UserResponseDto>(user);
            return new ReturnModel<UserResponseDto>
            {
                Data = response,
                Success = true,
                Status = 200,
                Message = "User getirildi."
            };
        }
        catch (Exception ex)
        {
            return ExceptionHandler<UserResponseDto>.HandleException(ex);
        }
    }

    public ReturnModel<UserResponseDto> Update(UpdateUserRequestDto dto)
    {
        try
        {
            var user = _mapper.Map<User>(dto);
            var updated = _userRepository.Update(user);
            var response = _mapper.Map<UserResponseDto>(user);
            return new ReturnModel<UserResponseDto>
            {
                Data = response,
                Success = true,
                Status = 200,
                Message = "User güncellendi."
            };
        }
        catch (Exception ex)
        {
            return ExceptionHandler<UserResponseDto>.HandleException(ex);
        }
    }
}