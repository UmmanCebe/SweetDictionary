using Core.Repositories;
using SweetDictionary.Models.Entities;

namespace SweetDictionary.Repositories.Repositories.Abstracts;
public interface IPostRepository : IRepository<Post, Guid>
{
    List<Post> GetAllByCategoryId(int categoryId);
    List<Post> GetAllByAuthorId(long authorId);
    List<Post> GetAllByTitleContains(string text);
}