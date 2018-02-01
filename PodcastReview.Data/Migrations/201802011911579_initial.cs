namespace PodcastReview.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Review", "UserName", c => c.String());
            DropColumn("dbo.Review", "Episode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Review", "Episode", c => c.String(maxLength: 200));
            AlterColumn("dbo.Review", "UserName", c => c.String(nullable: false));
        }
    }
}
