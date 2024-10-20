using Core.Repositories;
using SweetDictionary.Models.Entities;

namespace SweetDictionary.Repositories.Repositories.Abstracts;
public interface ICommentRepository:IRepository<Comment,Guid>
{
}