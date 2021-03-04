using Blog.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.Configuration
{
    public class ImagePostConfiguration : IEntityTypeConfiguration<ImagePost>
    {
        public void Configure(EntityTypeBuilder<ImagePost> builder)
        {
            builder.ToTable("Images");
            builder.HasKey(x => x.ImageID);
            builder.Property(x => x.ImageStream).HasMaxLength(3000).IsRequired();

            builder.HasOne(x => x.Post).WithMany(x => x.Images).HasForeignKey(x => x.PostID);
        }
    }
}
