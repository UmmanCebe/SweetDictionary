using Core.Entities;
using SweetDictionary.Models.Entities.Comments;

namespace SweetDictionary.Services.Abstracts;
public interface ICommentService
{
    ReturnModel<CommentResponseDto> Add(CreateCommentRequestDto dto);
    ReturnModel<List<CommentResponseDto>> GetAll();
    ReturnModel<CommentResponseDto> GetById(Guid id);
    ReturnModel<CommentResponseDto> Update(UpdateCommentRequestDto dto);
    ReturnModel<string> Delete(Guid id);
}