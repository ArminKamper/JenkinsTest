using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace EntityFramworkMigrations
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("name=BlogPostDb")
        {
            Database.SetInitializer(new BlogDatabaseInitializer());
            this.Database.Initialize(true);
        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
