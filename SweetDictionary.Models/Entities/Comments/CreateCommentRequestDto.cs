namespace SweetDictionary.Models.Entities.Comments;
public record CreateCommentRequestDto(string Text, long UserId, Guid PostId);