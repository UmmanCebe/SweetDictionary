using Core.Repositories;
using SweetDictionary.Models.Entities;
using SweetDictionary.Repositories.Contexts;
using SweetDictionary.Repositories.Repositories.Abstracts;

namespace SweetDictionary.Repositories.Repositories.Concretes
{
    public class EfCategoryRepsoitory : EFRepositoryBase<BaseDbContext, Category, int>, ICategoryRepository
    {
        public EfCategoryRepsoitory(BaseDbContext context) : base(context)
        {
        }
    }
}