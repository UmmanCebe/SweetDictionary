using SweetDictionary.Models.Entities.Posts;

namespace SweetDictionary.Models.Entities.Users;
public record UserResponseDto(long Id, string UserName, string FirstName, string Email);