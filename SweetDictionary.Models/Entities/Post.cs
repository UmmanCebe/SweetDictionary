﻿using Core.Entities;

namespace SweetDictionary.Models.Entities;
public sealed class Post : Entity<Guid>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public User Author { get; set; }
    public long AuthorId { get; set; }
    public List<Comment> Comments { get; set; }
    public Category Category { get; set; }
    public int CategoryId { get; set; }
}