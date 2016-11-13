namespace CongoFoot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titre = c.String(nullable: false, maxLength: 60),
                        Auteur = c.String(nullable: false, maxLength: 60),
                        DatePublication = c.DateTime(nullable: false),
                        UrlImage = c.String(maxLength: 60),
                        Contenu = c.String(),
                        Categorie = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Article");
        }
    }
}
