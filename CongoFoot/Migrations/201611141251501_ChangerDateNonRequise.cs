namespace CongoFoot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangerDateNonRequise : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Article", "DatePublication", c => c.DateTime());
            AlterColumn("dbo.Article", "DateModification", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Article", "DateModification", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Article", "DatePublication", c => c.DateTime(nullable: false));
        }
    }
}
