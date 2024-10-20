using Core.Repositories;
using SweetDictionary.Models.Entities;
using SweetDictionary.Repositories.Contexts;
using SweetDictionary.Repositories.Repositories.Abstracts;

namespace SweetDictionary.Repositories.Repositories.Concretes;
public class EfCommentRepository : EFRepositoryBase<BaseDbContext, Comment, Guid>, ICommentRepository
{
    public EfCommentRepository(BaseDbContext context) : base(context)
    {
    }
}