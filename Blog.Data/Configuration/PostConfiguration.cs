using Blog.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.HasKey(x => x.PostID);
            builder.Property(x => x.PostID).UseIdentityColumn();
            builder.Property(x => x.Title).HasMaxLength(30);
            builder.Property(x => x.Content).HasMaxLength(50);
            builder.Property(x => x.DateCreated).HasDefaultValue(DateTime.Now);
            builder.HasOne(x => x.User).WithMany(x => x.Posts).HasForeignKey(x => x.UserID);
        }
    }
}
