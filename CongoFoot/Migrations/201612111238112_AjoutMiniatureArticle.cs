namespace CongoFoot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutMiniatureArticle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Article", "UrlImageOriginale", c => c.String(maxLength: 150));
            AddColumn("dbo.Article", "UrlImageMiniature", c => c.String(maxLength: 150));
            DropColumn("dbo.Article", "UrlImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Article", "UrlImage", c => c.String(maxLength: 60));
            DropColumn("dbo.Article", "UrlImageMiniature");
            DropColumn("dbo.Article", "UrlImageOriginale");
        }
    }
}
