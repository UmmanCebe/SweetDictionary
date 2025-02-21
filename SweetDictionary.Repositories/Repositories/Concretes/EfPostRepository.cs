﻿using Core.Repositories;
using SweetDictionary.Models.Entities;
using SweetDictionary.Repositories.Contexts;
using SweetDictionary.Repositories.Repositories.Abstracts;


namespace SweetDictionary.Repositories.Repositories.Concretes;
public class EfPostRepository : EFRepositoryBase<BaseDbContext, Post, Guid>, IPostRepository
{
    public EfPostRepository(BaseDbContext context) : base(context)
    {
    }

    public List<Post> GetAllByAuthorId(long authorId)
    {
        // select * from posts where AuthorId = authorId
        List<Post> posts = Context.Posts.Where(x => x.AuthorId == authorId).ToList();
        return posts;
    }

    public List<Post> GetAllByCategoryId(int categoryId)
    {
        List<Post> posts = Context.Posts.Where(x => x.CategoryId == categoryId).ToList();
        return posts;
    }

    public List<Post> GetAllByTitleContains(string text)
    {
        List<Post> posts = Context.Posts
        .Where(x => x.Title.Contains(text, StringComparison.InvariantCultureIgnoreCase))
        .ToList();

        return posts;
    }
}