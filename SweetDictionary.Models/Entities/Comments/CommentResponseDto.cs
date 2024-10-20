namespace SweetDictionary.Models.Entities.Comments;
public record CommentResponseDto
{
    public string CommentId { get; init; }
    public string Text { get; init; }
    public string AuthorName { get; init; }
    public string PostName { get; init; }
}