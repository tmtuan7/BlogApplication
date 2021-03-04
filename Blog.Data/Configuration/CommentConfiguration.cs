using Blog.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(x => x.CommentID);
            builder.Property(x => x.CommentID).UseIdentityColumn();
            builder.Property(x => x.Content).HasMaxLength(3000).IsRequired();
            builder.Property(x => x.DateCreated).HasDefaultValue(DateTime.Now);

            builder.HasOne(x => x.User).WithMany(x => x.Comments).HasForeignKey(x => x.CommentID);

            builder.HasOne(x => x.Post).WithMany(x => x.Comments).HasForeignKey(x => x.PostID);
        }
    }
}
