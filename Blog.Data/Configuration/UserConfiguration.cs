using Blog.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.UserID);
            builder.Property(x => x.UserID).UseIdentityColumn();
            builder.Property(x => x.UserName).HasMaxLength(20).IsUnicode(false).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(30).IsUnicode(false).IsRequired();
            builder.Property(x => x.DateCreated).HasDefaultValue(DateTime.Now);

        }
    }
}
