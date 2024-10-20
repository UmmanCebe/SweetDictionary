namespace SweetDictionary.Models.Entities.Users;
public record CreateUserRequestDto(string UserName, string FirstName, string LastName, string Email, string Password);