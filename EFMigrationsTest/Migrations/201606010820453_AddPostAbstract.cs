namespace EFMigrationTest.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddPostAbstract : DbMigration
    {
        public override void Up()
        {
            this.AddColumn("dbo.Posts", "Abstract", c => c.String());

            this.Sql("UPDATE Posts SET Abstract = LEFT(Content, 100) WHERE Abstract IS NULL");
        }
        
        public override void Down()
        {
            this.DropColumn("dbo.Posts", "Abstract");
        }
    }
}
