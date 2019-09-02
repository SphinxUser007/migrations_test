using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL1
{
   public class ContextFactory : IDesignTimeDbContextFactory<BlogContext>
    {
        public BlogContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BlogContext>();
            builder.UseSqlServer("Server=.;Database=exampletest123;Trusted_Connection=True; MultipleActiveResultSets=true;");
            return new BlogContext(builder.Options);
        }
    
    }
}
