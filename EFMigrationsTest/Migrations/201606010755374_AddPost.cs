namespace EFMigrationTest.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddPost : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 200),
                        Content = c.String(),
                        BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId)
                .Index(p => p.Title, unique: true);
            
            this.AddColumn("dbo.Blogs", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            this.DropIndex("dbo.Posts", new[] { "Title" });
            this.DropIndex("dbo.Posts", new[] { "BlogId" });
            this.DropForeignKey("dbo.Posts", "BlogId", "dbo.Blogs");
            this.DropColumn("dbo.Blogs", "Rating");
            this.DropTable("dbo.Posts");
        }
    }
}
