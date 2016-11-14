namespace CongoFoot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutDateModifcationArticle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Article", "DateModification", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Article", "DateModification");
        }
    }
}
