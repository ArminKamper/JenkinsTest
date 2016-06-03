namespace EFMigrationTest
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogContext, Migrations.Configuration>());
            using (var db = new BlogContext())
            {
                db.Blogs.Add(new Blog { Name = "Another Blog" });
                db.SaveChanges();

                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(blog.Name);
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
