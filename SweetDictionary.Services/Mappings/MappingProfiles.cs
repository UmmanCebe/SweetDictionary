using AutoMapper;
using SweetDictionary.Models.Entities;
using SweetDictionary.Models.Entities.Categories;
using SweetDictionary.Models.Entities.Comments;
using SweetDictionary.Models.Entities.Posts;
using SweetDictionary.Models.Entities.Users;

namespace SweetDictionary.Services.Mappings;
public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<CreatePostRequestDto, Post>();
        CreateMap<Post, PostResponseDto>();
        CreateMap<UpdatePostRequestDto, Post>();

        CreateMap<CreateUserRequestDto, User>();
        CreateMap<User, UserResponseDto>();
        CreateMap<UpdateUserRequestDto, User>();

        CreateMap<CreateCategoryRequestDto, Category>();
        CreateMap<Category, CategoryResponseDto>();
        CreateMap<UpdateCategoryRequestDto, Category>();

        CreateMap<CreateCommentRequestDto, Comment>();
        CreateMap<Comment, CommentResponseDto>();
        CreateMap<UpdateCommentRequestDto, Comment>();
    }
}