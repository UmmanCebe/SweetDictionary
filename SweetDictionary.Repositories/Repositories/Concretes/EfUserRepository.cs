using Core.Repositories;
using SweetDictionary.Models.Entities;
using SweetDictionary.Repositories.Contexts;
using SweetDictionary.Repositories.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDictionary.Repositories.Repositories.Concretes
{
    public class EfUserRepository : EFRepositoryBase<BaseDbContext, User, long>, IUserRepository
    {
        public EfUserRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
