using SweetDictionary.Models.Entities.Posts;

namespace SweetDictionary.Models.Entities.Categories;
public record CategoryResponseDto()
{
    public int Id { get; init; }
    public string Name { get; init; }
    //public List<PostResponseDto> Posts { get; init; }
}