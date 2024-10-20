namespace SweetDictionary.Models.Entities.Posts;
public record CreatePostRequestDto(string Title, string Content, int CategoryId, long AuthorId);