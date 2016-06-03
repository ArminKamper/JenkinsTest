namespace EFMigrationTest
{
    using System.Data.Entity;

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
