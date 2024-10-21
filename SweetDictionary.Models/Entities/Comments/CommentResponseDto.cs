namespace SweetDictionary.Models.Entities.Comments;
public record CommentResponseDto
{
    public Guid Id { get; init; }
    public string Text { get; init; }
    public Guid PostId { get; init; }
    public long UserId { get; init; }
    //public string UserFirstName { get; init; }
    //public string PostTitle { get; init; }
}