﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Blog.Data.EF
{
    public class BlogDataDbContextFactory : IDesignTimeDbContextFactory<BlogDataDbContext>
    {
        public BlogDataDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();

            var connectionString = configuration.GetConnectionString("BlodDB");

            var optionsBuilder = new DbContextOptionsBuilder<BlogDataDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new BlogDataDbContext(optionsBuilder.Options);
        }
    }
}
