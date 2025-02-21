﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SweetDictionary.Models.Entities;

namespace SweetDictionary.Repositories.Configurations;
public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable("Comments").HasKey(c => c.Id);
        builder.Property(c => c.Id).HasColumnName("CommentId");
        builder.Property(c => c.CreatedTime).HasColumnName("CreatedTime");
        builder.Property(c => c.UpdatedTime).HasColumnName("UpdatedTime");
        builder.Property(c => c.Text).HasColumnName("Text");
        builder.Property(c => c.UserId).HasColumnName("UserId");
        builder.Property(c => c.PostId).HasColumnName("PostId");

        builder.HasOne(x => x.User).WithMany(x => x.Comments).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.Posts).WithMany(c => c.Comments).HasForeignKey(c => c.PostId).OnDelete(DeleteBehavior.NoAction);
    }
}