using AutoMapper;
using Core.Entities;
using SweetDictionary.Models.Entities;
using SweetDictionary.Models.Entities.Comments;
using SweetDictionary.Models.Entities.Users;
using SweetDictionary.Repositories.Repositories.Abstracts;
using SweetDictionary.Repositories.Repositories.Concretes;
using SweetDictionary.Services.Abstracts;

namespace SweetDictionary.Services.Concretes;
public class CommentService : ICommentService
{
    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;

    public CommentService(ICommentRepository commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;
    }

    public ReturnModel<CommentResponseDto> Add(CreateCommentRequestDto dto)
    {
        var createdComment = _mapper.Map<Comment>(dto);
        createdComment.Id = Guid.NewGuid();
        var comment = _commentRepository.Add(createdComment);
        var response = _mapper.Map<CommentResponseDto>(comment);
        return new ReturnModel<CommentResponseDto>
        {
            Data = response,
            Success = true,
            Status = 200,
            Message = "Comment Eklendi."
        };
    }

    public ReturnModel<string> Delete(Guid id)
    {
        Comment comment = _commentRepository.GetById(id);
        Comment deletedComment = _commentRepository.Delete(comment);
        return new ReturnModel<string>
        {
            Data = $"CommentId: {deletedComment.Id}",
            Message = "Comment Silindi",
            Success = true,
            Status = 204
        };
    }

    public ReturnModel<List<CommentResponseDto>> GetAll()
    {
        var comments = _commentRepository.GetAll();
        List<CommentResponseDto> response = _mapper.Map<List<CommentResponseDto>>(comments);
        return new ReturnModel<List<CommentResponseDto>>
        {
            Data = response,
            Success = true,
            Status = 200,
            Message = "Commentler Getirildi."
        };
    }

    public ReturnModel<CommentResponseDto> GetById(Guid id)
    {
        var comment = _commentRepository.GetById(id);
        CommentResponseDto response = _mapper.Map<CommentResponseDto>(comment);
        return new ReturnModel<CommentResponseDto>
        {
            Data = response,
            Success = true,
            Status = 200,
            Message = "comment getirildi."
        };
    }

    public ReturnModel<CommentResponseDto> Update(UpdateCommentRequestDto dto)
    {
        var comment = _mapper.Map<Comment>(dto);
        var response = _mapper.Map<CommentResponseDto>(comment);
        return new ReturnModel<CommentResponseDto>
        {
            Data = response,
            Success = true,
            Status = 200,
            Message = "comment güncellendi."
        };
    }
}