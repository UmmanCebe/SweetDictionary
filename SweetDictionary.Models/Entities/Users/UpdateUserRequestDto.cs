namespace SweetDictionary.Models.Entities.Users;

public record UpdateUserRequestDto(long Id, string UserName, string FirstName, string LastName, string Email, string Password);