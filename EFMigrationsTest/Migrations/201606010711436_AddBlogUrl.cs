namespace EFMigrationTest.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddBlogUrl : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.Blogs", "Url", c => c.String());
        }
        
        public override void Down()
        {
            this.DropColumn("dbo.Blogs", "Url");
        }
    }
}
