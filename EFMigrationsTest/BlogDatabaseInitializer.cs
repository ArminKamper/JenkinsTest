namespace EFMigrationTest
{
    using System.Data.Entity;

    public class BlogDatabaseInitializer : CreateDatabaseIfNotExists<BlogContext>
    {
    }
}
