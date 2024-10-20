using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories;

public abstract class EFRepositoryBase<TContext, TEntity, TId> : IRepository<TEntity, TId>
    where TEntity : Entity<TId>, new()
    where TContext : DbContext
{
    protected TContext Context { get; }
    public EFRepositoryBase(TContext context)
    {
        Context = context;
    }

    public TEntity Add(TEntity entity)
    {
        entity.CreatedTime = DateTime.Now;
        Context.Set<TEntity>().Add(entity);
        Context.SaveChanges();
        return entity;
    }

    public TEntity Update(TEntity entity)
    {
        entity.UpdatedTime = DateTime.Now;
        Context.Set<TEntity>().Update(entity);
        Context.SaveChanges();
        return entity;
    }

    public TEntity Delete(TEntity entity)
    {
        Context.Set<TEntity>().Remove(entity);
        Context.SaveChanges();
        return entity;
    }

    public TEntity? GetById(TId id)
    {
       return Context.Set<TEntity>().Find(id);
    }

    public List<TEntity> GetAll()
    {
        return Context.Set<TEntity>().ToList();
    }
}