namespace Raktári.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nem",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Megnevezes = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Osztaly",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Nev = c.String(nullable: false, unicode: false),
                    Neme_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Nem", t => t.Neme_ID);
               // .Index(t => t.Neme_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Osztaly", "Neme_ID", "dbo.Nem");
            //DropIndex("dbo.Osztaly", new[] { "Neme_ID" });
            DropTable("dbo.Osztaly");
            DropTable("dbo.Nem");
        }
    }
}
