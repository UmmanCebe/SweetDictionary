using SweetDictionary.Models.Entities.Posts;
using Core.Entities;

namespace SweetDictionary.Services.Abstracts;
public interface IPostService
{
    ReturnModel<PostResponseDto> Add(CreatePostRequestDto dto);
    ReturnModel<List<PostResponseDto>> GetAll();
    ReturnModel<PostResponseDto> GetById(Guid id);
    ReturnModel<PostResponseDto> Update(UpdatePostRequestDto dto);
    ReturnModel<string> Delete(Guid id);
    ReturnModel<List<PostResponseDto>> GetAllByCategoryId(int id);
    ReturnModel<List<PostResponseDto>> GetAllByAuthorId(long authorId);
    ReturnModel<List<PostResponseDto>> GetAllByTitleContains(string text);
}