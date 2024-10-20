using SweetDictionary.Models.Entities.Posts;

namespace SweetDictionary.Models.Entities.Users;
public record UserResponseDto(long Id, string UserName, List<PostResponseDto> Posts, List<Comment> Comments);