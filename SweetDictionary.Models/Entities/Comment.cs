using Core.Entities;

namespace SweetDictionary.Models.Entities;
public class Comment : Entity<Guid>
{
    public string Text { get; set; }
    public Post Posts { get; set; }
    public User User { get; set; }
    public Guid PostId { get; set; }
    public long UserId { get; set; }
}