namespace SweetDictionary.Models.Entities.Posts;
public record UpdatePostRequestDto(Guid Id, string Title, string Content);